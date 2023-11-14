using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HexTecGames.ControllerSystem
{
	[System.Serializable]
	public struct SpriteBinding
	{
		public string inputBinding;
		public Sprite sprite;

        public SpriteBinding(string inputBinding) : this()
        {
            this.inputBinding = inputBinding;
        }
    }
}