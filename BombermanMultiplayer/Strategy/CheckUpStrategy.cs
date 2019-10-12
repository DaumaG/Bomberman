using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BombermanMultiplayer
{
    public class CheckUpStrategy : CheckCollisionMethod, ICheckCollisionStrategy
    {
        public bool CheckDirection(Player movingPlayer, Player player2, Tile[,] map)
        {
            int lig = movingPlayer.CasePosition[0];
            int col = movingPlayer.CasePosition[1];

            //UP
            //Temporary version of player collision box with expected position after deplacement
            Rectangle rect = new Rectangle(movingPlayer.Source.X, movingPlayer.Source.Y - movingPlayer.Vitesse, movingPlayer.Source.Width, movingPlayer.Source.Height);

            if (!map[lig - 1, col - 1].Walkable || map[lig - 1, col - 1].Occupied)
            {
                if (CheckCollisionRectangle(rect, map[lig - 1, col - 1].Source))
                    return false;
            }
            if (!map[lig - 1, col].Walkable || map[lig - 1, col].Occupied)
            {
                if (CheckCollisionRectangle(rect, map[lig - 1, col].Source))
                    return false;
            }
            if (!map[lig - 1, col + 1].Walkable || map[lig - 1, col + 1].Occupied)
            {
                if (CheckCollisionRectangle(rect, map[lig - 1, col + 1].Source))
                    return false;
            }
            if (CheckCollisionRectangle(rect, player2.Source))
                return false;

            return true;
        }
    }
}
