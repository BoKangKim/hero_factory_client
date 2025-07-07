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

        private Vector3 destination;
        private Vector3 dir;

        public MoveState(ActorController controller)
        {
            this.controller = controller;
            moveStrategy = controller.ActorData.CreateMoveStrategy();
        }

        public void Enter()
        {
            destination = moveStrategy.GetDestination(controller);
            dir = (destination - controller.transform.position).normalized;
        }

        public void Exit()
        {
        }

        public void Update()
        {
            if (Vector3.SqrMagnitude(destination - controller.transform.position) <= 0.1f)
            {
                destination = moveStrategy.GetDestination(controller);
                dir = (destination - controller.transform.position).normalized;
                return;
            }

            controller.Actor.Move(dir, controller.ActorData.Speed);
        }
    }
}