using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using Game.Strategy;
using UnityEngine;

namespace Game.AI.FSM
{
    public class MoveState : IState
    {
        private ActorController controller = null;
        private IMoveStrategy moveStrategy = null;

        public MoveState(ActorController controller)
        {
            this.controller = controller;
            moveStrategy = controller.ActorData.CreateMoveStrategy();
        }

        public void Enter()
        {
        }

        public void Exit()
        {
        }

        public void Update()
        {
            Vector3 dir = moveStrategy.GetMoveDirection(controller);

            controller.Actor.Move(dir, controller.ActorData.Speed);
        }
    }
}