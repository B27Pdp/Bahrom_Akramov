using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_10_January_28_2023.HomeTasks
{
    internal static class MediaPlayer
    {
        public static void playMusic(string filePath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filePath;
            musicPlayer.Play();
        }
    }
}
