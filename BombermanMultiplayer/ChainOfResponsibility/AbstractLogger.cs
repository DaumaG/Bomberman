using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.ChainOfResponsibility
{
    [Serializable]
    public abstract class AbstractLogger
    {
        public static int GAME = 1;
        public static int PLAYER = 2;
        public static int BOMB = 3;
        public static int BONUS = 4;

        protected int level;

        //next element in chain or responsibility
        protected AbstractLogger nextLogger;

        public void setNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void logMessage(int level, String message)
        {
            if (this.level <= level)
            {
                Write(message);
            }
            if (nextLogger != null)
            {
                nextLogger.logMessage(level, message);
            }
        }

        protected abstract void Write(String message);
    }
}
