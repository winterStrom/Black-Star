// GENERATED AUTOMATICALLY FROM 'Assets/InpuSystem/PlayerInputActions.inputactions'

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
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""GamePlayer"",
            ""id"": ""eb32ec46-59c3-439b-9fd9-f36fe8017296"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""da1d95e3-f467-4cbc-8a12-95812bacec0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a396c3e7-57b3-4073-ab6b-a273429957d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""2196c5b7-346a-4454-a606-b848a922849e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""0519b4b4-c043-42ba-891b-662b68982e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterDoor"",
                    ""type"": ""Button"",
                    ""id"": ""85593ed6-7b3e-46d2-8ec9-767eb85eee53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArrowHit"",
                    ""type"": ""Button"",
                    ""id"": ""513ca76a-7a6b-4464-81a7-638c0ec1a50f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Open Bag"",
                    ""type"": ""Button"",
                    ""id"": ""6125eb1e-7fee-4ab7-a2dc-a6c71709eb94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DoorToNextLevel"",
                    ""type"": ""Button"",
                    ""id"": ""08de6bd1-2c91-4ed8-95b4-0c0e76346ace"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseCardQ"",
                    ""type"": ""Button"",
                    ""id"": ""abb8b09a-5c0c-4faf-ad7e-027d2085192c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseCardE"",
                    ""type"": ""Button"",
                    ""id"": ""d443f704-ad4a-4b15-92fa-f514bfc31f53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""87ffa355-782a-4a11-9d3a-edb6d16e4922"",
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
                    ""id"": ""f6eb41d5-d67b-4d75-be0b-04c221808383"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""23a78503-62aa-4897-8242-5a47938f69ab"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e449e66d-e6c5-4caf-9c35-ee91b0c4aa4e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""27d2ad97-cbca-491f-82db-f222f6c14f20"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""82d6779a-09f0-4313-85b2-f7a2abed9b88"",
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
                    ""id"": ""9c523a56-1d3a-4052-96dc-63f2d6534c97"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""506b396c-220b-4a76-924c-cad0579b6b1f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""875af366-b667-4199-bf88-116905fe24c0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9bd206e4-0320-43d9-89f1-e6dc95efeba8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f56cff7b-313c-4afd-87aa-f3d0646a3057"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33aefe95-38eb-4e86-a8db-a3d86b5d01af"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35bce8c0-ee20-45fd-99cb-6931a258a34d"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c677088-9a20-44de-b428-6ddf1563a62c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0308c3c9-4dbf-4b1b-89e6-0fdc9068a025"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""EnterDoor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdf41477-07b3-48e2-a5a4-a06a6966d415"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowHit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6c997f2-c954-4f3b-8979-0dbceeca545b"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Bag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b732232b-3a0e-467d-b30a-1b6bee60f016"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DoorToNextLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28f4a1c1-4825-47dd-83ce-867853036cbd"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseCardQ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4931bd85-72ea-44ae-9989-d2aa4ae0db23"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseCardE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard"",
            ""bindingGroup"": ""KeyBoard"",
            ""devices"": []
        }
    ]
}");
        // GamePlayer
        m_GamePlayer = asset.FindActionMap("GamePlayer", throwIfNotFound: true);
        m_GamePlayer_Move = m_GamePlayer.FindAction("Move", throwIfNotFound: true);
        m_GamePlayer_Jump = m_GamePlayer.FindAction("Jump", throwIfNotFound: true);
        m_GamePlayer_Attack = m_GamePlayer.FindAction("Attack", throwIfNotFound: true);
        m_GamePlayer_Esc = m_GamePlayer.FindAction("Esc", throwIfNotFound: true);
        m_GamePlayer_EnterDoor = m_GamePlayer.FindAction("EnterDoor", throwIfNotFound: true);
        m_GamePlayer_ArrowHit = m_GamePlayer.FindAction("ArrowHit", throwIfNotFound: true);
        m_GamePlayer_OpenBag = m_GamePlayer.FindAction("Open Bag", throwIfNotFound: true);
        m_GamePlayer_DoorToNextLevel = m_GamePlayer.FindAction("DoorToNextLevel", throwIfNotFound: true);
        m_GamePlayer_UseCardQ = m_GamePlayer.FindAction("UseCardQ", throwIfNotFound: true);
        m_GamePlayer_UseCardE = m_GamePlayer.FindAction("UseCardE", throwIfNotFound: true);
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

    // GamePlayer
    private readonly InputActionMap m_GamePlayer;
    private IGamePlayerActions m_GamePlayerActionsCallbackInterface;
    private readonly InputAction m_GamePlayer_Move;
    private readonly InputAction m_GamePlayer_Jump;
    private readonly InputAction m_GamePlayer_Attack;
    private readonly InputAction m_GamePlayer_Esc;
    private readonly InputAction m_GamePlayer_EnterDoor;
    private readonly InputAction m_GamePlayer_ArrowHit;
    private readonly InputAction m_GamePlayer_OpenBag;
    private readonly InputAction m_GamePlayer_DoorToNextLevel;
    private readonly InputAction m_GamePlayer_UseCardQ;
    private readonly InputAction m_GamePlayer_UseCardE;
    public struct GamePlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public GamePlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GamePlayer_Move;
        public InputAction @Jump => m_Wrapper.m_GamePlayer_Jump;
        public InputAction @Attack => m_Wrapper.m_GamePlayer_Attack;
        public InputAction @Esc => m_Wrapper.m_GamePlayer_Esc;
        public InputAction @EnterDoor => m_Wrapper.m_GamePlayer_EnterDoor;
        public InputAction @ArrowHit => m_Wrapper.m_GamePlayer_ArrowHit;
        public InputAction @OpenBag => m_Wrapper.m_GamePlayer_OpenBag;
        public InputAction @DoorToNextLevel => m_Wrapper.m_GamePlayer_DoorToNextLevel;
        public InputAction @UseCardQ => m_Wrapper.m_GamePlayer_UseCardQ;
        public InputAction @UseCardE => m_Wrapper.m_GamePlayer_UseCardE;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayerActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayerActions instance)
        {
            if (m_Wrapper.m_GamePlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnAttack;
                @Esc.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnEsc;
                @EnterDoor.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnEnterDoor;
                @EnterDoor.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnEnterDoor;
                @EnterDoor.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnEnterDoor;
                @ArrowHit.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnArrowHit;
                @ArrowHit.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnArrowHit;
                @ArrowHit.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnArrowHit;
                @OpenBag.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnOpenBag;
                @OpenBag.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnOpenBag;
                @OpenBag.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnOpenBag;
                @DoorToNextLevel.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnDoorToNextLevel;
                @DoorToNextLevel.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnDoorToNextLevel;
                @DoorToNextLevel.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnDoorToNextLevel;
                @UseCardQ.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnUseCardQ;
                @UseCardQ.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnUseCardQ;
                @UseCardQ.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnUseCardQ;
                @UseCardE.started -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnUseCardE;
                @UseCardE.performed -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnUseCardE;
                @UseCardE.canceled -= m_Wrapper.m_GamePlayerActionsCallbackInterface.OnUseCardE;
            }
            m_Wrapper.m_GamePlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
                @EnterDoor.started += instance.OnEnterDoor;
                @EnterDoor.performed += instance.OnEnterDoor;
                @EnterDoor.canceled += instance.OnEnterDoor;
                @ArrowHit.started += instance.OnArrowHit;
                @ArrowHit.performed += instance.OnArrowHit;
                @ArrowHit.canceled += instance.OnArrowHit;
                @OpenBag.started += instance.OnOpenBag;
                @OpenBag.performed += instance.OnOpenBag;
                @OpenBag.canceled += instance.OnOpenBag;
                @DoorToNextLevel.started += instance.OnDoorToNextLevel;
                @DoorToNextLevel.performed += instance.OnDoorToNextLevel;
                @DoorToNextLevel.canceled += instance.OnDoorToNextLevel;
                @UseCardQ.started += instance.OnUseCardQ;
                @UseCardQ.performed += instance.OnUseCardQ;
                @UseCardQ.canceled += instance.OnUseCardQ;
                @UseCardE.started += instance.OnUseCardE;
                @UseCardE.performed += instance.OnUseCardE;
                @UseCardE.canceled += instance.OnUseCardE;
            }
        }
    }
    public GamePlayerActions @GamePlayer => new GamePlayerActions(this);
    private int m_KeyBoardSchemeIndex = -1;
    public InputControlScheme KeyBoardScheme
    {
        get
        {
            if (m_KeyBoardSchemeIndex == -1) m_KeyBoardSchemeIndex = asset.FindControlSchemeIndex("KeyBoard");
            return asset.controlSchemes[m_KeyBoardSchemeIndex];
        }
    }
    public interface IGamePlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
        void OnEnterDoor(InputAction.CallbackContext context);
        void OnArrowHit(InputAction.CallbackContext context);
        void OnOpenBag(InputAction.CallbackContext context);
        void OnDoorToNextLevel(InputAction.CallbackContext context);
        void OnUseCardQ(InputAction.CallbackContext context);
        void OnUseCardE(InputAction.CallbackContext context);
    }
}
