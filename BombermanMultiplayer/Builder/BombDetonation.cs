using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Builder
{
    public class BombDetonation
    {
        int detonationTime = 0;
        public BombDetonation(string time)
        {
            switch (time)
            {
                case "short":
                    detonationTime = 1000;
                    break;
                case "medium":
                    detonationTime = 2000;
                    break;
                case "long":
                    detonationTime = 3000;
                    break;
                default:
                    break;
            }
        }

        public int toInt()
        {
            return detonationTime;
        }
    }
}
