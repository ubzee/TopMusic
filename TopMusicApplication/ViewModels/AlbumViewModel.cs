using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicDomain.Entities;

namespace TopMusicApplication.ViewModels
{
    public class AlbumViewModel
    {
        public List<DataModel.Album> Albums { get; set; }
        public List<MBAlbum> MBAlbums { get; set; }
        public int Category_ID { get; set; }

        public string Search { get; set; }
        public string SearchBy { get; set; }

        public string MusicBrainzID { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }


    }
}
