using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BombermanMultiplayer
{
    public class CheckCollisionMethod
    {
        //Check collision between two rectangles
        public bool CheckCollisionRectangle(Rectangle Object1, Rectangle Object2)
        {

            if ((Object2.X >= Object1.X + Object1.Width)      // trop à droite
                || (Object2.X + Object2.Width <= Object1.X) // trop à gauche
                || (Object2.Y >= Object1.Y + Object1.Height) // trop en bas
                || (Object2.Y + Object2.Height <= Object1.Y))  // trop en haut
                return false;
            else
                return true;
            //True if there's a collision

        }
    }
}
