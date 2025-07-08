using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using Game.Strategy;
using Game.Util;
using UnityEngine;

namespace Game.AI.FSM
{
    public class MoveState : IState
    {
        private ActorController controller = null;
        private IMoveStrategy moveStrategy = null;
        private ITargetProvider targetProvider = null;

        private Vector3 destination;
        private Vector3 dir;

        public MoveState(ActorController controller)
        {
            this.controller = controller;
            moveStrategy = controller.ActorData.CreateMoveStrategy();
            targetProvider = controller.ActorData.CreateTargetProvider();
        }

        public void Enter()
        {
            moveStrategy.Init();
            targetProvider.Init();

            destination = moveStrategy.GetDestination(controller);
            dir = (destination - controller.transform.position).normalized;
        }

        public void Exit()
        {
        }

        public void Update()
        {
            Actor target = targetProvider.FindTargetInRange(controller.transform.position, controller.ActorData.AttackRange);
            if (target != null)
            {
                controller.Actor.SetTarget(target);
                controller.ActorMachine.ChangeState(nameof(StateType.Attack));

                return;
            }
            
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