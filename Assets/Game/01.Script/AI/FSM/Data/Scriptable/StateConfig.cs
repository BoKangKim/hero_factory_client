using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Game.Const;
using UnityEngine;

namespace Game.AI.FSM
{
    [CreateAssetMenu(fileName = "StateConfig", menuName = "Config/State/StateConfig")]
    public class StateConfig : ScriptableObject
    {
        [SerializeField] private List<StateType> stateTypeList;
        [SerializeField] private StateType defaultStartStateType;

        public ReadOnlyCollection<StateType> StateTypeList => stateTypeList.AsReadOnly();
        public StateType DefaultStartStateType => defaultStartStateType;
    }
}