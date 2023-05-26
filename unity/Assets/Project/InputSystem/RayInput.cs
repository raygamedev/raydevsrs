//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Project/InputSystem/RayInput.inputactions
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

public partial class @RayInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RayInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RayInput"",
    ""maps"": [
        {
            ""name"": ""RayControls"",
            ""id"": ""3ed936d0-3c73-45ef-92fe-227f43200ecf"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""1eee9447-8892-4536-aba7-5e52a6df0829"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9212ce83-bdc1-45c0-92eb-33c22b49ea7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interactable"",
                    ""type"": ""Button"",
                    ""id"": ""63d3680c-617d-48e9-8b15-e50550435c30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightAttack"",
                    ""type"": ""Button"",
                    ""id"": ""2f0a2bfa-ff53-4f02-b030-967d5d439ee5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HeavyAttack"",
                    ""type"": ""Button"",
                    ""id"": ""eb6ec1e5-9c53-4297-a03f-c602574e6a5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ba1512b0-e883-4705-a5a2-2cde24297e2a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b4bf9ed9-27b0-4f48-8359-61d64fa7983e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8a96565-e4b2-4b44-8e46-073d9607baa9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ab370934-9154-411d-89dd-315c54955d3e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fcffe3f4-1cbe-4dbb-adf4-2becda4aa73b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ab4f48b2-56e1-4289-9237-2c625fa7dc0c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7792bed8-c588-43e3-9b49-4ba4d8b5f58d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f8bc71a-1259-4c94-89a0-a46fd15f9c61"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d672e62-9dcd-4894-9936-d5407026b135"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interactable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b08dbb5b-f11e-431b-9a8b-a05f009b6d42"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f55a501-01d9-4741-8ab1-8702ffa27e36"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RayControls
        m_RayControls = asset.FindActionMap("RayControls", throwIfNotFound: true);
        m_RayControls_Movement = m_RayControls.FindAction("Movement", throwIfNotFound: true);
        m_RayControls_Jump = m_RayControls.FindAction("Jump", throwIfNotFound: true);
        m_RayControls_Interactable = m_RayControls.FindAction("Interactable", throwIfNotFound: true);
        m_RayControls_LightAttack = m_RayControls.FindAction("LightAttack", throwIfNotFound: true);
        m_RayControls_HeavyAttack = m_RayControls.FindAction("HeavyAttack", throwIfNotFound: true);
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

    // RayControls
    private readonly InputActionMap m_RayControls;
    private IRayControlsActions m_RayControlsActionsCallbackInterface;
    private readonly InputAction m_RayControls_Movement;
    private readonly InputAction m_RayControls_Jump;
    private readonly InputAction m_RayControls_Interactable;
    private readonly InputAction m_RayControls_LightAttack;
    private readonly InputAction m_RayControls_HeavyAttack;
    public struct RayControlsActions
    {
        private @RayInput m_Wrapper;
        public RayControlsActions(@RayInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_RayControls_Movement;
        public InputAction @Jump => m_Wrapper.m_RayControls_Jump;
        public InputAction @Interactable => m_Wrapper.m_RayControls_Interactable;
        public InputAction @LightAttack => m_Wrapper.m_RayControls_LightAttack;
        public InputAction @HeavyAttack => m_Wrapper.m_RayControls_HeavyAttack;
        public InputActionMap Get() { return m_Wrapper.m_RayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IRayControlsActions instance)
        {
            if (m_Wrapper.m_RayControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnJump;
                @Interactable.started -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnInteractable;
                @Interactable.performed -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnInteractable;
                @Interactable.canceled -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnInteractable;
                @LightAttack.started -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnLightAttack;
                @LightAttack.performed -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnLightAttack;
                @LightAttack.canceled -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnLightAttack;
                @HeavyAttack.started -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.performed -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.canceled -= m_Wrapper.m_RayControlsActionsCallbackInterface.OnHeavyAttack;
            }
            m_Wrapper.m_RayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interactable.started += instance.OnInteractable;
                @Interactable.performed += instance.OnInteractable;
                @Interactable.canceled += instance.OnInteractable;
                @LightAttack.started += instance.OnLightAttack;
                @LightAttack.performed += instance.OnLightAttack;
                @LightAttack.canceled += instance.OnLightAttack;
                @HeavyAttack.started += instance.OnHeavyAttack;
                @HeavyAttack.performed += instance.OnHeavyAttack;
                @HeavyAttack.canceled += instance.OnHeavyAttack;
            }
        }
    }
    public RayControlsActions @RayControls => new RayControlsActions(this);
    public interface IRayControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteractable(InputAction.CallbackContext context);
        void OnLightAttack(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
    }
}
