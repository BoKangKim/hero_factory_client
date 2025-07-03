using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Const
{
    public enum InputType
    {
        PointerDown,
        PointerUp
    }

    public enum ActorType
    {
        Unit,
        Monster
    }

    // TODO : Unit, Monster Type Structure
    public enum UnitType
    {
        Standard
    }

    public enum MonsterType
    {
        Standard
    }

    public enum StateType
    {
        Idle,
        Move,
        Attack,
        Death
    }

    public enum MoveStrategyType
    {
        Unit,
        Monster
    }

    public enum AttackStrategyType
    {
        Melee,
        Range
    }
}