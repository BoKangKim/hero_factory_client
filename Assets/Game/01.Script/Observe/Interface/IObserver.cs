using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Observe
{
    public interface NotifyData
    { 
    }

    public interface IObserver
    {
        public void OnNotify(NotifyData data = null);
    }
}