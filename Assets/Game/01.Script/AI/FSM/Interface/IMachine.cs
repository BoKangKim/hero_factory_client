using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using UnityEngine;

namespace Game.AI.FSM
{
    public interface IMachine
    {
        public void Initializing(StateConfig config, UnitController controller);
        public void StartMachine();
        public void StopMachine();
        public void ChangeState(string key);
        public void ChangeState(StateType type);
    }
}