//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""06f80ca4-5898-49d6-b6fc-c94230d2d580"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""11a4925f-58ce-4fa6-aa77-d82cd41898d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""7d0c395d-895d-4e9d-a431-a136b05fdba3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6ce5168b-0bfa-453b-9711-c844665f4a2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShortJump"",
                    ""type"": ""Button"",
                    ""id"": ""4a8d9d7b-a43b-426c-a19c-775987433ad0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=0.1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""ac290d8a-a235-4f81-935f-e51ccbf3fd70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""1453257b-d4ef-4cd8-9c40-65646d6fa960"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4660ad2e-f621-4d4c-840f-84ce434bfea1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0fd1a302-2b6e-4295-a6b8-7a9f128141ac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9a67c3e-c272-486d-8a2c-c3fdb05b6c76"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efc68d20-cf35-43fc-89d7-a84bf74bf280"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShortJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""e2a28eff-107c-4e54-b8e8-440dfdb71e73"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""37cdb013-d9fb-4801-98ef-a6c19bbc672a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9bf97959-a0bb-4a85-bafd-7bba980dbbda"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""55da927a-a667-499f-a7a7-5ad7f7f90ea8"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Move = m_Move.FindAction("Move", throwIfNotFound: true);
        m_Move_Look = m_Move.FindAction("Look", throwIfNotFound: true);
        m_Move_Jump = m_Move.FindAction("Jump", throwIfNotFound: true);
        m_Move_ShortJump = m_Move.FindAction("ShortJump", throwIfNotFound: true);
        m_Move_Dash = m_Move.FindAction("Dash", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Move;
    private readonly InputAction m_Move_Look;
    private readonly InputAction m_Move_Jump;
    private readonly InputAction m_Move_ShortJump;
    private readonly InputAction m_Move_Dash;
    public struct MoveActions
    {
        private @PlayerControls m_Wrapper;
        public MoveActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Move_Move;
        public InputAction @Look => m_Wrapper.m_Move_Look;
        public InputAction @Jump => m_Wrapper.m_Move_Jump;
        public InputAction @ShortJump => m_Wrapper.m_Move_ShortJump;
        public InputAction @Dash => m_Wrapper.m_Move_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @ShortJump.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnShortJump;
                @ShortJump.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnShortJump;
                @ShortJump.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnShortJump;
                @Dash.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ShortJump.started += instance.OnShortJump;
                @ShortJump.performed += instance.OnShortJump;
                @ShortJump.canceled += instance.OnShortJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShortJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
}
