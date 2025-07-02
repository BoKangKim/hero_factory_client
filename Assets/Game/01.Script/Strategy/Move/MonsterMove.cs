using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.Strategy
{
    public class MonsterMove : IMoveStrategy
    {
        public Vector3 GetMoveDirection(ActorController controller)
        {
            Nexus nexus = GameObject.FindObjectOfType<Nexus>();

            Vector3 unitPos = controller.transform.position;
            Vector3 nexusPos = nexus.transform.position;

            Vector3 direction = (nexusPos - unitPos).normalized;

            return direction;
        }
    }
}