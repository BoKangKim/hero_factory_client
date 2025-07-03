using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using Game.Util;
using UnityEngine;

namespace Game.AI.FSM
{
    public class ActorMachine : MonoBehaviour, IMachine
    {
        protected Dictionary<string, IState> stateDict = new Dictionary<string, IState>();
        protected StateType defaultStartState;
        protected IState curState = null;

        protected virtual void Update()
        {
            if (curState == null)
            {
                return;
            }

            curState.Update();
        }

        public void Initializing(StateConfig config, ActorController controller)
        {
            var typeList = config.StateTypeList;

            foreach (var type in typeList)
            {
                IState newState = CreateState.Create(type, controller);
                stateDict.TryAdd(type.GetName(), newState);
            }

            this.defaultStartState = config.DefaultStartStateType;

            StartMachine();
        }

        public void StartMachine()
        {
            ChangeState(defaultStartState);
        }

        public void StopMachine()
        {
            if (curState == null)
            {
                LogUtil.LogWarning($"Already Stop Machine");
                return;
            }

            curState.Exit();
            curState = null;
        }

        public void ChangeState(string key)
        {
            if (stateDict.TryGetValue(key, out IState state))
            {
                curState?.Exit();
                curState = state;
                curState.Enter();
            }
            else
            {
                LogUtil.LogError($"Not Found {key} State in Dictionary");
                return;
            }
        }

        public void ChangeState(StateType type)
        {
            ChangeState(type.GetName());
        }
    }
}