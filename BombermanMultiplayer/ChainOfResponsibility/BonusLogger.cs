using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.ChainOfResponsibility
{
    class BonusLogger : AbstractLogger
    {
        public BonusLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(String message)
        {
            Console.WriteLine("Bonus Console::Logger: " + message);
        }
    }
}
