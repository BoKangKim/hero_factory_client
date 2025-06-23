using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Game.Const;
using Game.Util;
using Game.Manager;

namespace Game.Input
{
    public class InputPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            ManagerTable.InputManager.PlayAction(InputType.PointerDown, eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            ManagerTable.InputManager.PlayAction(InputType.PointerUp, eventData);
        }
    }
}