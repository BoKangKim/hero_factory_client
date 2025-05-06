using System.Collections;
using System.Collections.Generic;
using Game.Factory;
using UnityEngine;

namespace Game.Manager
{
    public class ObjectPoolManager : MonoBehaviour
    {
        private Dictionary<string, IObjectPool> poolDict = new Dictionary<string, IObjectPool>();

        public ObjectPool<T> CreateOrGet<T>(string key, T prefab, int awakeCreateCount, int maxCount = 0) where T : Component,FactoryEntity
        {
            IObjectPool objectPool = null;

            if(!poolDict.TryGetValue(key, out objectPool))
            {
                objectPool = new ObjectPool<T>(prefab, awakeCreateCount, maxCount);
                poolDict.Add(key, objectPool);
            }

            return objectPool as ObjectPool<T>;
        }
    }
}