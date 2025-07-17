using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using UnityEngine;

namespace Game.AI.FSM
{
    public class IdleState : IState
    {
        private ActorController controller = null;

        public IdleState(ActorController controller)
        {
            this.controller = controller;
        }

        public void Enter()
        {
            controller.Actor.Idle();
            controller.ActorMachine.ChangeState(nameof(StateType.Move));
        }

        public void Exit()
        {
        }

        public void Update()
        {
        }
    }
}