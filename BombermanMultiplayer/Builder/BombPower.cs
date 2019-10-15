using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Builder
{
    public class BombPower
    {
        int bombPower = 0;
        public BombPower(string power)
        {
            switch (power)
            {
                case "small":
                    bombPower = 2;
                    break;
                case "medium":
                    bombPower = 3;
                    break;
                case "big":
                    bombPower = 4;
                    break;
                default:
                    break;
            }
        }

        public int toInt()
        {
            return bombPower;
        }
    }
}
