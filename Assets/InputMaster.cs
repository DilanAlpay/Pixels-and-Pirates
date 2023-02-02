// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""1f2d2665-dafe-415b-b207-fff7b8a6928a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f0639685-8eac-4716-8ac7-47e09c0e3f40"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Value"",
                    ""id"": ""c0d1d884-a77e-436c-9bfc-87b762c8d6af"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""e80a4036-e9c3-4bc8-8199-735f407d993c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""e41f87c3-4f52-4fc2-bc94-b09642cde1d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dig"",
                    ""type"": ""Button"",
                    ""id"": ""16ede10e-f6b6-4b94-a385-10e246af0a27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""23cb8280-244c-4c37-97c3-c13d8bfc8932"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item"",
                    ""type"": ""Button"",
                    ""id"": ""4f8d2127-e1c4-4510-ae7a-243a8369b117"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""16a45727-95f3-47a6-91c3-af4e13f956cd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9214901d-f4d7-4011-acf8-d19fbd898a41"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9e7c735a-b90c-43bb-a29a-fe4849573b61"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f04e06d-da57-43b0-aa13-4e675ff11e26"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6561db28-5255-49d8-a771-a7500ef25146"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Buttons"",
                    ""id"": ""87d85c7c-757e-413a-9c8c-2eb1f29ad7b4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""55e9231f-5f3a-4bbb-ab31-5c83f86d53b6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c55c576e-714d-414a-a235-388f7b452d5b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f9406167-ad64-43be-962d-38900ad28fd7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""737e6397-b198-4179-a026-431e5d8b4a6a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b07078e5-2419-46ad-82e0-c441901b27f0"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""48f33403-b5ef-40f7-88f6-9b449726390a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""72e85d17-334f-485c-8b96-2df132da0258"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f51f8573-0f03-47a6-bfc6-e3337541c4ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ca6bace2-4044-4af6-9416-ffddf93a6de2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61f5f20d-eec0-4efd-b860-d459da1eee9e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""478b4d5e-2e97-4a43-bdb5-b900411ecde1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bb638470-8a50-4569-8cf3-74d68888de1e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f4e54cdb-7d42-43fb-b22a-fd7a746fafd3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""334338c2-7eec-471e-bbfc-ec63ae124038"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""437c6ada-6c32-4068-9d32-de139a2e2832"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fe6e8385-4fed-4c23-babb-a084dfcdc2d3"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ed355b4-213d-4d5f-80c5-838749bf0ef7"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50f4c88a-8350-4993-a275-4d401e8b2e8f"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e77f158-8bc1-422d-b89c-8846a4b9228c"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f5ce352-1431-498c-a04a-8cd54560c7f7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0ec61bc-29cd-4acf-a4ae-95bda1cefac9"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53c3c00f-293f-4a90-94d3-3792cb1bee06"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Dig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""966b02e8-523e-42f5-9df2-9ca838de81b0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Dig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4545d59-564d-4433-a45a-8fcc69ae47b9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e5e2867-823f-4cbc-af01-e95aa3dde8bb"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cc2ac93-2792-48d0-9022-508a71007f3e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80ceb587-e523-40f1-ad59-a9c30fc17526"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f97be661-8543-4f7e-bd30-c41d484b9e5c"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c9a4b76-8c94-4cda-9640-63de63818c03"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Map"",
            ""id"": ""671731ad-8171-4f68-85ea-dde83926da07"",
            ""actions"": [
                {
                    ""name"": ""CloseMap"",
                    ""type"": ""Button"",
                    ""id"": ""b6989a7b-e3e1-47c7-a286-e5b8b7ddfdb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e6a3c9b6-9514-42e3-80b4-cd4ba1f44c40"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CloseMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9265ab61-bb8d-451b-92b7-7d9b152b6ae5"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CloseMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""ac1efc84-a3f5-4908-84a6-9073fbb8faa8"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""826aa21b-f82b-471e-968e-f24d5a5ec70c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7826cc6c-4778-4673-b1e5-deb88061b9b2"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller;Joystick"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acc5d73e-2af0-4733-a802-b38c32f372ba"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
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
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
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
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::Logitech Logitech Extreme 3D>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_Attack = m_Character.FindAction("Attack", throwIfNotFound: true);
        m_Character_Switch = m_Character.FindAction("Switch", throwIfNotFound: true);
        m_Character_Map = m_Character.FindAction("Map", throwIfNotFound: true);
        m_Character_Dig = m_Character.FindAction("Dig", throwIfNotFound: true);
        m_Character_Pause = m_Character.FindAction("Pause", throwIfNotFound: true);
        m_Character_Item = m_Character.FindAction("Item", throwIfNotFound: true);
        // Map
        m_Map = asset.FindActionMap("Map", throwIfNotFound: true);
        m_Map_CloseMap = m_Map.FindAction("CloseMap", throwIfNotFound: true);
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_Pause = m_Pause.FindAction("Pause", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_Attack;
    private readonly InputAction m_Character_Switch;
    private readonly InputAction m_Character_Map;
    private readonly InputAction m_Character_Dig;
    private readonly InputAction m_Character_Pause;
    private readonly InputAction m_Character_Item;
    public struct CharacterActions
    {
        private @InputMaster m_Wrapper;
        public CharacterActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @Attack => m_Wrapper.m_Character_Attack;
        public InputAction @Switch => m_Wrapper.m_Character_Switch;
        public InputAction @Map => m_Wrapper.m_Character_Map;
        public InputAction @Dig => m_Wrapper.m_Character_Dig;
        public InputAction @Pause => m_Wrapper.m_Character_Pause;
        public InputAction @Item => m_Wrapper.m_Character_Item;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnAttack;
                @Switch.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSwitch;
                @Switch.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSwitch;
                @Switch.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSwitch;
                @Map.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMap;
                @Dig.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnDig;
                @Dig.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnDig;
                @Dig.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnDig;
                @Pause.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnPause;
                @Item.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnItem;
                @Item.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnItem;
                @Item.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnItem;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Switch.started += instance.OnSwitch;
                @Switch.performed += instance.OnSwitch;
                @Switch.canceled += instance.OnSwitch;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @Dig.started += instance.OnDig;
                @Dig.performed += instance.OnDig;
                @Dig.canceled += instance.OnDig;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Item.started += instance.OnItem;
                @Item.performed += instance.OnItem;
                @Item.canceled += instance.OnItem;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Map
    private readonly InputActionMap m_Map;
    private IMapActions m_MapActionsCallbackInterface;
    private readonly InputAction m_Map_CloseMap;
    public struct MapActions
    {
        private @InputMaster m_Wrapper;
        public MapActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseMap => m_Wrapper.m_Map_CloseMap;
        public InputActionMap Get() { return m_Wrapper.m_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapActions set) { return set.Get(); }
        public void SetCallbacks(IMapActions instance)
        {
            if (m_Wrapper.m_MapActionsCallbackInterface != null)
            {
                @CloseMap.started -= m_Wrapper.m_MapActionsCallbackInterface.OnCloseMap;
                @CloseMap.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnCloseMap;
                @CloseMap.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnCloseMap;
            }
            m_Wrapper.m_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CloseMap.started += instance.OnCloseMap;
                @CloseMap.performed += instance.OnCloseMap;
                @CloseMap.canceled += instance.OnCloseMap;
            }
        }
    }
    public MapActions @Map => new MapActions(this);

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_Pause;
    public struct PauseActions
    {
        private @InputMaster m_Wrapper;
        public PauseActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Pause_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);
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
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSwitch(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnDig(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
    }
    public interface IMapActions
    {
        void OnCloseMap(InputAction.CallbackContext context);
    }
    public interface IPauseActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
