using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.Strategy
{
    public interface ITargetProvider
    {
        public void Init();
        public Actor FindTargetInRange(Vector3 pos, float range);
    }
}