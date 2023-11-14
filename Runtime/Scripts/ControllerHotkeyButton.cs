using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace HexTecGames.ControllerSystem
{
    public class ControllerHotkeyButton : ControllerInputImage
    {
        [SerializeField] private Button btn = default;

        protected override void Reset()
        {
            btn = GetComponent<Button>();
            base.Reset();
        }

        private void Awake()
        {
            inputAction.performed += InputAction_performed;            
        }

        private void OnDestroy()
        {
            inputAction.performed -= InputAction_performed;
        }

        private void InputAction_performed(InputAction.CallbackContext context)
        {
            btn.onClick?.Invoke();
        }
    }
}