using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;
using TopMusicDomain.Services;

namespace TopMusicApplication.Services
{
    public class AlbumServiceController
    {
        //get category pour populer Edit view
        public AlbumViewModel GetAlbumsViewModel(int category_id)
        {
            var viewModel = new AlbumViewModel()
            {
                Albums = AlbumService.GetAlbumsByCategory(category_id),
                Category_ID = category_id
            };
            return viewModel;
        }

        //Delete Album
        public bool DeleteAlbum(int album_id)
        {
            return AlbumService.DeleteAlbum(album_id);
        }

        //Search Music Brianz
        public AlbumViewModel AlbumMBSearch(AlbumViewModel searchModel, int category_id)
        {
            var viewModel = GetAlbumsViewModel(category_id);
            viewModel.Search = searchModel.Search;
            viewModel.SearchBy = searchModel.SearchBy;
            viewModel.MBAlbums = AlbumService.MBSearch(searchModel.Search, searchModel.SearchBy);
         
            return viewModel;
        }

        //Add Album to Category
        public bool AddAlbum(int category_id, string MusicBrainz_ID, string Title, string ArtistName)
        {
            return AlbumService.AddAlbum(category_id, MusicBrainz_ID, Title, ArtistName);
        }
    }
}
