using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Adapter
{
    public interface IMusicPlayer
    {
        void Play(string audioType, string fileName);
    }
}
