using System;
using System.Linq;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField]
        private Vector3 _liftLowerLimit, _liftUpperLimit;
        [SerializeField]
        private float _speed = 5f, _liftSpeed = 1f;
        [SerializeField]
        private CinemachineVirtualCamera _forkliftCam;
        [SerializeField]
        private GameObject _driverModel;
        private bool _inDriveMode = false;
        //[SerializeField]
        //private InteractableZone _interactableZone;
        [SerializeField] ZoneInteractions _forkliftZoneInteraction;
        private InputActions _inputActions;

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;

        private void OnEnable()
        {
            //InteractableZone.onZoneInteractionComplete += EnterDriveMode;
            ZoneInteractions.onZoneInteractionComplete += EnterDriveMode;
            
        }
        
        private void Start()
        {
            _inputActions = new InputActions();
            _inputActions.Drive.Exit.performed += ExitOnperformed;
        }
        
        private void ExitOnperformed(InputAction.CallbackContext context)
        {
            ExitDriveMode();
        }
        
        private void EnterDriveMode(ZoneInteractions zone)
        {
            if (_inDriveMode !=true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                onDriveModeEntered?.Invoke();
                _driverModel.SetActive(true);
                _forkliftZoneInteraction.CompleteTask(5);
                //_interactableZone.CompleteTask(5);
                _inputActions.Drive.Enable();
            }
        }

        private void ExitDriveMode()
        {
            _inDriveMode = false;
            _forkliftCam.Priority = 9;            
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();
            _inputActions.Drive.Disable();
        }

        private void Update()
        {
            if (_inDriveMode == true)
            {
                LiftControls();
                CalcutateMovement();
                //if (Input.GetKeyDown(KeyCode.Escape))
                    // ExitDriveMode();
            }
        }

        private void CalcutateMovement()
        {
            Vector2 inputMovement = _inputActions.Drive.Move.ReadValue<Vector2>();
            
            // float h = Input.GetAxisRaw("Horizontal");
            // float v = Input.GetAxisRaw("Vertical");
            //var direction = new Vector3(0, 0, v);
            Vector3 direction = new Vector3(0, 0, inputMovement.y);
            var velocity = direction * _speed;

            transform.Translate(velocity * Time.deltaTime);

            //if (Mathf.Abs(v) > 0)
            if (Mathf.Abs(inputMovement.y) > 0)
            {
                var tempRot = transform.rotation.eulerAngles;
               // tempRot.y += h * _speed / 2;
               tempRot.y += inputMovement.x * _speed / 2;
               transform.rotation = Quaternion.Euler(tempRot);
            }
        }

        private void LiftControls()
        {
            if (_inputActions.Drive.SecondaryMovement.IsPressed())
            {
                if (_inputActions.Drive.SecondaryMovement.ReadValue<float>() > 0)
                {
                    LiftUpRoutine();
                }

                if (_inputActions.Drive.SecondaryMovement.ReadValue<float>() < 0)
                {
                    LiftDownRoutine();
                }
            }
            
            // if (Input.GetKey(KeyCode.R))
            //     LiftUpRoutine();
            // else if (Input.GetKey(KeyCode.T))
            //     LiftDownRoutine();
        }

        private void LiftUpRoutine()
        {
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        private void LiftDownRoutine()
        {
            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }

        private void OnDisable()
        {
            //InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
            ZoneInteractions.onZoneInteractionComplete -= EnterDriveMode;
        }
    }
}