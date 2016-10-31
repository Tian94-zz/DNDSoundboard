using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace DNDSoundboard
{
    public static class Utilities
    {
        public static SoundPlayer SoundPlayer(string Location)
        {
            return new SoundPlayer(Location);
        }

        public static System.Windows.Media.MediaPlayer GetMediaPlayer()
            {
                return new System.Windows.Media.MediaPlayer();
            }

    }
}
