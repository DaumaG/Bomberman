using BombermanMultiplayer.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Visitor
{
    public class ImageLoadVisitor : IVisitor
    {
        public void Visit(BombPicture picture)
        {
            picture._pictureBox.Image = Resources.Bombe;
        }

        public void Visit(PlayerPicture picture)
        {
            picture._pictureBox.Image = Resources.T_DOWN;
        }

        public void Visit(ExplosionPicture picture)
        {
            picture._pictureBox.Image = Resources.Fire;
        }
    }
}
