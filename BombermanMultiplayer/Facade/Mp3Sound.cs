using BombermanMultiplayer.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Facade
{
    public class Mp3Sound : ISound
    {
        public void PlayMusic()
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "music.mp3");
        }
    }
}
