using System;
using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.MVP
{
    public class MonsterModelData : IModelData
    {
        private List<Actor> monsterList = new List<Actor>();

        public int MonsterCount => monsterList.Count;

        public void AddMonster(Actor monster)
        {
            this.monsterList.Add(monster);
        }

        public void RemoveMonster(Actor monster)
        {
            this.monsterList.Remove(monster);
        }

        public Actor FindNearestMonster(Vector3 pos)
        {
            if (monsterList.Count == 0)
            {
                return null;
            }

            float minMag = Vector3.SqrMagnitude(pos - monsterList[0].transform.position);
            Actor nearestMonster = monsterList[0];

            for (int i = 1; i < monsterList.Count; i++)
            {
                if (monsterList[i].IsDead)
                {
                    continue;
                }
                
                float mag = Vector3.SqrMagnitude(pos - monsterList[i].transform.position);

                if (mag < minMag)
                {
                    minMag = mag;
                    nearestMonster = monsterList[i];
                }
            }

            return nearestMonster;
        }
    }
    public class MonsterModel : IModel
    {
        private MonsterModelData data = null;

        public event Action<IModelData> onChangeData = null;

        public void Init()
        {
            data = new MonsterModelData();
            onChangeData?.Invoke(data);
        }

        public void OnSpawnMonster(Actor monster)
        {
            data.AddMonster(monster);
            onChangeData?.Invoke(data);
        }

        public Actor FindNearestMonster(Vector3 pos)
        {
            return data.FindNearestMonster(pos);
        }
    }
}
