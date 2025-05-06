using System;
using System.Collections;
using System.Collections.Generic;
using Game.Manager;
using UnityEngine;

namespace Game.Factory
{
    public abstract class FactoryBase<T> : MonoBehaviour, IFactory where T : Component, FactoryEntity
    {
        [SerializeField] protected int awakeCreateCount;
        [SerializeField] protected int maxCount;

        public abstract T Create(string key, Vector3 position, Quaternion rotation, Transform parent = null);
        public abstract void Destroy(string key, T entity);
    }
}