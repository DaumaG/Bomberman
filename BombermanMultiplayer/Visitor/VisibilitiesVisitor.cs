using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Visitor
{
    public class VisibilitiesVisitor : IVisitor
    {
        public void Visit(BombPicture picture)
        {
            picture._pictureBox.Visible = true;
        }

        public void Visit(PlayerPicture picture)
        {
            picture._pictureBox.Visible = true;
        }

        public void Visit(ExplosionPicture picture)
        {
            picture._pictureBox.Visible = true;
        }
    }
}
