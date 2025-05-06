using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Factory
{
    public class FactoryContainer : MonoBehaviour
    {
        private Dictionary<string, IFactory> factoryDict = new Dictionary<string, IFactory>();

        public T RegisterOrGet<T>() where T : class, IFactory
        {
            IFactory factory = null;

            if(!factoryDict.TryGetValue(typeof(T).ToString(), out factory))
            {
                factory = GetComponentInChildren<T>();

                if(factory != null)
                {
                    factoryDict.Add(typeof(T).ToString(), factory);
                }
                else
                {
                    Debug.LogError($"Not Fount {typeof(T)}");
                    return null;
                }
            }

            return factory as T;
        }
    }
}