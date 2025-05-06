using System;
using System.Collections;
using System.Collections.Generic;
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

    public class UnitFactory : FactoryBase<UnitBase>
    {
        [SerializeField] private List<UnitPrefabEntry> unitPrefabEntrieList;

        public override UnitBase Create(string key, Vector3 position, Quaternion rotation, Transform parent = null)
        {
            UnitPrefabEntry targetEntry = unitPrefabEntrieList.Find((value) => value.Key.Equals(key));

            if(targetEntry == null)
            {
                Debug.LogError($"Not Found {key}");
                return null;
            }

            // ManagerTable.ObjectPoolManager.CreateOrGet<UnitBase>(targetEntry.Prefab, );
            return null;
        }

        public override void Destroy(string key, UnitBase entity)
        {
            throw new NotImplementedException();
        }
    }
}

