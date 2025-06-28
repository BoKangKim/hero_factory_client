using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Util
{
    [Serializable]
    public class Pair<T1, T2> where T1 : UnityEngine.Object where T2 : UnityEngine.Object
    {
        [SerializeField] protected T1 value1;
        [SerializeField] protected T2 value2;

        public T1 Value1 => value1;
        public T2 Value2 => value2;
    }
}