using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HexTecGames.ControllerSystem
{
	[CreateAssetMenu(menuName = "HexTecGames/ControllerKeys")]
	public class ControllerSpriteMap : ScriptableObject
	{
		public List<SpriteBinding> spriteBindings = new List<SpriteBinding>();

        private void Reset()
        {
			spriteBindings.Add(new SpriteBinding("buttonNorth"));
			spriteBindings.Add(new SpriteBinding("buttonWest"));
			spriteBindings.Add(new SpriteBinding("buttonSouth"));
			spriteBindings.Add(new SpriteBinding("buttonEast"));

			spriteBindings.Add(new SpriteBinding("dpad/up"));
			spriteBindings.Add(new SpriteBinding("dpad/left"));
			spriteBindings.Add(new SpriteBinding("dpad/down"));
			spriteBindings.Add(new SpriteBinding("dpad/right"));

			spriteBindings.Add(new SpriteBinding("leftStick"));
			spriteBindings.Add(new SpriteBinding("rightStick"));

			spriteBindings.Add(new SpriteBinding("leftStickPress"));
			spriteBindings.Add(new SpriteBinding("rightStickPress"));

			spriteBindings.Add(new SpriteBinding("leftTrigger"));
			spriteBindings.Add(new SpriteBinding("rightTrigger"));

			spriteBindings.Add(new SpriteBinding("leftShoulder"));
			spriteBindings.Add(new SpriteBinding("rightShoulder"));

			spriteBindings.Add(new SpriteBinding("select"));
			spriteBindings.Add(new SpriteBinding("start"));
		}

		public Sprite GetSprite(InputBinding inputBinding)
		{
			if (inputBinding.path == null)
			{
				return null;
			}
			int startIndex = "<gamepad>/".Length;
			int length = inputBinding.path.Length - startIndex;
            string subString = inputBinding.path.Substring(startIndex, length);
			return GetSprite(subString);
		}
		public Sprite GetSprite(string bindingPath)
		{
			//Debug.Log(bindingPath);
			return spriteBindings.Find(x => x.inputBinding == bindingPath).sprite;
		}
	}
}