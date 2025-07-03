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

        private Vector3 dir;

        public MoveState(ActorController controller)
        {
            this.controller = controller;
            moveStrategy = controller.ActorData.CreateMoveStrategy();
        }

        public void Enter()
        {
            dir = moveStrategy.GetMoveDirection(controller);
        }

        public void Exit()
        {
        }

        public void Update()
        {
            controller.Actor.Move(dir, controller.ActorData.Speed);
        }
    }
}