using System.Collections;
using System.Collections.Generic;
using Game.Const;
using UnityEngine;

namespace Game.AI.FSM
{
    public static class StateExtension
    {
        public static string GetName(this StateType stateType)
        {
            return stateType.ToString();
        }
    }

}
