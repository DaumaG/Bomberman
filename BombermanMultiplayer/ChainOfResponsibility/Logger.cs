using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.ChainOfResponsibility
{
    public static class Logger
    {
        public static AbstractLogger GetChain()
        {
            AbstractLogger gameLogger = new GameLogger(AbstractLogger.GAME);
            AbstractLogger playerLogger = new PlayerLogger(AbstractLogger.PLAYER);
            AbstractLogger bombLogger = new BombLogger(AbstractLogger.BOMB);
            AbstractLogger bonusLogger = new BonusLogger(AbstractLogger.BONUS);

            gameLogger.setNextLogger(playerLogger);
            playerLogger.setNextLogger(bombLogger);
            bombLogger.setNextLogger(bonusLogger);

            return gameLogger;
        }
       
    }
}
