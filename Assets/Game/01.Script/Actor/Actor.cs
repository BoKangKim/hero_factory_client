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
        public ActorType Type => type;

        public void Attack()
        {
        }

        public void Death()
        {
        }

        public void Idle()
        {
        }

        public void Move(Vector3 direction, float speed)
        {
            Vector3 result = transform.position + direction * speed * Time.deltaTime;

            transform.position = result;
        }
    }
}