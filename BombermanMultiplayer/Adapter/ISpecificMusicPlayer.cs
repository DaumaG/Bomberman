using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Adapter
{
    public interface ISpecificMusicPlayer
    {
        void PlayWav(string fileName);
        void PlayMp4(string fileName);
    }
}
