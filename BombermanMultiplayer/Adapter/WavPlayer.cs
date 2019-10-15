using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace BombermanMultiplayer.Adapter
{
    
    public class WavPlayer : ISpecificMusicPlayer
    {
        public void PlayMp4(string fileName)
        {
        }

        public void PlayWav(string fileName)
        {
            SoundPlayer player = new SoundPlayer();
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\Adapter\Music\" + fileName)));
            player.SoundLocation = directory.ToString();
            player.Play();
        }
    }
}
