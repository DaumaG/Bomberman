using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace BombermanMultiplayer.Adapter
{
    public class AudioPlayer : IMusicPlayer
    {
        MusicAdapter musicAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                string currentDir = Environment.CurrentDirectory;
                DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\Adapter\Music\" + fileName)));

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                wplayer.URL = directory.ToString();
                wplayer.controls.play();
            }
            else if (audioType.Equals("wav", StringComparison.InvariantCultureIgnoreCase) || audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                musicAdapter = new MusicAdapter(audioType);
                musicAdapter.Play(audioType, fileName);
            }
        }
    }
}
