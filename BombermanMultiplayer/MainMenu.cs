using BombermanMultiplayer.Adapter;
using BombermanMultiplayer.Facade;
using BombermanMultiplayer.Visitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer
{
    public partial class MainMenu : Form
    {
        private MusicMaker _musicMaker { get; set; }
        private IVisitor _visibilitiesVisitor { get; set; }
        private IVisitor _backgroundVisitor { get; set; }
        private IVisitor _imageLoadVisitor { get; set; }
        private Monitor _monitor { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            _musicMaker = new MusicMaker();

            #region Visitor

            _visibilitiesVisitor = new VisibilitiesVisitor();
            _backgroundVisitor = new BackgroundVisitor();
            _imageLoadVisitor = new ImageLoadVisitor();

            _monitor = new Monitor(ExplosionPictureBox, BombermanPictureBox, BombPictureBox);
            _monitor.RespondToVisit(_imageLoadVisitor);
            _monitor.RespondToVisit(_backgroundVisitor);
            _monitor.RespondToVisit(_visibilitiesVisitor);

            #endregion
        }

        private void btnLocalGame_Click(object sender, EventArgs e)
        {
            using (GameWindow f = new GameWindow())
            {
                f.ShowDialog();
            }
        }

        private void btnLanMode_Click(object sender, EventArgs e)
        {
            using (Lobby f = new Lobby())
            {
                f.ShowDialog();
            }
        }

        private void button_mp4_Click(object sender, EventArgs e)
        {
            _musicMaker.PlayMp4();
        }

        private void button_wav_Click(object sender, EventArgs e)
        {
            _musicMaker.PlayWav();
        }

        private void button_mp3_Click(object sender, EventArgs e)
        {
            _musicMaker.PlayMp3();
        }
    }
}
