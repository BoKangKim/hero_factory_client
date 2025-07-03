using System.Collections;
using System.Collections.Generic;
using Game.AI.FSM;
using Game.Data;
using UnityEngine;

namespace Game.Entity
{
    [RequireComponent(typeof(Actor), typeof(ActorMachine))]
    public class ActorController : MonoBehaviour
    {
        [SerializeField] private ActorData actorData;
        [SerializeField] private Actor actor;
        [SerializeField] private ActorMachine actorMachine;

        public ActorData ActorData => actorData;
        public Actor Actor => actor;
        public ActorMachine ActorMachine => actorMachine;

        public void Initialize(StateConfig config)
        {
            // Unit 초기화
            actorMachine.Initializing(config, this);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (actor == null)
            {
                actor = GetComponent<Actor>();
            }

            if (actorMachine == null)
            {
                actorMachine = GetComponent<ActorMachine>();
            }
        }
#endif
    }
}