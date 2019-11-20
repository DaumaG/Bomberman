using BombermanMultiplayer.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Facade
{
    public class Mp4Sound : ISound
    {
        public void PlayMusic()
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp4", "music.mp4");
        }
    }
}
