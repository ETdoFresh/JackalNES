//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/InputActions.inputactions
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
            ""name"": ""Menu"",
            ""id"": ""75ba9df1-74c6-4dbe-8466-2399e439fc0d"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""363fa4f4-c065-4e5c-ab7d-d98b001ee082"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""475255e5-6e81-4556-ad32-9ce3b50ce51c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a5c69f77-82cd-4ccd-a001-789697b27a24"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0a64233-6c54-4a8d-a394-f30f4ccd8a7a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dce0dac-264f-4fa6-820a-0d53b52fa62a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bcc0ec1-2171-45d7-88a3-1e93d5e339bd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65cdb941-7ac0-4f56-953d-25e058711490"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""bb1dda49-5af9-40e5-b0cd-83cad1be4241"",
            ""actions"": [
                {
                    ""name"": ""Movement P1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4ced3148-8444-4e68-b997-73218d463ff3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot Bullet"",
                    ""type"": ""Button"",
                    ""id"": ""b23fd7ff-9425-43fe-905b-0a4d33a185c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot Grenade"",
                    ""type"": ""Button"",
                    ""id"": ""627836c8-a787-4bb9-a693-29172f229cbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2617bb3e-a0f9-4a60-be0d-b5848a682f72"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""391bb939-11f3-42b4-860f-e415f41da5c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0c69b7bc-9906-4acd-bfa0-05d3bd69f525"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""51fc4a60-06ca-4aea-a1bf-e49f0cbb348e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2b04af9-0126-4ff9-b3b1-221ab458d1dd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e6bdb2e5-cf4b-4d60-995f-5afc8b4a54af"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80c14c99-1d7f-46d8-9360-e4ad23d0b665"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""134bad68-03dd-453b-a3c2-1312318c1035"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Bullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b2be9f1-ea7d-40d0-a797-89c182aa6405"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Bullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e5c197b-c4cc-4b6c-abf8-80b38ebbc8e6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Bullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a96332f4-9266-4918-90a5-42c66ce14d1e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Grenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e79c33d9-cc14-4348-bbf5-dfc2aaab29dd"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Grenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65abfcaa-4e87-4551-979a-62790e8b612a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot Grenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Start = m_Menu.FindAction("Start", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_MovementP1 = m_Gameplay.FindAction("Movement P1", throwIfNotFound: true);
        m_Gameplay_ShootBullet = m_Gameplay.FindAction("Shoot Bullet", throwIfNotFound: true);
        m_Gameplay_ShootGrenade = m_Gameplay.FindAction("Shoot Grenade", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Start;
    private readonly InputAction m_Menu_Select;
    public struct MenuActions
    {
        private @InputActions m_Wrapper;
        public MenuActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_MovementP1;
    private readonly InputAction m_Gameplay_ShootBullet;
    private readonly InputAction m_Gameplay_ShootGrenade;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementP1 => m_Wrapper.m_Gameplay_MovementP1;
        public InputAction @ShootBullet => m_Wrapper.m_Gameplay_ShootBullet;
        public InputAction @ShootGrenade => m_Wrapper.m_Gameplay_ShootGrenade;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @MovementP1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovementP1;
                @MovementP1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovementP1;
                @MovementP1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovementP1;
                @ShootBullet.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootBullet;
                @ShootBullet.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootBullet;
                @ShootBullet.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootBullet;
                @ShootGrenade.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootGrenade;
                @ShootGrenade.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootGrenade;
                @ShootGrenade.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootGrenade;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementP1.started += instance.OnMovementP1;
                @MovementP1.performed += instance.OnMovementP1;
                @MovementP1.canceled += instance.OnMovementP1;
                @ShootBullet.started += instance.OnShootBullet;
                @ShootBullet.performed += instance.OnShootBullet;
                @ShootBullet.canceled += instance.OnShootBullet;
                @ShootGrenade.started += instance.OnShootGrenade;
                @ShootGrenade.performed += instance.OnShootGrenade;
                @ShootGrenade.canceled += instance.OnShootGrenade;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IMenuActions
    {
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IGameplayActions
    {
        void OnMovementP1(InputAction.CallbackContext context);
        void OnShootBullet(InputAction.CallbackContext context);
        void OnShootGrenade(InputAction.CallbackContext context);
    }
}
