// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""eaf3b48e-d4da-484b-930f-b2554a10e54e"",
            ""actions"": [
                {
                    ""name"": ""Power Attack"",
                    ""type"": ""Button"",
                    ""id"": ""5fa9fb75-f52a-483a-9894-0f1f3266d2bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement - Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""99f6bfc6-3678-4094-9d9d-491172528eb5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Low Attack"",
                    ""type"": ""Button"",
                    ""id"": ""b936b6f5-577a-4777-8b0e-dc1dce7dcf49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""High Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c37e49be-4135-4f14-8dca-d9cee03f71e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""Button"",
                    ""id"": ""26ef9ecd-b0a1-4faa-b970-978e9848196b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""886b246f-a5e8-4cf7-acc6-0f75e22532bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Duck"",
                    ""type"": ""Button"",
                    ""id"": ""700219a6-f117-499f-9d7b-04e146eb2a66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9949ccdf-9dca-4009-8dee-632305f627e6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Power Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""826e83d8-9fe3-46be-87b9-3df1880f7839"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Power Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""2adbb7e1-b2e5-49a0-a440-16536ec38c32"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement - Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c1af2c01-9ddb-4c69-ac8c-31020cb5f245"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement - Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4ba59997-40bc-4bba-9384-1bf6983df502"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement - Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad - Horizontal"",
                    ""id"": ""fec288ae-e753-4444-aec4-fbc0209d45ed"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement - Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5fb8c888-d927-4b11-a0f2-dd8c4f51b0bb"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement - Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""69b77f69-bc69-41e6-a486-ebb91130dfb2"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement - Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4815a2ee-5ab7-49fd-ae60-80fe849d3f14"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Low Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f45735e-f830-48c7-bda8-e64d2c7d6456"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Low Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ccccd54-a3d9-4987-a08b-216814904a4a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""High Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""162a2e3b-c19e-4baf-a349-1e19436055e9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""High Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d7b81ee-93ac-475c-99dc-3538a54d6ea1"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0bc1e36-c9cb-45ed-ade0-b932e3176b87"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73496219-1925-453b-a379-e94f94a48419"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""441d07f1-237d-4ed4-9431-5777326cc0a9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b80f5d7-fe26-488d-bb79-203c572da6d3"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbf80c4c-804f-41fd-b439-a0459e828a11"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Duck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_PowerAttack = m_Controls.FindAction("Power Attack", throwIfNotFound: true);
        m_Controls_MovementHorizontal = m_Controls.FindAction("Movement - Horizontal", throwIfNotFound: true);
        m_Controls_LowAttack = m_Controls.FindAction("Low Attack", throwIfNotFound: true);
        m_Controls_HighAttack = m_Controls.FindAction("High Attack", throwIfNotFound: true);
        m_Controls_Defense = m_Controls.FindAction("Defense", throwIfNotFound: true);
        m_Controls_Jump = m_Controls.FindAction("Jump", throwIfNotFound: true);
        m_Controls_Duck = m_Controls.FindAction("Duck", throwIfNotFound: true);
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

    // Controls
    private readonly InputActionMap m_Controls;
    private IControlsActions m_ControlsActionsCallbackInterface;
    private readonly InputAction m_Controls_PowerAttack;
    private readonly InputAction m_Controls_MovementHorizontal;
    private readonly InputAction m_Controls_LowAttack;
    private readonly InputAction m_Controls_HighAttack;
    private readonly InputAction m_Controls_Defense;
    private readonly InputAction m_Controls_Jump;
    private readonly InputAction m_Controls_Duck;
    public struct ControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public ControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PowerAttack => m_Wrapper.m_Controls_PowerAttack;
        public InputAction @MovementHorizontal => m_Wrapper.m_Controls_MovementHorizontal;
        public InputAction @LowAttack => m_Wrapper.m_Controls_LowAttack;
        public InputAction @HighAttack => m_Wrapper.m_Controls_HighAttack;
        public InputAction @Defense => m_Wrapper.m_Controls_Defense;
        public InputAction @Jump => m_Wrapper.m_Controls_Jump;
        public InputAction @Duck => m_Wrapper.m_Controls_Duck;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @PowerAttack.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPowerAttack;
                @PowerAttack.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPowerAttack;
                @PowerAttack.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnPowerAttack;
                @MovementHorizontal.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMovementHorizontal;
                @MovementHorizontal.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMovementHorizontal;
                @MovementHorizontal.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnMovementHorizontal;
                @LowAttack.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnLowAttack;
                @LowAttack.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnLowAttack;
                @LowAttack.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnLowAttack;
                @HighAttack.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnHighAttack;
                @HighAttack.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnHighAttack;
                @HighAttack.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnHighAttack;
                @Defense.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnDefense;
                @Defense.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnDefense;
                @Defense.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnDefense;
                @Jump.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnJump;
                @Duck.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnDuck;
                @Duck.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnDuck;
                @Duck.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnDuck;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PowerAttack.started += instance.OnPowerAttack;
                @PowerAttack.performed += instance.OnPowerAttack;
                @PowerAttack.canceled += instance.OnPowerAttack;
                @MovementHorizontal.started += instance.OnMovementHorizontal;
                @MovementHorizontal.performed += instance.OnMovementHorizontal;
                @MovementHorizontal.canceled += instance.OnMovementHorizontal;
                @LowAttack.started += instance.OnLowAttack;
                @LowAttack.performed += instance.OnLowAttack;
                @LowAttack.canceled += instance.OnLowAttack;
                @HighAttack.started += instance.OnHighAttack;
                @HighAttack.performed += instance.OnHighAttack;
                @HighAttack.canceled += instance.OnHighAttack;
                @Defense.started += instance.OnDefense;
                @Defense.performed += instance.OnDefense;
                @Defense.canceled += instance.OnDefense;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Duck.started += instance.OnDuck;
                @Duck.performed += instance.OnDuck;
                @Duck.canceled += instance.OnDuck;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IControlsActions
    {
        void OnPowerAttack(InputAction.CallbackContext context);
        void OnMovementHorizontal(InputAction.CallbackContext context);
        void OnLowAttack(InputAction.CallbackContext context);
        void OnHighAttack(InputAction.CallbackContext context);
        void OnDefense(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDuck(InputAction.CallbackContext context);
    }
}