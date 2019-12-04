using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.ChainOfResponsibility
{
    [Serializable]
    public class GameLogger : AbstractLogger
    {
        public GameLogger(int level)
        {
            this.level = level;
        }


        protected override void Write(String message)
        {
            Console.WriteLine("Game Console::Logger: " + message);
        }
    }
}
