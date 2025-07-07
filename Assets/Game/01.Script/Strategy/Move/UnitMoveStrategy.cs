using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using Game.Manager;
using Game.MVP;
using UnityEngine;

namespace Game.Strategy
{
    public class UnitMoveStrategy : IMoveStrategy
    {
        public Vector3 GetDestination(ActorController controller)
        {
            MonsterPresenter presenter = ManagerTable.PresenterContainer.GetPresenter<MonsterPresenter>();
            Actor monster = presenter.FindNearestMonster(controller.transform.position);

            if (monster == null)
            {
                float angle = UnityEngine.Random.Range(0f, 2f * Mathf.PI);
                Vector3 rndPos = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle));

                return rndPos;
            }

            return monster.transform.position;
        }
    }
}