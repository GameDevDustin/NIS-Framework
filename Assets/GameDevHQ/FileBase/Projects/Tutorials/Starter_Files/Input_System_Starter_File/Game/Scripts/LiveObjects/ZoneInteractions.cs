using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.UI;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class ZoneInteractions : MonoBehaviour
    {
        private enum ZoneType
        {
            Collectable, Action, HoldAction
        }

        private InputActions _inputActions;
        [SerializeField] private ZoneType _zoneType;
        [SerializeField] private int _zoneID;
        [SerializeField] private int _requiredID;
        [SerializeField] [Tooltip("Hold the (---) Key to .....")]
        private string _displayMessage;

        private string _interactionKeyBinding;
        
        [SerializeField] private GameObject[] _zoneItems;
        private bool _inZone = false;
        private bool _itemsCollected = false;
        private bool _actionPerformed = false;
        [SerializeField] private Sprite _inventoryIcon;
        [SerializeField] private GameObject _marker;
        static int _currentZoneID = 0;
        public static int CurrentZoneID
        { 
            get 
            { return _currentZoneID; }
            set
            { _currentZoneID = value; }
        }

        public static event Action<ZoneInteractions> onZoneInteractionComplete;
        
        private void OnEnable()
        {
            ZoneInteractions.onZoneInteractionComplete += SetMarker;
        }
        
        private void Awake()
        {
            _inputActions = new InputActions();
            _interactionKeyBinding = _inputActions.Character.Interact.bindings[0].ToString().Substring(_inputActions.Character.Interact.bindings[0].ToString().Length - 1).ToUpper();
            
            _inputActions.Character.Enable();
            _inputActions.Character.Interact.performed += InteractOnperformed;
            _inputActions.Character.InteractHold.performed += InteractHoldOnperformed;
        }

        private void InteractHoldOnperformed(InputAction.CallbackContext context)
        {
            if (_inZone)
            {
                switch (_zoneType)
                {
                    case ZoneType.HoldAction:
                        PerformHoldAction();
                        _actionPerformed = true;
                        break;
                }
            }
        }

        private void InteractOnperformed(InputAction.CallbackContext context)
        {
            if (_inZone)
            {
                switch (_zoneType)
                {
                    case ZoneType.Collectable:
                        if (_itemsCollected == false)
                        {
                            CollectItems();
                            _itemsCollected = true;
                            UIManager.Instance.DisplayInteractableZoneMessage(false);
                        }
                        break;

                    case ZoneType.Action:
                        if (_actionPerformed == false)
                        {
                            PerformAction();
                            _actionPerformed = true;
                            UIManager.Instance.DisplayInteractableZoneMessage(false);
                        }
                        break;
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && _currentZoneID > _requiredID)
            {
                switch (_zoneType)
                {
                    case ZoneType.Collectable:
                        if (_itemsCollected == false)
                        {
                            _inZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the {_interactionKeyBinding} key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the {_interactionKeyBinding} key to collect");
                        }
                        break;

                    case ZoneType.Action:
                        if (_actionPerformed == false)
                        {
                            _inZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the {_interactionKeyBinding} key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the {_interactionKeyBinding} key to perform action");
                        }
                        break;

                    case ZoneType.HoldAction:
                        _inZone = true;
                        if (_displayMessage != null)
                        {
                            string message = $"Hold the {_interactionKeyBinding} key to {_displayMessage}.";
                            UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                        }
                        else
                            UIManager.Instance.DisplayInteractableZoneMessage(true, $"Hold the {_interactionKeyBinding} key to perform action");
                        break;
                }
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _inZone = false;
                UIManager.Instance.DisplayInteractableZoneMessage(false);
            }
        }
        
        private void CollectItems()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(false);
            }

            UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);

            CompleteTask(_zoneID);
            onZoneInteractionComplete?.Invoke(this);
        }

        private void PerformAction()
        {
            if (_zoneItems.Length > 0)
            {
                foreach (var item in _zoneItems)
                {
                    item.SetActive(true);
                }
            }

            if (_inventoryIcon != null)
            {
                UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);
            }
                
            onZoneInteractionComplete?.Invoke(this);
        }

        private void PerformHoldAction()
        {
            UIManager.Instance.DisplayInteractableZoneMessage(false);
        }
        
        public void CompleteTask(int zoneID)
        {
            if (zoneID == _zoneID)
            {
                _currentZoneID++;
                //Debug.Log(_currentZoneID);
                onZoneInteractionComplete?.Invoke(this);
            }
        }
        
        public GameObject[] GetItems()
        {
            return _zoneItems;
        }

        public int GetZoneID()
        {
            return _zoneID;
        }
        
        public void ResetAction(int zoneID)
        {
            if (zoneID == _zoneID)
                _actionPerformed = false;
        }
        
        public void SetMarker(ZoneInteractions zone)
        {
            if (_zoneID == _currentZoneID)
                _marker.SetActive(true);
            else
                _marker.SetActive(false);
        }
        
        private void OnDisable()
        {
            ZoneInteractions.onZoneInteractionComplete -= SetMarker;
            _inputActions.Character.Interact.performed -= InteractOnperformed;
            _inputActions.Character.InteractHold.performed -= InteractHoldOnperformed;
        }    
    }
}


