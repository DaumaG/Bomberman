using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer.Visitor
{
    public class Monitor : CustomPicture
    {
        public List<CustomPicture> _pictures { get; set; }
        public Monitor(PictureBox explosionPicture, PictureBox playerPicture, PictureBox bombPicture) : base(null)
        {
            _pictures = new List<CustomPicture>();
            _pictures.Add(new ExplosionPicture(explosionPicture));
            _pictures.Add(new PlayerPicture(playerPicture));
            _pictures.Add(new BombPicture(bombPicture));
        }

        public override void RespondToVisit(IVisitor visitor)
        {
            foreach(var customPicture in _pictures)
            {
                customPicture.RespondToVisit(visitor);
            }
        }
    }
}
