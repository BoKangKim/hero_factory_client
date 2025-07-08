using System;
using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.MVP
{
    public class UnitModelData : IModelData
    {
        private List<Actor> unitList = new List<Actor>();
        public int UnitCount => unitList.Count;

        public void AddUnit(Actor unit)
        {
            this.unitList.Add(unit);
        }

        public void RemoveUnit(Actor unit)
        {
            this.unitList.Remove(unit);
        }

        public Actor FindNearestUnit(Vector3 pos)
        { 
            if (unitList.Count == 0)
            {
                return null;
            }

            float minMag = Vector3.SqrMagnitude(pos - unitList[0].transform.position);
            Actor nearestUnit = unitList[0];

            for (int i = 1; i < unitList.Count; i++)
            {
                if (unitList[i].IsDead)
                {
                    continue;
                }
                
                float mag = Vector3.SqrMagnitude(pos - unitList[i].transform.position);

                if (mag < minMag)
                {
                    minMag = mag;
                    nearestUnit = unitList[i];
                }
            }

            return nearestUnit;
        }
    }

    public class UnitModel : IModel
    {
        private UnitModelData data = null;
        public event Action<IModelData> onChangeData = null;

        public void Init()
        {
            data = new UnitModelData();
            onChangeData?.Invoke(data);
        }

        public void OnSpawnUnit(Actor unit)
        {
            data.AddUnit(unit);
            onChangeData?.Invoke(data);
        }

        public Actor FindNearestUnit(Vector3 pos)
        {
            return data.FindNearestUnit(pos);
        }
    }
}