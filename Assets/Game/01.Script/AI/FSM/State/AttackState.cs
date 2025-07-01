using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.AI.FSM
{
    public class AttackState : IState
    {
        private UnitController controller = null;
        public AttackState(UnitController controller)
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