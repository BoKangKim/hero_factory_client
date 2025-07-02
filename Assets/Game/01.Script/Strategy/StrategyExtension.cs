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
                    break;
                case Const.MoveStrategyType.Monster:
                    return new MonsterMove();
            }

            return null;
        }
        
    }

}