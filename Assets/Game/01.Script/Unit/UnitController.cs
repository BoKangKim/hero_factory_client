using System.Collections;
using System.Collections.Generic;
using Game.AI.FSM;
using UnityEngine;

namespace Game.Entity
{
    [RequireComponent(typeof(Unit), typeof(UnitMachine))]
    public class UnitController : MonoBehaviour
    {
        [SerializeField] private Unit unit;
        [SerializeField] private UnitMachine unitMachine;

        public Unit Unit => unit;
        public UnitMachine UnitMachine => unitMachine;

        public void Initialize(StateConfig config)
        {
            // Unit 초기화
            unitMachine.Initializing(config, this);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (unit == null)
            {
                unit = GetComponent<Unit>();
            }

            if (unitMachine == null)
            {
                unitMachine = GetComponent<UnitMachine>();
            }
        }
#endif
    }
}