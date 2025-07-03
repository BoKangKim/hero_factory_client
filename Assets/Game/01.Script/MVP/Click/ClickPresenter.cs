using System;
using System.Collections;
using System.Collections.Generic;
using Game.Util;
using UnityEngine;

namespace Game.MVP
{
    public class ClickPresenter : IPresenter
    {
        private ClickModel model = null;
        private ClickView view = null;

        public event Action<IModelData> onChangeData = null;

        public void Generate(IModel model, IView view)
        {
            this.model = model as ClickModel;
            this.view = view as ClickView;

            this.model.Init();
            this.model.onChangeData += OnChangeData;
            this.view.Init(this);
        }

        public void OnChangeData(IModelData data)
        {
            if (view == null)
            {
                LogUtil.LogError($"Not Generated {nameof(ClickView)}");
                return;
            }

            view.UpdateView(data);
            onChangeData?.Invoke(data);
        }

        public void OnEvent(IEventData eventData)
        {
            model.OnClick();
        }
    }
}