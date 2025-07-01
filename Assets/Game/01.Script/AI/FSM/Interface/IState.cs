using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.AI.FSM
{
    public interface IState
    {
        public void Enter();
        public void Exit();
        public void Update();
    }
}