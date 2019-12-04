using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer.Visitor
{
    public abstract class CustomPicture
    {
        public PictureBox _pictureBox { get; set; }

        public CustomPicture(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
        }

        public abstract void RespondToVisit(IVisitor visitor);
    }
}
