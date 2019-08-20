using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicApplication.ViewModels;
using TopMusicDomain.Services;

namespace TopMusicApplication.Services
{
    public class VoteServiceController
    {
        public VoteViewModel GetVoteViewModel(int category_id)
        {
            var viewModel = new VoteViewModel()
            {
                Albums = AlbumService.GetAlbumsByCategory(category_id)
                //Category = CategoryService.GetCategory(category_id)
            };
            
            return viewModel;
        }

        public bool Vote(int album_id, string userID)
        {
            return RankingService.Vote(album_id, userID);
        }


    }
}
