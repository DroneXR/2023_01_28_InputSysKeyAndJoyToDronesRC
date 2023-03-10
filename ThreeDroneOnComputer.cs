//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/2023_01_28_InputSysKeyAndJoyToDronesRC/ThreeDroneOnComputer.inputactions
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

namespace ThreeDroneOnComputerSpace
{
    public partial class @ThreeDroneOnComputer : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @ThreeDroneOnComputer()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""ThreeDroneOnComputer"",
    ""maps"": [
        {
            ""name"": ""DroneMainXboxController"",
            ""id"": ""915cc0d5-142b-480b-b61f-e4e3633ff3bd"",
            ""actions"": [
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""9681e789-821f-4d15-940d-123a89e3ad7b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BackForward"",
                    ""type"": ""Value"",
                    ""id"": ""2b89ad1d-77b8-43a2-935c-67a458f5172a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DownUp"",
                    ""type"": ""Value"",
                    ""id"": ""6e041d7a-c62f-474f-b8e8-d3e2046ae36e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateLeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""764fe8e1-0390-487a-9868-5eb33a88283f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""793bb095-81cc-4ac0-ad6d-d8154b4e83d1"",
                    ""path"": ""<XInputController>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21e79f9b-d548-43b4-82d0-6e5cad47a448"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b36a3f4e-3b6a-4417-9c5f-518ce64979fb"",
                    ""path"": ""<XInputController>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74e4ba0c-6a9e-4a7c-abd1-56f7203af318"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8977130d-227c-4bf6-9766-504ca9e5f391"",
                    ""path"": ""<XInputController>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""982776f9-d7ce-4861-87eb-aa0c76943eeb"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b615f4eb-14e1-4f1f-8bce-68e8dbd17e2c"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a62b030b-f05a-47f0-baac-7a5f7026dbe7"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DroneQuerty"",
            ""id"": ""084ea3fe-104a-4ca6-bfa0-cfb20b812131"",
            ""actions"": [
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""fe28f73f-ed05-4c84-acc3-2c3e8c44a2c7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BackForward"",
                    ""type"": ""Value"",
                    ""id"": ""0c04b978-f262-43ad-81a1-d932d134747f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DownUp"",
                    ""type"": ""Value"",
                    ""id"": ""45f62ee1-ccf3-478d-8f3c-464be12d9002"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateLeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""5520bfed-f8d3-425c-9444-c5e7c59dd21f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""882e931f-fa65-48fb-9e28-90457e91478c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e060f06f-bed9-4816-9b27-48cee573ab1c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""33fc7bb0-d640-4bef-87bf-2849bb5c63f4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9297d571-07c4-407f-b13e-24e5b8bbbc41"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""999e360d-984f-4b3c-bf13-44330b84a806"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""406a5f35-ed5c-443d-ad54-e2a12eaea3f7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f6196b5f-07fb-4e8e-9235-c0ba23d302f8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8a253c30-5291-4a43-8867-cefd28d5f4bb"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""465303b6-2715-4d7a-89fe-854e5ff019f6"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1ae1b78a-eb81-4a3e-b6f7-67bfb1307019"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""806c10ab-8763-46f7-b4c0-596dee33f8d4"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7cfb21c4-edb9-4a4a-9b45-eb61439c587d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""DroneNumPad"",
            ""id"": ""f736054a-d84d-4385-bcdd-2fd100fd2231"",
            ""actions"": [
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""9456f1de-daaf-49d5-9f6e-ad3b37aa14f6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BackForward"",
                    ""type"": ""Value"",
                    ""id"": ""c0a7363a-8c03-41d5-8346-fc1f142a5df9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DownUp"",
                    ""type"": ""Value"",
                    ""id"": ""ddb10a6c-6b50-4dad-92d5-920d89196d44"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateLeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""b18f6a26-e629-4f61-8a7b-a701dde14a53"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c0b8fa71-4e27-4e2b-8102-cabe11961da5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8b9fbbf2-4e58-4cb2-8ade-da96a711f68f"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6ea931b6-8b85-447a-a5dc-083a288553c2"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cf32af0e-9536-491f-a062-9f905ad66dec"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""53580ec7-5669-440e-bc12-c9d1f58045aa"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b447dfb6-c577-498c-8e0e-e1521f4f7761"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fb755be6-eb32-4412-822a-289b0633faff"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5d3349d6-c962-4a43-b24c-636c12ed4a28"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9f958c1a-809c-442d-a246-cf1962407424"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cbe7f299-a862-45e1-a338-891576b2627e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e9a7b2b8-5ef5-442f-8d02-0a6eca504c13"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""89b09d52-7ddf-420b-a433-ec8747cc664a"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // DroneMainXboxController
            m_DroneMainXboxController = asset.FindActionMap("DroneMainXboxController", throwIfNotFound: true);
            m_DroneMainXboxController_LeftRight = m_DroneMainXboxController.FindAction("LeftRight", throwIfNotFound: true);
            m_DroneMainXboxController_BackForward = m_DroneMainXboxController.FindAction("BackForward", throwIfNotFound: true);
            m_DroneMainXboxController_DownUp = m_DroneMainXboxController.FindAction("DownUp", throwIfNotFound: true);
            m_DroneMainXboxController_RotateLeftRight = m_DroneMainXboxController.FindAction("RotateLeftRight", throwIfNotFound: true);
            // DroneQuerty
            m_DroneQuerty = asset.FindActionMap("DroneQuerty", throwIfNotFound: true);
            m_DroneQuerty_LeftRight = m_DroneQuerty.FindAction("LeftRight", throwIfNotFound: true);
            m_DroneQuerty_BackForward = m_DroneQuerty.FindAction("BackForward", throwIfNotFound: true);
            m_DroneQuerty_DownUp = m_DroneQuerty.FindAction("DownUp", throwIfNotFound: true);
            m_DroneQuerty_RotateLeftRight = m_DroneQuerty.FindAction("RotateLeftRight", throwIfNotFound: true);
            // DroneNumPad
            m_DroneNumPad = asset.FindActionMap("DroneNumPad", throwIfNotFound: true);
            m_DroneNumPad_LeftRight = m_DroneNumPad.FindAction("LeftRight", throwIfNotFound: true);
            m_DroneNumPad_BackForward = m_DroneNumPad.FindAction("BackForward", throwIfNotFound: true);
            m_DroneNumPad_DownUp = m_DroneNumPad.FindAction("DownUp", throwIfNotFound: true);
            m_DroneNumPad_RotateLeftRight = m_DroneNumPad.FindAction("RotateLeftRight", throwIfNotFound: true);
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

        // DroneMainXboxController
        private readonly InputActionMap m_DroneMainXboxController;
        private IDroneMainXboxControllerActions m_DroneMainXboxControllerActionsCallbackInterface;
        private readonly InputAction m_DroneMainXboxController_LeftRight;
        private readonly InputAction m_DroneMainXboxController_BackForward;
        private readonly InputAction m_DroneMainXboxController_DownUp;
        private readonly InputAction m_DroneMainXboxController_RotateLeftRight;
        public struct DroneMainXboxControllerActions
        {
            private @ThreeDroneOnComputer m_Wrapper;
            public DroneMainXboxControllerActions(@ThreeDroneOnComputer wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftRight => m_Wrapper.m_DroneMainXboxController_LeftRight;
            public InputAction @BackForward => m_Wrapper.m_DroneMainXboxController_BackForward;
            public InputAction @DownUp => m_Wrapper.m_DroneMainXboxController_DownUp;
            public InputAction @RotateLeftRight => m_Wrapper.m_DroneMainXboxController_RotateLeftRight;
            public InputActionMap Get() { return m_Wrapper.m_DroneMainXboxController; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DroneMainXboxControllerActions set) { return set.Get(); }
            public void SetCallbacks(IDroneMainXboxControllerActions instance)
            {
                if (m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface != null)
                {
                    @LeftRight.started -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnLeftRight;
                    @BackForward.started -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnBackForward;
                    @BackForward.performed -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnBackForward;
                    @BackForward.canceled -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnBackForward;
                    @DownUp.started -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnDownUp;
                    @DownUp.performed -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnDownUp;
                    @DownUp.canceled -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnDownUp;
                    @RotateLeftRight.started -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnRotateLeftRight;
                    @RotateLeftRight.performed -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnRotateLeftRight;
                    @RotateLeftRight.canceled -= m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface.OnRotateLeftRight;
                }
                m_Wrapper.m_DroneMainXboxControllerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                    @BackForward.started += instance.OnBackForward;
                    @BackForward.performed += instance.OnBackForward;
                    @BackForward.canceled += instance.OnBackForward;
                    @DownUp.started += instance.OnDownUp;
                    @DownUp.performed += instance.OnDownUp;
                    @DownUp.canceled += instance.OnDownUp;
                    @RotateLeftRight.started += instance.OnRotateLeftRight;
                    @RotateLeftRight.performed += instance.OnRotateLeftRight;
                    @RotateLeftRight.canceled += instance.OnRotateLeftRight;
                }
            }
        }
        public DroneMainXboxControllerActions @DroneMainXboxController => new DroneMainXboxControllerActions(this);

        // DroneQuerty
        private readonly InputActionMap m_DroneQuerty;
        private IDroneQuertyActions m_DroneQuertyActionsCallbackInterface;
        private readonly InputAction m_DroneQuerty_LeftRight;
        private readonly InputAction m_DroneQuerty_BackForward;
        private readonly InputAction m_DroneQuerty_DownUp;
        private readonly InputAction m_DroneQuerty_RotateLeftRight;
        public struct DroneQuertyActions
        {
            private @ThreeDroneOnComputer m_Wrapper;
            public DroneQuertyActions(@ThreeDroneOnComputer wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftRight => m_Wrapper.m_DroneQuerty_LeftRight;
            public InputAction @BackForward => m_Wrapper.m_DroneQuerty_BackForward;
            public InputAction @DownUp => m_Wrapper.m_DroneQuerty_DownUp;
            public InputAction @RotateLeftRight => m_Wrapper.m_DroneQuerty_RotateLeftRight;
            public InputActionMap Get() { return m_Wrapper.m_DroneQuerty; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DroneQuertyActions set) { return set.Get(); }
            public void SetCallbacks(IDroneQuertyActions instance)
            {
                if (m_Wrapper.m_DroneQuertyActionsCallbackInterface != null)
                {
                    @LeftRight.started -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnLeftRight;
                    @BackForward.started -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnBackForward;
                    @BackForward.performed -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnBackForward;
                    @BackForward.canceled -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnBackForward;
                    @DownUp.started -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnDownUp;
                    @DownUp.performed -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnDownUp;
                    @DownUp.canceled -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnDownUp;
                    @RotateLeftRight.started -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnRotateLeftRight;
                    @RotateLeftRight.performed -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnRotateLeftRight;
                    @RotateLeftRight.canceled -= m_Wrapper.m_DroneQuertyActionsCallbackInterface.OnRotateLeftRight;
                }
                m_Wrapper.m_DroneQuertyActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                    @BackForward.started += instance.OnBackForward;
                    @BackForward.performed += instance.OnBackForward;
                    @BackForward.canceled += instance.OnBackForward;
                    @DownUp.started += instance.OnDownUp;
                    @DownUp.performed += instance.OnDownUp;
                    @DownUp.canceled += instance.OnDownUp;
                    @RotateLeftRight.started += instance.OnRotateLeftRight;
                    @RotateLeftRight.performed += instance.OnRotateLeftRight;
                    @RotateLeftRight.canceled += instance.OnRotateLeftRight;
                }
            }
        }
        public DroneQuertyActions @DroneQuerty => new DroneQuertyActions(this);

        // DroneNumPad
        private readonly InputActionMap m_DroneNumPad;
        private IDroneNumPadActions m_DroneNumPadActionsCallbackInterface;
        private readonly InputAction m_DroneNumPad_LeftRight;
        private readonly InputAction m_DroneNumPad_BackForward;
        private readonly InputAction m_DroneNumPad_DownUp;
        private readonly InputAction m_DroneNumPad_RotateLeftRight;
        public struct DroneNumPadActions
        {
            private @ThreeDroneOnComputer m_Wrapper;
            public DroneNumPadActions(@ThreeDroneOnComputer wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftRight => m_Wrapper.m_DroneNumPad_LeftRight;
            public InputAction @BackForward => m_Wrapper.m_DroneNumPad_BackForward;
            public InputAction @DownUp => m_Wrapper.m_DroneNumPad_DownUp;
            public InputAction @RotateLeftRight => m_Wrapper.m_DroneNumPad_RotateLeftRight;
            public InputActionMap Get() { return m_Wrapper.m_DroneNumPad; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DroneNumPadActions set) { return set.Get(); }
            public void SetCallbacks(IDroneNumPadActions instance)
            {
                if (m_Wrapper.m_DroneNumPadActionsCallbackInterface != null)
                {
                    @LeftRight.started -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnLeftRight;
                    @BackForward.started -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnBackForward;
                    @BackForward.performed -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnBackForward;
                    @BackForward.canceled -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnBackForward;
                    @DownUp.started -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnDownUp;
                    @DownUp.performed -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnDownUp;
                    @DownUp.canceled -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnDownUp;
                    @RotateLeftRight.started -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnRotateLeftRight;
                    @RotateLeftRight.performed -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnRotateLeftRight;
                    @RotateLeftRight.canceled -= m_Wrapper.m_DroneNumPadActionsCallbackInterface.OnRotateLeftRight;
                }
                m_Wrapper.m_DroneNumPadActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                    @BackForward.started += instance.OnBackForward;
                    @BackForward.performed += instance.OnBackForward;
                    @BackForward.canceled += instance.OnBackForward;
                    @DownUp.started += instance.OnDownUp;
                    @DownUp.performed += instance.OnDownUp;
                    @DownUp.canceled += instance.OnDownUp;
                    @RotateLeftRight.started += instance.OnRotateLeftRight;
                    @RotateLeftRight.performed += instance.OnRotateLeftRight;
                    @RotateLeftRight.canceled += instance.OnRotateLeftRight;
                }
            }
        }
        public DroneNumPadActions @DroneNumPad => new DroneNumPadActions(this);
        public interface IDroneMainXboxControllerActions
        {
            void OnLeftRight(InputAction.CallbackContext context);
            void OnBackForward(InputAction.CallbackContext context);
            void OnDownUp(InputAction.CallbackContext context);
            void OnRotateLeftRight(InputAction.CallbackContext context);
        }
        public interface IDroneQuertyActions
        {
            void OnLeftRight(InputAction.CallbackContext context);
            void OnBackForward(InputAction.CallbackContext context);
            void OnDownUp(InputAction.CallbackContext context);
            void OnRotateLeftRight(InputAction.CallbackContext context);
        }
        public interface IDroneNumPadActions
        {
            void OnLeftRight(InputAction.CallbackContext context);
            void OnBackForward(InputAction.CallbackContext context);
            void OnDownUp(InputAction.CallbackContext context);
            void OnRotateLeftRight(InputAction.CallbackContext context);
        }
    }
}
