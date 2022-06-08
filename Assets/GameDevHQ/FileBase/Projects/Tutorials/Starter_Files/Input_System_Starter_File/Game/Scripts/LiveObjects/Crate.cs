using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Crate : MonoBehaviour
    {
        [SerializeField] private float _punchDelay;
        [SerializeField] private GameObject _wholeCrate, _brokenCrate;
        [SerializeField] private Rigidbody[] _pieces;
        [SerializeField] private BoxCollider _crateCollider;
        //[SerializeField] private InteractableZone _interactableZone;
        [SerializeField] private ZoneInteractions _crateZoneInteraction;
        private bool _isReadyToBreak = false;
        private InputActions _inputActions;
        private string _punchInteractionType;

        private List<Rigidbody> _brakeOff = new List<Rigidbody>();

        private void OnEnable()
        {
            //InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            ZoneInteractions.onZoneInteractionComplete += ZoneInteractionsOnonZoneInteractionComplete;
        }

        private void Start()
        {
            _inputActions = new InputActions();
            _inputActions.Character.Enable();
            _inputActions.Character.Punch.performed += PunchOnperformed;
            _brakeOff.AddRange(_pieces);
        }

        private void PunchOnperformed(InputAction.CallbackContext context)
        {
            //Debug.Log("PunchOnPerformed context: " + context);
            //Debug.Log("Tap or Hold: " + context.interaction);
            
            _punchInteractionType = context.interaction.ToString();
            
            // if (_punchInteractionType == "UnityEngine.InputSystem.Interactions.MultiTapInteraction")
            // {
            //     Debug.Log("Multitap");
            // } else if (_punchInteractionType == "UnityEngine.InputSystem.Interactions.HoldInteraction")
            // {
            //     Debug.Log("Hold");
            // }
            
            ZoneInteractionsOnonZoneInteractionComplete(_crateZoneInteraction);
        }

        private void ZoneInteractionsOnonZoneInteractionComplete(ZoneInteractions zone)
        {
            if (_isReadyToBreak == false && _brakeOff.Count > 0)
            {
                _wholeCrate.SetActive(false);
                _brokenCrate.SetActive(true);
                _isReadyToBreak = true;
            }

            if (_isReadyToBreak && zone.GetZoneID() == 6) //Crate zone            
            {
                if (_brakeOff.Count > 0)
                {
                    if (_punchInteractionType == "UnityEngine.InputSystem.Interactions.MultiTapInteraction")
                    {
                        //Debug.Log("Multitap");
                        BreakPart(false);
                    } else if (_punchInteractionType == "UnityEngine.InputSystem.Interactions.HoldInteraction")
                    {
                        //Debug.Log("Hold");
                        BreakPart(true);
                    }
                    // BreakPart();
                    StartCoroutine(PunchDelay());
                }
                else if(_brakeOff.Count == 0)
                {
                    _isReadyToBreak = false;
                    _crateCollider.enabled = false;
                    _crateZoneInteraction.CompleteTask(6);
                    //_interactableZone.CompleteTask(6);
                    Debug.Log("Completely Busted");
                }
            }
        }
        
        // private void Start()
        // {
        //     _brakeOff.AddRange(_pieces);
        // }
        
        public void BreakPart(bool extraDamage)
        {
            int numOfLoops = 1;

            if (extraDamage)
            {
                switch (_brakeOff.Count)
                {
                    case > 2:
                        numOfLoops = 3;
                        break;
                    case 2:
                        numOfLoops = 2;
                        break;
                }
                
                // if (_brakeOff.Count > 3)
                // {
                //     numOfLoops = 3;
                // } else if (_brakeOff.Count = 2)
                // {
                //     numOfLoops = 2;
                // }
                // else
                // {
                //     numOfLoops = 1;
                // }
                
                //Debug.Log("extraDamage = true");
            }
            else
            {
                numOfLoops = 1;
            }

            for (int i = 0; i < numOfLoops; i++)
            {
                int rng = Random.Range(0, _brakeOff.Count);
                _brakeOff[rng].constraints = RigidbodyConstraints.None;
                _brakeOff[rng].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
                _brakeOff.Remove(_brakeOff[rng]);  
            }
        }

        IEnumerator PunchDelay()
        {
            float delayTimer = 0;
            while (delayTimer < _punchDelay)
            {
                yield return new WaitForEndOfFrame();
                delayTimer += Time.deltaTime;
            }

            //_interactableZone.ResetAction(6);
            _crateZoneInteraction.ResetAction(6);
        }

        private void OnDisable()
        {
            //InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
            ZoneInteractions.onZoneInteractionComplete -= ZoneInteractionsOnonZoneInteractionComplete;
        }
    }
}
