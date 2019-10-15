using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace BombermanMultiplayer.Adapter
{
    public class Mp4Player : ISpecificMusicPlayer
    {
        public void PlayMp4(string fileName)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\Adapter\Music\" + fileName)));

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = directory.ToString();
            wplayer.controls.play();
        }

        public void PlayWav(string fileName)
        {
        }
    }
}
