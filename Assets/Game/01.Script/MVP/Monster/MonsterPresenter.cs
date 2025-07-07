using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using Game.Factory;
using Game.Manager;
using Game.Util;
using UnityEngine;

namespace Game.MVP
{
    public class MonsterPresenter : IPresenter
    {
        private MonsterModel model = null;
        private MonsterView view = null;

        // TODO : 나중에 ScriptableObject 같은 것으로 데이터 입히기
        private float spawnTime = 1f;

        private MonsterFactory factory = null;

        private Coroutine timerCoroutine = null;
        private float time = 0f;

        public void Generate(IModel model, IView view)
        {
            this.model = model as MonsterModel;
            this.view = view as MonsterView;

            this.model.onChangeData += OnChangeData;
            this.model.Init();

            timerCoroutine = ManagerTable.CoroutineRunner.Run(SpawnTimer());
            factory = ManagerTable.FactoryContainer.RegisterOrGet<MonsterFactory>();
        }

        public void OnChangeData(IModelData data)
        {
            if (view == null)
            {
                LogUtil.LogError($"Not Generated {nameof(MonsterView)}");
                return;
            }

            view.UpdateView(data);
        }

        public void OnEvent(IEventData eventData)
        {
        }

        private IEnumerator SpawnTimer()
        {
            while (true)
            {
                time += Time.deltaTime;

                if (time >= spawnTime)
                {
                    Actor monster = factory.Create(MonsterType.Standard.ToString(), Vector3.zero, Quaternion.identity) as Actor;
                    model.OnSpawnMonster(monster);
                    time = 0f;
                }

                yield return null;
            }
        }

        public Actor FindNearestMonster(Vector3 pos)
        {
            return model.FindNearestMonster(pos);
        }
    }
}