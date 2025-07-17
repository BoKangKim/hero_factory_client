using System.Collections;
using System.Collections.Generic;
using Game.Const;
using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(fileName = "ActorData", menuName = "Config/Data/ActorData")]
    public class ActorData : ScriptableObject
    {
        [SerializeField] private int hp;
        [SerializeField] private float attackSpeed;
        [SerializeField] private float attackPower;
        [SerializeField] private float attackRange;
        [SerializeField] private float speed;

        [SerializeField] private MoveStrategyType moveStrategyType;
        [SerializeField] private AttackStrategyType attackStrategyType;

        public float Speed => speed;
        public float AttackRange => attackRange;

        public MoveStrategyType MoveStrategyType => moveStrategyType;
        public AttackStrategyType AttackStrategyType => attackStrategyType;
    }
}