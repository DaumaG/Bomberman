using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BombermanMultiplayer
{
    public interface ICheckCollisionStrategy
    {
        bool CheckDirection(Player movingPlayer, Player player2, Tile[,] map);
    }
}
