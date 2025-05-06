using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Factory
{
    public class ObjectPool<T> : IObjectPool where T : Component, FactoryEntity
    {
        private Queue<T> pool = new Queue<T>();
        private T prefab = null;
        private int maxCount = 0;

        public ObjectPool(T prefab, int awakeCreateCount, int maxCount)
        {
            this.prefab = prefab;
            this.maxCount = maxCount == 0 ? int.MaxValue : maxCount;
            
            for(int i = 0; i < awakeCreateCount; i++)
            {
                T inst = GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity);
                inst.gameObject.SetActive(false);
                pool.Enqueue(inst);
            }
        }

        public T Create(Vector3 position, Quaternion rotation, Transform parent = null)
        {
            if(prefab == null)
            {
                Debug.LogError($"Not Set Prefab");
                return null;
            }

            T inst = null;

            if(pool.Count > 0)
            {
                inst = pool.Dequeue();
            }
            else
            {
                inst = GameObject.Instantiate<T>(prefab, position, rotation, parent);
            }

            inst.gameObject.SetActive(true);

            return inst;
        }

        public void Destroy(T entity)
        {
            entity.gameObject.SetActive(false);

            pool.Enqueue(entity);
        }
    }
}