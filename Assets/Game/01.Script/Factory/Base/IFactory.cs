using UnityEngine;

namespace Game.Factory
{
    public interface IFactory
    {
        public Object Create(string key, Vector3 position, Quaternion rotation, Transform parent = null);
        public void Release(Object entity);
    }
}

