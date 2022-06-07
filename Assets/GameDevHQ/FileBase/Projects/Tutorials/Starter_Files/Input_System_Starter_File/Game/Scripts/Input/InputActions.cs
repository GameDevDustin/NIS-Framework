//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GameDevHQ/FileBase/Projects/Tutorials/Starter_Files/Input_System_Starter_File/Game/Scripts/Input/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""075c81bf-7e30-4b9d-8ea1-3f20bfd85844"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7637002c-26d2-47fb-922a-0ec97b69c462"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""cfda8b24-1549-4834-8262-c27298a11fe2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""InteractHold"",
                    ""type"": ""Button"",
                    ""id"": ""a6964185-7b3a-4360-a5d1-4e20c870f251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.4)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""eb529c69-1a75-43a0-bf9a-69703bbc0bfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8fe725c9-b4fd-4201-9760-f65f8ee3b5b3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dfc89097-ed09-47cd-aa5e-3f912f809725"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53f5437c-f46f-49d8-8cae-c17639b113bd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a364ffb3-7966-41e3-8f7b-b2f2665566f2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a6e3effc-ebfb-4192-871a-26057822dac8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector ALT"",
                    ""id"": ""ba54ae3d-0448-4302-b4a9-7a156beb9346"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8df21654-606d-4bd3-95a5-e42c3d823d30"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""36a43e87-cfb1-4712-b837-07b25b1a3eec"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""24185748-0880-4e1a-aaa4-3f5ee733daeb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8deb61eb-f6ce-42c5-af07-78f2efe6475d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""65b2c284-0aad-4e09-93f4-9323e0e8dea3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd153f4e-6421-4b64-9247-9ef0334ec6cb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InteractHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2179740-6bb4-49bc-b7ed-bef7ec44673b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""859deae7-1bc8-4b2f-afd9-cf955a96c24f"",
            ""actions"": [
                {
                    ""name"": ""Tilt"",
                    ""type"": ""Value"",
                    ""id"": ""7c169edb-36cd-40fa-895d-6c731c4759fb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""4b83ef47-6d54-4e24-85b1-4e35ec4e6123"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""4c1f03fb-3f1c-4cd5-bbc4-7828ff8fe233"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ExitFlightMode"",
                    ""type"": ""Button"",
                    ""id"": ""5933c3d1-0f57-406d-90c3-1004fb0d37b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8b78f96c-a337-4cde-aeff-9688ece420d5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5993e8e5-2080-4fd3-8457-b4849b305fc1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20ecbfdb-2355-4cde-a179-cc5434200d5c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1a8e53d1-ed1a-46a3-b589-58460a9b740d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4c95bdce-f280-47b5-b412-3fb8627d208a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d699cdd8-4526-40ce-9cf4-179749339646"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""32494e44-3e5a-4eb8-86dd-a5b62dbc6b63"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8e5806f8-3e6f-40a2-9ec8-f21dbda86957"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b57595e6-fe96-49a4-b894-e558ccbd5e73"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""70cb264e-693d-49fa-9527-b6cf2f74d33e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c35b3034-cf87-4e41-87de-696bbe33ef22"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f6e39940-93e0-4776-9f2e-8f5f27112101"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitFlightMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Move = m_Character.FindAction("Move", throwIfNotFound: true);
        m_Character_Interact = m_Character.FindAction("Interact", throwIfNotFound: true);
        m_Character_InteractHold = m_Character.FindAction("InteractHold", throwIfNotFound: true);
        m_Character_Escape = m_Character.FindAction("Escape", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Tilt = m_Drone.FindAction("Tilt", throwIfNotFound: true);
        m_Drone_Vertical = m_Drone.FindAction("Vertical", throwIfNotFound: true);
        m_Drone_Rotate = m_Drone.FindAction("Rotate", throwIfNotFound: true);
        m_Drone_ExitFlightMode = m_Drone.FindAction("ExitFlightMode", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Move;
    private readonly InputAction m_Character_Interact;
    private readonly InputAction m_Character_InteractHold;
    private readonly InputAction m_Character_Escape;
    public struct CharacterActions
    {
        private @InputActions m_Wrapper;
        public CharacterActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Character_Move;
        public InputAction @Interact => m_Wrapper.m_Character_Interact;
        public InputAction @InteractHold => m_Wrapper.m_Character_InteractHold;
        public InputAction @Escape => m_Wrapper.m_Character_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteract;
                @InteractHold.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteractHold;
                @InteractHold.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteractHold;
                @InteractHold.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnInteractHold;
                @Escape.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @InteractHold.started += instance.OnInteractHold;
                @InteractHold.performed += instance.OnInteractHold;
                @InteractHold.canceled += instance.OnInteractHold;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_Tilt;
    private readonly InputAction m_Drone_Vertical;
    private readonly InputAction m_Drone_Rotate;
    private readonly InputAction m_Drone_ExitFlightMode;
    public struct DroneActions
    {
        private @InputActions m_Wrapper;
        public DroneActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tilt => m_Wrapper.m_Drone_Tilt;
        public InputAction @Vertical => m_Wrapper.m_Drone_Vertical;
        public InputAction @Rotate => m_Wrapper.m_Drone_Rotate;
        public InputAction @ExitFlightMode => m_Wrapper.m_Drone_ExitFlightMode;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @Tilt.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnTilt;
                @Tilt.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnTilt;
                @Tilt.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnTilt;
                @Vertical.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnVertical;
                @Rotate.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRotate;
                @ExitFlightMode.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnExitFlightMode;
                @ExitFlightMode.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnExitFlightMode;
                @ExitFlightMode.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnExitFlightMode;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tilt.started += instance.OnTilt;
                @Tilt.performed += instance.OnTilt;
                @Tilt.canceled += instance.OnTilt;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ExitFlightMode.started += instance.OnExitFlightMode;
                @ExitFlightMode.performed += instance.OnExitFlightMode;
                @ExitFlightMode.canceled += instance.OnExitFlightMode;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);
    public interface ICharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInteractHold(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnTilt(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnExitFlightMode(InputAction.CallbackContext context);
    }
}
