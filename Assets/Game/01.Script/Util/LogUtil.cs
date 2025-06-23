using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Util
{
    public static class LogUtil
    {
        public static void Log(object msg, string color = null)
        {
#if UNITY_EDITOR
            if (string.IsNullOrEmpty(color))
            {
                Debug.Log(msg);
            }
            else
            {
                Debug.Log($"[LOG] <color={color}>{msg.ToString()}</color>");
            }
#endif
        }

        public static void LogWarning(object msg, string color = null)
        {
#if UNITY_EDITOR
            if (string.IsNullOrEmpty(color))
            {
                Debug.Log(msg);
            }
            else
            {
                Debug.Log($"[Warning] <color={color}>{msg.ToString()}</color>");
            }
#endif
        }

        public static void LogError(object msg, string color = null)
        {
#if UNITY_EDITOR
            if (string.IsNullOrEmpty(color))
            {
                Debug.Log(msg);
            }
            else
            {
                Debug.Log($"[Error] <color={color}>{msg.ToString()}</color>");
            }
#endif
        }
    }
}