using System;
using System.Collections;
using System.Collections.Generic;
using Game.AI;
using Game.AI.FSM;
using Game.Const;
using Game.Entity;
using Game.Manager;
using UnityEngine;

namespace Game.Factory
{
    [Serializable]
    public class MonsterPrefabEntry
    {
        [SerializeField] private MonsterType type;
        [SerializeField] private ActorController prefab;

        public MonsterType Type => type;
        public ActorController Prefab => prefab;
    }

    public class MonsterFactory : MonoBehaviour,IFactory
    {
        [SerializeField] private StateConfig config;
        [SerializeField] private List<MonsterPrefabEntry> monsterPrefabEntrieList;
        [SerializeField] private float spawnRadius = 5f;

        public GameObject Create(string key, Vector3 position, Quaternion rotation, Transform parent = null)
        {
            MonsterPrefabEntry entry = monsterPrefabEntrieList.Find((value) => value.Type.ToString().Equals(key));

            if (entry == null)
            {
                return null;
            }

            float angle = UnityEngine.Random.Range(0f, 2f * Mathf.PI);

            Vector3 rndAngle = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle)) * spawnRadius;
            ActorController monster = ManagerTable.ObjectPool.InstantiateT<ActorController>(entry.Prefab.gameObject, rndAngle, rotation, parent);
            monster.Initialize(config);

            return monster.gameObject;
        }

        public void Release(GameObject entity)
        {
            ManagerTable.ObjectPool.DestroyPoolObject(entity);
        }
    }
}