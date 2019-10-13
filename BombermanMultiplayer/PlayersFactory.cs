using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer
{
    public class PlayersFactory : AbstractFactory
    {
        public override GameObject Create()
        {
            return new Player();
        }

        public override GameObject Create(int borderLength, int borderHeight, int playerNumber)
        {
            return new Player(1, 2, 33, 33, borderLength, borderHeight, 48, 48, 80, Convert.ToByte(playerNumber));
        }
    }
}
