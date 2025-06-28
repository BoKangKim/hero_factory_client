using System;
using System.Collections;
using System.Collections.Generic;
using Game.Util;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.UI
{
    [Serializable]
    public class ButtonContentPair : Pair<Button, GameObject>
    {
        private int index = 0;

        public void Enable()
        {
            ColorBlock colorBlock = value1.colors;
            colorBlock.normalColor = Color.white;
            value1.colors = colorBlock;

            value2.gameObject.SetActive(true);
        }

        public void Disable()
        {
            ColorBlock colorBlock = value1.colors;
            colorBlock.normalColor = Color.gray;
            value1.colors = colorBlock;

            value2.gameObject.SetActive(false);
        }

        public void Init(int index, Action<int> action)
        {
            this.index = index;

            value1.onClick.RemoveAllListeners();
            value1.onClick.AddListener(() => action?.Invoke(this.index));
        }
    }

    public class BottomPanel : MonoBehaviour
    {
        [SerializeField] private List<ButtonContentPair> contentList;

        private ButtonContentPair curContent = null;

        private void Awake()
        {
            for (int i = 0; i < contentList.Count; i++)
            {
                contentList[i].Init(i, OnClick);
            }
            OnClick(0);
        }

        private void OnClick(int index)
        {
            for (int i = 0; i < contentList.Count; i++)
            {
                if (i == index)
                {
                    contentList[i].Enable();
                }
                else
                { 
                    contentList[i].Disable();
                }
            }
        }
    }
}