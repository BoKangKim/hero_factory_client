using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using Game.Manager;
using Game.MVP;
using UnityEngine;

namespace Game.Strategy
{
    public class UnitTargetProvider : ITargetProvider
    {
        private MonsterPresenter monsterPresenter = null;

        public void Init()
        {
            if (monsterPresenter == null)
            {
                monsterPresenter = ManagerTable.PresenterContainer.GetPresenter<MonsterPresenter>();
            }
        }

        public Actor FindTargetInRange(Vector3 pos, float range)
        {
            Actor target = monsterPresenter.FindNearestMonster(pos);

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