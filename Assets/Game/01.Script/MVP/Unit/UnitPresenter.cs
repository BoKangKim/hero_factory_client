using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using Game.Util;
using UnityEngine;

namespace Game.MVP
{
    public class UnitPresenter : IPresenter
    {
        private UnitModel model = null;
        private UnitView view = null;

        public void Generate(IModel model, IView view)
        {
            this.model = model as UnitModel;
            this.view = view as UnitView;

            this.model.onChangeData += OnChangeData;
            this.model.Init();
        }

        public void OnChangeData(IModelData data)
        {
            if (view == null)
            {
                LogUtil.LogError($"Not Generated {nameof(UnitView)}");
                return;
            }

            view.UpdateView(data);
        }

        public void OnEvent(IEventData eventData)
        {
        }

        public void OnSpawnUnit(Actor unit)
        {
            model.OnSpawnUnit(unit);
        }

        public Actor FindNearestUnit(Vector3 pos)
        {
            return model.FindNearestUnit(pos);
        }
    }
}