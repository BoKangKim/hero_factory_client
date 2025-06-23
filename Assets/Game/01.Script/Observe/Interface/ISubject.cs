using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Observe
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void Notify(NotifyData data = null);
    }
}