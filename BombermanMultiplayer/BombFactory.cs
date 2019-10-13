using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public class BombFactory : AbstractFactory
    {
        public override GameObject Create()
        {
            return new Bomb();
        }

        public override GameObject Create(int atLength, int atColumn, int playerNumber)
        {
            Bomb newBomb = 
                new Bomb.BombBuilder(atLength, atColumn, 8, 48, 48, 48, 48, Convert.ToByte(playerNumber)).addDetonationTime(2000).addPower(3).build();
            return newBomb;
        }
    }
}
