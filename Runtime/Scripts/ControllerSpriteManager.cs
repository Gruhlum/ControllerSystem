using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HexTecGames.ControllerSystem
{
    public class ControllerSpriteManager : MonoBehaviour
    {
        [SerializeField] private List<ControllerInputImage> inputImages = default;

        [SerializeField] private PlayerInput playerInput = default;

        public static ControllerSpriteMap SelectedSpriteMap
        {
            get
            {
                return selectedSpriteMap;
            }
            set
            {
                selectedSpriteMap = value;
                OnSpriteMapChanged?.Invoke();
            }
        }
        private static ControllerSpriteMap selectedSpriteMap;

        private static Action OnSpriteMapChanged;

        private void Reset()
        {
            FindAllObjects();
        }

        private void Awake()
        {
            OnSpriteMapChanged += UpdateSprites;
        }
        private void OnDestroy()
        {
            OnSpriteMapChanged -= UpdateSprites;
        }

        private void Start()
        {
            UpdateSprites();
        }

        private void UpdateSprites()
        {
            if (SelectedSpriteMap == null)
            {
                return;
            }
            foreach (var inputImage in inputImages)
            {
                InputBinding? binding = inputImage.GetBinding();
                if (binding.HasValue)
                {
                    inputImage.SetSprite(SelectedSpriteMap.GetSprite(binding.Value));
                }
            }
        }

        [ContextMenu("Find Objects")]
        public void FindAllObjects()
        {
            inputImages = FindObjectsOfType<ControllerInputImage>().ToList();
        }
    }
}