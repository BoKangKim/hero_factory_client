using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using Game.Util;
using UnityEngine;

namespace Game.Strategy
{
    public class MonsterMoveStrategy : IMoveStrategy
    {
        private Nexus nexus = null;

        public void Init()
        {
            if (nexus == null)
            {
                nexus = GameObject.FindObjectOfType<Nexus>();
            }
        }

        public Vector3 GetDestination(ActorController controller)
        {
            Vector3 nexusPos = nexus.transform.position;

            return nexusPos;
        }
    }
}