using BombermanMultiplayer.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Facade
{
    public class WavSound : ISound
    {
        public void PlayMusic()
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("wav", "music.wav");
        }
    }
}
