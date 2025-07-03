using System.Collections;
using System.Collections.Generic;
using Game.Factory;
using Game.MVP;
using UnityEngine;

namespace Game.Manager
{
    public class ManagerTable : MonoBehaviour
    {
        public static ObjectPool ObjectPool
        {
            get
            {
                if (objectPool == null)
                {
                    objectPool = FindObjectOfType<ObjectPool>();
                }

                return objectPool;
            }
        }

        public static FactoryContainer FactoryContainer
        {
            get
            {
                if (factoryContainer == null)
                {
                    factoryContainer = FindObjectOfType<FactoryContainer>(true);
                }

                return factoryContainer;
            }
        }

        public static InputManager InputManager
        {
            get
            {
                if (inputManager == null)
                {
                    inputManager = FindObjectOfType<InputManager>(true);
                }

                return inputManager;
            }
        }

        public static PresenterContainer PresenterContainer
        {
            get
            {
                if (presenterContainer == null)
                {
                    presenterContainer = FindObjectOfType<PresenterContainer>(true);
                }

                return presenterContainer;
            }
        }

        public static CoroutineRunner CoroutineRunner
        {
            get
            {
                if (coroutineRunner == null)
                {
                    coroutineRunner = FindObjectOfType<CoroutineRunner>(true);
                }

                return coroutineRunner;
            }
        }

        private static ObjectPool objectPool = null;
        private static FactoryContainer factoryContainer = null;
        private static InputManager inputManager = null;
        private static PresenterContainer presenterContainer = null;
        private static CoroutineRunner coroutineRunner = null;
    }
}

