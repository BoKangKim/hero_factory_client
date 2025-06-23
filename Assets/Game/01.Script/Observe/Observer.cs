using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Observe
{
    public class Observer : MonoBehaviour, IObserver
    {
        private NotifyData data = null;

        public virtual void OnNotify(NotifyData data = null)
        {
            this.data = data;
        }
    }
}