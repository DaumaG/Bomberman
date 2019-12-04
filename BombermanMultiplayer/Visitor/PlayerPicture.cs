using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer.Visitor
{
    public class PlayerPicture : CustomPicture
    {
        public PlayerPicture(PictureBox pictureBox) : base(pictureBox)
        {
        }

        public override void RespondToVisit(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
