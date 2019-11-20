using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Facade
{
    public class MusicMaker
    {
        private ISound _mp3Sound { get; set; }
        private ISound _mp4Sound { get; set; }
        private ISound _wavSound { get; set; }

        public MusicMaker()
        {
            _mp3Sound = new Mp3Sound();
            _mp4Sound = new Mp4Sound();
            _wavSound = new WavSound();
        }

        public void PlayMp3()
        {
            _mp3Sound.PlayMusic();
        }
        public void PlayMp4()
        {
            _mp4Sound.PlayMusic();
        }
        public void PlayWav()
        {
            _wavSound.PlayMusic();
        }
    }
}
