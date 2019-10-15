using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Adapter
{
    class MusicAdapter : IMusicPlayer
    {
        ISpecificMusicPlayer IspecificMusicPlayer;

        public MusicAdapter(string audioType)
        {
            if (audioType.Equals("wav", StringComparison.InvariantCultureIgnoreCase)) 
            {
                IspecificMusicPlayer = new WavPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                IspecificMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("wav", StringComparison.InvariantCultureIgnoreCase))
            {
                IspecificMusicPlayer.PlayWav(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                IspecificMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
