using System.Collections;
using System.Collections.Generic;
using Game.Util;
using UnityEngine;

namespace Game.MVP
{
    public class ClickPresenter : IPresenter<ClickModel, ClickView>
    {
        private ClickModel model = null;
        private ClickView view = null;

        public void Generate(ClickModel model, ClickView view)
        {
            this.model = model;
            this.view = view;

            model.Init();
            model.onChangeData += OnChangeData;
            view.Init(this);
        }

        public void OnChangeData(IModelData data)
        {
            if (view == null)
            {
                LogUtil.LogError($"Not Generated {nameof(ClickView)}");
                return;
            }

            view.UpdateView(data);
        }

        public void OnEvent(IEventData eventData)
        {
            model.OnClick();
        }
    }
}