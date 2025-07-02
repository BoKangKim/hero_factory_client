using UnityEngine;

namespace Game.Factory
{
    public interface IFactory
    {
        public GameObject Create(string key, Vector3 position, Quaternion rotation, Transform parent = null);
        public void Release(GameObject entity);
    }
}

