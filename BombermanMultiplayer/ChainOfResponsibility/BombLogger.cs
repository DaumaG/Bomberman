using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.ChainOfResponsibility
{
    [Serializable]
    public class BombLogger : AbstractLogger
    {
        public BombLogger(int level)
        {
            this.level = level;
        }

    
        protected override void Write(String message)
        {
            Console.WriteLine("Bomb Console::Logger: " + message);
        }
    }
}
