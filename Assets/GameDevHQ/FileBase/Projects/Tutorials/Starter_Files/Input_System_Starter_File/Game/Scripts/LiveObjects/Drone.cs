using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Game.Scripts.UI;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Drone : MonoBehaviour
    {
        private enum Tilt
        {
            NoTilt, Forward, Back, Left, Right
        }

        [SerializeField]
        private Rigidbody _rigidbody;
        [SerializeField]
        private float _speed = 5f;
        private bool _inFlightMode = false;
        [SerializeField]
        private Animator _propAnim;
        [SerializeField]
        private CinemachineVirtualCamera _droneCam;
        // [SerializeField]
        // private InteractableZone _interactableZone;

        [SerializeField] private ZoneInteractions _droneZoneInteraction;

        private InputActions _inputActions;
        private Vector2 _tiltInput;

        public static event Action OnEnterFlightMode;
        public static event Action onExitFlightmode;

        private void Awake()
        {
            _inputActions = new InputActions();
        }

        private void OnEnable()
        {
            //InteractableZone.onZoneInteractionComplete += EnterFlightMode;
            ZoneInteractions.onZoneInteractionComplete += EnterFlightMode;
        }

        private void EnterFlightMode(ZoneInteractions zone)
        {
            if (_inFlightMode != true && zone.GetZoneID() == 4) // drone Scene
            {
                _propAnim.SetTrigger("StartProps");
                _droneCam.Priority = 11;
                _inFlightMode = true;
                OnEnterFlightMode?.Invoke();
                UIManager.Instance.DroneView(true);
                _droneZoneInteraction.CompleteTask(4);
                
                _inputActions.Drone.Enable();
                _inputActions.Drone.ExitFlightMode.performed += ExitFlightModeOnperformed;
            }
        }
        
        private void ExitFlightModeOnperformed(InputAction.CallbackContext context)
        {
            if (_inFlightMode)
            {
                _inFlightMode = false;
                onExitFlightmode?.Invoke();
                ExitFlightMode();
            }
        }

        private void ExitFlightMode()
        {            
            _droneCam.Priority = 9;
            _inFlightMode = false;
            UIManager.Instance.DroneView(false);
            _inputActions.Drone.Disable();
        }

        private void Update()
        {
            if (_inFlightMode)
            {
                CalculateTilt();
                CalculateMovementUpdate();
            }
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(transform.up * (9.81f), ForceMode.Acceleration);
            
            if (_inFlightMode)
            {
                CalculateMovementFixedUpdate(); 
            }
        }

        private void CalculateMovementUpdate()
        {
            if (_inFlightMode)
            {
                //rotate left
                if (_inputActions.Drone.Rotate.ReadValue<float>() < 0)
                {
                    var tempRot = transform.localRotation.eulerAngles;
                    tempRot.y -= _speed / 3;
                    transform.localRotation = Quaternion.Euler(tempRot);
                }
                
                //rotate right
                if (_inputActions.Drone.Rotate.ReadValue<float>() > 0)
                {
                    var tempRot = transform.localRotation.eulerAngles;
                    tempRot.y += _speed / 3;
                    transform.localRotation = Quaternion.Euler(tempRot);
                }
            }
        }

        private void CalculateMovementFixedUpdate()
        {
            if (_inputActions.Drone.Vertical.IsPressed())
            {
                if (_inputActions.Drone.Vertical.ReadValue<float>() > 0)
                {
                    _rigidbody.AddForce(transform.up * _speed, ForceMode.Acceleration);
                }
                if (_inputActions.Drone.Vertical.ReadValue<float>() < 0)
                {
                    _rigidbody.AddForce(-transform.up * _speed, ForceMode.Acceleration);
                }
            }
        }

        private void CalculateTilt()
        {
            
            _tiltInput = _inputActions.Drone.Tilt.ReadValue<Vector2>();

            switch (_tiltInput.x)
            {
                //D key
                case 1:
                    transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, -30);
                    break;
                //A key
                case -1:
                    transform.rotation = Quaternion.Euler(00, transform.localRotation.eulerAngles.y, 30);
                    break;
            }

            switch (_tiltInput.y)
            {
                //W key
                case 1:
                    transform.rotation = Quaternion.Euler(30, transform.localRotation.eulerAngles.y, 0);
                    break;
                //S key
                case -1:
                    transform.rotation = Quaternion.Euler(-30, transform.localRotation.eulerAngles.y, 0);
                    break;
            }

            if (_tiltInput.x == 0 && _tiltInput.y == 0)
            {
                transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 0);
            }
        }

        private void OnDisable()
        {
            //InteractableZone.onZoneInteractionComplete -= EnterFlightMode;
            ZoneInteractions.onZoneInteractionComplete -= EnterFlightMode;
        }
    }
}
