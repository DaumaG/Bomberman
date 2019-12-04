using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.ChainOfResponsibility
{
    [Serializable]
    public class PlayerLogger : AbstractLogger
    {
        public PlayerLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("Player Console::Logger: " + message);
        }
    }
}
