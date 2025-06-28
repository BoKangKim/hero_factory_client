using System;
using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using Game.Manager;
using UnityEngine;

namespace Game.Factory
{
    [Serializable]
    public class UnitPrefabEntry
    {
        [SerializeField] private UnitType type;
        [SerializeField] private UnitBase prefab;

        public UnitType Type => type;
        public UnitBase Prefab => prefab;

        public string Key => type.ToString();
    }

    public class UnitFactory : MonoBehaviour, IFactory
    {
        [SerializeField] private List<UnitPrefabEntry> unitPrefabEntrieList;

        public UnityEngine.Object Create(string key, Vector3 position, Quaternion rotation, Transform parent = null)
        {
            UnitPrefabEntry entry = unitPrefabEntrieList.Find((value) => value.Type.ToString().Equals(key));

            if (entry == null)
            {
                return null;
            }

            float angle = UnityEngine.Random.Range(0f, 2f * Mathf.PI);

            Vector3 rndPos = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle));
            UnitBase unit = ManagerTable.ObjectPool.InstantiateT<UnitBase>(entry.Prefab.gameObject, rndPos, rotation, parent);

            return unit;
        }

        public void Release(UnityEngine.Object entity)
        {
            ManagerTable.ObjectPool.DestroyPoolObject(entity as GameObject);
        }
    }
}

