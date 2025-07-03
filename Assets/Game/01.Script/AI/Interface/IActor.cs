using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.AI
{
    public interface IActor
    {
        public void Idle();
        public void Move(Vector3 direction, float speed);
        public void Attack();
        public void Death();
    }
}