using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.Strategy
{
    public interface IMoveStrategy
    {
        public Vector3 GetMoveDirection(ActorController controller);
    }
}