using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Visitor
{
    public class BackgroundVisitor : IVisitor
    {
        public void Visit(BombPicture picture)
        {
            picture._pictureBox.BackColor = Color.LightYellow;
        }

        public void Visit(PlayerPicture picture)
        {
            picture._pictureBox.BackColor = Color.LightGreen;
        }

        public void Visit(ExplosionPicture picture)
        {
            picture._pictureBox.BackColor = Color.LightBlue;
        }
    }
}
