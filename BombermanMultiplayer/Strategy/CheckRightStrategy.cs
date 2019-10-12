using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BombermanMultiplayer
{
    public class CheckRightStrategy : CheckCollisionMethod, ICheckCollisionStrategy
    {
        public bool CheckDirection(Player movingPlayer, Player player2, Tile[,] map)
        {
            int lig = movingPlayer.CasePosition[0];
            int col = movingPlayer.CasePosition[1];

            Rectangle rect = new Rectangle(movingPlayer.Source.X + movingPlayer.Vitesse, movingPlayer.Source.Y, movingPlayer.Source.Width, movingPlayer.Source.Height);
            //RIGHT
            if (!map[lig - 1, col + 1].Walkable || map[lig - 1, col + 1].Occupied)
            {
                if (CheckCollisionRectangle(rect, map[lig - 1, col + 1].Source))
                    return false;
            }
            if (!map[lig, col + 1].Walkable || map[lig, col + 1].Occupied)
            {
                if (CheckCollisionRectangle(rect, map[lig, col + 1].Source))
                    return false;
            }
            if (!map[lig + 1, col + 1].Walkable || map[lig + 1, col + 1].Occupied)
            {
                if (CheckCollisionRectangle(rect, map[lig + 1, col + 1].Source))
                    return false;
            }
            if (CheckCollisionRectangle(rect, player2.Source))
                return false;

            return true;
        }
    }
}
