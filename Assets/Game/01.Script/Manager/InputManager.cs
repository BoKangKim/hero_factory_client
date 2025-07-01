using System;
using System.Collections;
using System.Collections.Generic;
using Game.Const;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game.Manager
{
    public class InputManager : MonoBehaviour
    {
        public event Action<PointerEventData> onPointerDown = null;
        public event Action<PointerEventData> onPointerUp = null;

        public void Subscribe(InputType inputType, Action<PointerEventData> action)
        {
            if (action == null)
            {
                return;
            }

            switch (inputType)
            {
                case InputType.PointerDown:
                    this.onPointerDown += action;
                    break;
                case InputType.PointerUp:
                    this.onPointerUp += action;
                    break;
            }
        }

        public void UnSubscribe(InputType inputType, Action<PointerEventData> action)
        {
            if (action == null)
            {
                return;
            }

            switch (inputType)
            {
                case InputType.PointerDown:
                    this.onPointerDown -= action;
                    break;
                case InputType.PointerUp:
                    this.onPointerUp -= action;
                    break;
            }
        }

        public void PlayAction(InputType inputType, PointerEventData data)
        { 
            switch (inputType)
            {
                case InputType.PointerDown:
                    onPointerDown?.Invoke(data);
                    break;
                case InputType.PointerUp:
                    onPointerDown?.Invoke(data);
                    break;
            }
        }
    }
}