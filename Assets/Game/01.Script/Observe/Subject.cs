using System;
using System.Collections;
using System.Collections.Generic;
using Game.Util;
using UnityEngine;

// TODO : Data, Event, Observer 역할 분리
// 지금은 구조는 Subject 클래스가 많은 역할을 담당해야 함
namespace Game.Observe
{
    public class Subject : MonoBehaviour, ISubject
    {
        public event Action<NotifyData> callBack = null;

        public virtual void Notify(NotifyData data = null)
        {

        }

        public virtual void RegisterObserver(IObserver observer)
        {

        }

        public virtual void RemoveObserver(IObserver observer)
        {

        }
    }
}