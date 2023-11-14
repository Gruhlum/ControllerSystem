using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace HexTecGames.ControllerSystem
{
	public class ControllerSelection : MonoBehaviour
	{
		[SerializeField] private TMP_Dropdown dropdown = default;

        [SerializeField] private List<ControllerSpriteMap> spriteMaps = default;

        private void Reset()
        {
            dropdown = GetComponentInChildren<TMP_Dropdown>();
        }

        private void Awake()
        {
            dropdown.ClearOptions();
            foreach (var map in spriteMaps)
            {
                TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData(map.name);
                dropdown.options.Add(data);
            }            
        }

        public void DropdownValueChanged(int index)
        {
            ControllerSpriteManager.SelectedSpriteMap = spriteMaps[index];
        }
    }
}