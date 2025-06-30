using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.AI.FSM
{
    public class IdleState : IState
    {
        private UnitController controller = null;

        public IdleState(UnitController controller)
        {
            this.controller = controller;
        }

        public void Enter()
        {
        }

        public void Exit()
        {
        }

        public void Update()
        {
        }
    }
}