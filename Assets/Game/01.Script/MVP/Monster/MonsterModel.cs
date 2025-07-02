using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.MVP
{
    public class MonsterModelData : IModelData
    {
        private int monsterCount = 0;

        public int MonsterCount => monsterCount;

        public MonsterModelData()
        {
            monsterCount = 0;
        }

        public void AddMonsterCount()
        {
            this.monsterCount++;
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

        public void OnSpawnMonster()
        {
            data.AddMonsterCount();
            onChangeData?.Invoke(data);
        }
    }
}
