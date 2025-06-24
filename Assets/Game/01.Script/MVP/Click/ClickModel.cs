using System;
using System.Collections;
using System.Collections.Generic;
using Game.Util;
using UnityEngine;

namespace Game.MVP
{
    public class ClickModelData : IModelData
    {
        private int clickCount = 0;

        public int ClickCount => clickCount;

        public ClickModelData()
        {
            this.clickCount = 0;
        }

        public void AddClick()
        {
            clickCount++;
        }

        public void SubClick(int amount)
        {
            if (clickCount < amount)
            {
                return;
            }

            clickCount -= amount;
        }
    }

    public class ClickModel : IModel
    {
        private ClickModelData data = null;
        public event Action<ClickModelData> onChangeData = null;

        public void Init()
        {
            data = new ClickModelData();
        }

        public void OnClick()
        {
            if (data == null)
            {
                LogUtil.LogError($"Not init data");
                return;
            }

            data.AddClick();
            onChangeData?.Invoke(data);
        }
    }
}