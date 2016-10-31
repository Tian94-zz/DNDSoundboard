using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DNDSoundboard
{
    [Serializable]
    public class YoutubeLink
    {
        public string LinkName { get; set; }
        public string LinkURL { get; set; }

        public YoutubeLink(string Name, string URL)
        {
            LinkName = Name;
            LinkURL = URL;
        }
    }
}
