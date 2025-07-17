using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using Game.Manager;
using Game.MVP;
using UnityEngine;

namespace Game.Strategy
{
    public class MonsterTargetProvider : ITargetProvider
    {
        private UnitPresenter unitPresenter = null;

        public void Init()
        {
            if (unitPresenter == null)
            {
                unitPresenter = ManagerTable.PresenterContainer.GetPresenter<UnitPresenter>();
            }
        }

        public Actor FindTargetInRange(Vector3 pos, float range)
        {
            Actor target = unitPresenter.FindNearestUnit(pos);

            if (target == null)
            {
                return null;
            }

            if (Vector3.SqrMagnitude(pos - target.transform.position) <= range)
            {
                return target;
            }

            return null;
        }
    }
}