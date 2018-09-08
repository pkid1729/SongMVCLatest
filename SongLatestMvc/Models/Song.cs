using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongLatestMvc.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string SongType { get; set; }
        public string SingerName { get; set; }
    }
}
