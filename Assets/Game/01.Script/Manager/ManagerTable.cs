using System.Collections;
using System.Collections.Generic;
using Game.Factory;
using UnityEngine;

namespace Game.Manager
{
    public class ManagerTable : MonoBehaviour
    {
        public static ObjectPoolManager ObjectPoolManager
        {
            get
            {
                if(objectPoolManager == null)
                {
                    objectPoolManager = FindObjectOfType<ObjectPoolManager>(true);
                }

                return objectPoolManager;
            }
        }

        public static FactoryContainer FactoryContainer
        {
            get
            {
                if(factoryContainer == null)
                {
                    factoryContainer = FindObjectOfType<FactoryContainer>(true);
                }

                return factoryContainer;
            }
        }

        private static ObjectPoolManager objectPoolManager = null;
        private static FactoryContainer factoryContainer = null;
    }
}

