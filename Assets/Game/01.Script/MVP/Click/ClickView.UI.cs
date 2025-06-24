using System.Collections;
using System.Collections.Generic;
using Game.Util;
using TMPro;
using UnityEngine;

namespace Game.MVP
{
    public partial class ClickView : MonoBehaviour, IView
    {
        [SerializeField] private TextMeshProUGUI clickCountText;

        public void UpdateView(IModelData data)
        {
            if (!(data is ClickModelData))
            {
                return;
            }

            clickCountText.text = (data as ClickModelData).ClickCount.ToString();
        }
    }
}