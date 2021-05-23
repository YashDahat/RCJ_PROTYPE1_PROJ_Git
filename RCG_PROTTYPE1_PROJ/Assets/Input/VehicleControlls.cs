// GENERATED AUTOMATICALLY FROM 'Assets/Input/VehicleControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VehicleControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VehicleControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VehicleControlls"",
    ""maps"": [
        {
            ""name"": ""FrontWheels"",
            ""id"": ""ff614817-5a61-4d6f-a221-e7e9609d7c36"",
            ""actions"": [
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""b7fbf2d8-4a1c-48c8-8df3-a66b1a2730a7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ae3aad1-1d7b-45b2-9e64-ddcb0ace6959"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RearWheels"",
            ""id"": ""25ab7b54-5ab8-4724-b8a9-5006cacbdaef"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ee77c27d-699a-40f7-8d96-77f03b36dc60"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e3e1f0a3-4b4f-4b6b-af0d-935cc9406a59"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FullControl"",
            ""id"": ""5926c00b-b19c-43b8-a71a-8f1b3d0a0132"",
            ""actions"": [
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""d06f8268-fe5d-45d3-8387-47ff4ac89cd9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b8728069-8c5f-4eee-bfc9-e980fd974340"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""866ffeca-7afc-45fe-8692-1d14df97926c"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83244330-2837-4bea-b43f-25260fb493dc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35f1f59e-dded-4916-8f2c-fc307bc499cf"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4980cc46-fc40-4fe8-a5bc-8354d25e24ae"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // FrontWheels
        m_FrontWheels = asset.FindActionMap("FrontWheels", throwIfNotFound: true);
        m_FrontWheels_Turn = m_FrontWheels.FindAction("Turn", throwIfNotFound: true);
        // RearWheels
        m_RearWheels = asset.FindActionMap("RearWheels", throwIfNotFound: true);
        m_RearWheels_Move = m_RearWheels.FindAction("Move", throwIfNotFound: true);
        // FullControl
        m_FullControl = asset.FindActionMap("FullControl", throwIfNotFound: true);
        m_FullControl_Turn = m_FullControl.FindAction("Turn", throwIfNotFound: true);
        m_FullControl_Move = m_FullControl.FindAction("Move", throwIfNotFound: true);
        m_FullControl_Brake = m_FullControl.FindAction("Brake", throwIfNotFound: true);
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

    // FrontWheels
    private readonly InputActionMap m_FrontWheels;
    private IFrontWheelsActions m_FrontWheelsActionsCallbackInterface;
    private readonly InputAction m_FrontWheels_Turn;
    public struct FrontWheelsActions
    {
        private @VehicleControlls m_Wrapper;
        public FrontWheelsActions(@VehicleControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turn => m_Wrapper.m_FrontWheels_Turn;
        public InputActionMap Get() { return m_Wrapper.m_FrontWheels; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FrontWheelsActions set) { return set.Get(); }
        public void SetCallbacks(IFrontWheelsActions instance)
        {
            if (m_Wrapper.m_FrontWheelsActionsCallbackInterface != null)
            {
                @Turn.started -= m_Wrapper.m_FrontWheelsActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_FrontWheelsActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_FrontWheelsActionsCallbackInterface.OnTurn;
            }
            m_Wrapper.m_FrontWheelsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
            }
        }
    }
    public FrontWheelsActions @FrontWheels => new FrontWheelsActions(this);

    // RearWheels
    private readonly InputActionMap m_RearWheels;
    private IRearWheelsActions m_RearWheelsActionsCallbackInterface;
    private readonly InputAction m_RearWheels_Move;
    public struct RearWheelsActions
    {
        private @VehicleControlls m_Wrapper;
        public RearWheelsActions(@VehicleControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_RearWheels_Move;
        public InputActionMap Get() { return m_Wrapper.m_RearWheels; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RearWheelsActions set) { return set.Get(); }
        public void SetCallbacks(IRearWheelsActions instance)
        {
            if (m_Wrapper.m_RearWheelsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_RearWheelsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_RearWheelsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_RearWheelsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_RearWheelsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public RearWheelsActions @RearWheels => new RearWheelsActions(this);

    // FullControl
    private readonly InputActionMap m_FullControl;
    private IFullControlActions m_FullControlActionsCallbackInterface;
    private readonly InputAction m_FullControl_Turn;
    private readonly InputAction m_FullControl_Move;
    private readonly InputAction m_FullControl_Brake;
    public struct FullControlActions
    {
        private @VehicleControlls m_Wrapper;
        public FullControlActions(@VehicleControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turn => m_Wrapper.m_FullControl_Turn;
        public InputAction @Move => m_Wrapper.m_FullControl_Move;
        public InputAction @Brake => m_Wrapper.m_FullControl_Brake;
        public InputActionMap Get() { return m_Wrapper.m_FullControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FullControlActions set) { return set.Get(); }
        public void SetCallbacks(IFullControlActions instance)
        {
            if (m_Wrapper.m_FullControlActionsCallbackInterface != null)
            {
                @Turn.started -= m_Wrapper.m_FullControlActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_FullControlActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_FullControlActionsCallbackInterface.OnTurn;
                @Move.started -= m_Wrapper.m_FullControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FullControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FullControlActionsCallbackInterface.OnMove;
                @Brake.started -= m_Wrapper.m_FullControlActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_FullControlActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_FullControlActionsCallbackInterface.OnBrake;
            }
            m_Wrapper.m_FullControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
            }
        }
    }
    public FullControlActions @FullControl => new FullControlActions(this);
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    public interface IFrontWheelsActions
    {
        void OnTurn(InputAction.CallbackContext context);
    }
    public interface IRearWheelsActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IFullControlActions
    {
        void OnTurn(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
    }
}
