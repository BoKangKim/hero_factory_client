using System.Collections;
using System.Collections.Generic;
using Game.Data;
using UnityEngine;

namespace Game.Strategy
{
    public static class StrategyExtension
    {
        public static IMoveStrategy CreateMoveStrategy(this ActorData actorData)
        {
            switch (actorData.MoveStrategyType)
            {
                case Const.MoveStrategyType.Unit:
                    return new UnitMoveStrategy();                    
                case Const.MoveStrategyType.Monster:
                    return new MonsterMoveStrategy();
            }

            return null;
        }
        
    }

}