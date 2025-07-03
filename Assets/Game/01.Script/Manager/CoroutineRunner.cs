using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Manager
{
    public class CoroutineRunner : MonoBehaviour
    {
        public Coroutine Run(IEnumerator coroutine)
        {
            Coroutine cor = StartCoroutine(coroutine);

            return cor;
        }

        public void Stop(Coroutine coroutine)
        {
            StopCoroutine(coroutine);
        }
    }
}