using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace HexTecGames.ControllerSystem
{
	public class ControllerInputImage : MonoBehaviour
	{
		[SerializeField] private Image image = default;
        [SerializeField] protected InputAction inputAction = default;


		protected virtual void Reset()
		{
			//image = GetComponent<Image>();
		}

        public void SetSprite(Sprite sprite)
		{
			image.sprite = sprite;
		}
		public InputBinding? GetBinding()
		{
			if (inputAction == null || inputAction.bindings.Count == 0)
			{
				return null;
			}
            return inputAction.bindings[0];
		}
	}
}