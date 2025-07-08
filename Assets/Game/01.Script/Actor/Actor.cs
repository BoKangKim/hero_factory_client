using System.Collections;
using System.Collections.Generic;
using Game.AI;
using Game.Const;
using Game.Factory;
using UnityEngine;

namespace Game.Entity
{
    public class Actor : MonoBehaviour, IActor, FactoryEntity
    {
        [SerializeField] private ActorType type;
        private Actor target = null;
        private bool isDead = false;

        public ActorType Type => type;
        public Actor Target => target;
        public bool IsDead => isDead;

        public void Attack()
        {
        }

        public void Death()
        {
            this.isDead = true;
        }

        public void Idle()
        {
            this.isDead = false;
        }

        public void Move(Vector3 direction, float speed)
        {
            Vector3 result = transform.position + direction * speed * Time.deltaTime;

            transform.position = result;
        }

        public void SetTarget(Actor target)
        {
            if (target.Type == type)
            {
                return;
            }
            
            this.target = target;
        }
    }
}