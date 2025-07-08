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
        private bool isSpawn = false;

        public void Init()
        {
            isSpawn = false;
        }

        public Vector3 GetDestination(ActorController controller)
        {
            if (!isSpawn)
            {
                float angle = UnityEngine.Random.Range(0f, 2f * Mathf.PI);
                Vector3 rndPos = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle));

                isSpawn = true;

                return rndPos;
            }

            MonsterPresenter presenter = ManagerTable.PresenterContainer.GetPresenter<MonsterPresenter>();
            Actor monster = presenter.FindNearestMonster(controller.transform.position);

            return monster.transform.position;
        }
    }
}