using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.AI.FSM
{
    public class DeathState : IState
    {
        private UnitController controller = null;

        public DeathState(UnitController controller)
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