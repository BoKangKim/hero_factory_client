using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.Strategy
{
    public class MonsterMoveStrategy : IMoveStrategy
    {
        public Vector3 GetDestination(ActorController controller)
        {
            Nexus nexus = GameObject.FindObjectOfType<Nexus>();

            Vector3 nexusPos = nexus.transform.position;

            return nexusPos;
        }
    }
}