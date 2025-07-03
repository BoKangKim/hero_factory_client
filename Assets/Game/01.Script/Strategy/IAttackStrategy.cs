using System.Collections;
using System.Collections.Generic;
using Game.Entity;
using UnityEngine;

namespace Game.Strategy
{
    public interface IAttackStrategy
    {
        public void Attack(Actor owner, Actor target);
    }
}