using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMusicApplication.ViewModels
{
    public class VoteViewModel
    {
        //public CategoryViewModel Category { get; set; }
        public List<DataModel.Album> Albums { get; set; }
        public string MusicBrainzID { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }


    }
}
