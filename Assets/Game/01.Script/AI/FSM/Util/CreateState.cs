using System.Collections;
using System.Collections.Generic;
using Game.Const;
using Game.Entity;
using UnityEngine;

namespace Game.AI.FSM
{
    public static class CreateState
    {
        public static IState Create(StateType type, UnitController controller)
        {
            switch (type)
            {
                case StateType.Idle:
                    return new IdleState(controller);
                case StateType.Move:
                    return new MoveState(controller);
                case StateType.Attack:
                    return new AttackState(controller);
                case StateType.Death:
                    return new DeathState(controller);
            }

            return null;
        }
    }
}