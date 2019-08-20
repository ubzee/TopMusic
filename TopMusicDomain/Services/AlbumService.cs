using DataModel;
using MusicBrainzServiceAgent;
using MusicBrainzServiceAgent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicDomain.Entities;

namespace TopMusicDomain.Services
{
    public class AlbumService
    {
        public static List<Album> GetAlbumsByCategory(int category_id)
        {
            List<Album> albums = null;
            using (TopMusicEntities db = new TopMusicEntities())
            {
                albums = db.Album.Where(a => a.Category_ID == category_id).ToList();
            }
            return albums;
        }

        public static bool DeleteAlbum (int album_id)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var album = db.Album.Find(album_id);
                db.Album.Remove(album);
                db.SaveChanges();
            }
            return true;
        }

        public static List<MBAlbum> MBSearch(string search, string searchBy)
        {
            List<MBAlbum> albums = new List<MBAlbum>();
            List<ReleaseGroup> MBResult;
            if(searchBy == "Artist")
            {
                MBResult = ServiceAgent.SearchAlbumsByArtist(search);
            }
            else
            {
                MBResult = ServiceAgent.SearchAlbums(search);
            }

            foreach(var item in MBResult)
            {
                albums.Add(new MBAlbum()
                {
                    MusicBrainz_ID = item.Id,
                    Title = item.Title,
                    ArtistName = item.ArtistCredit.FirstOrDefault()?.Artist?.Name

                });
            }
            return albums;
           
        }

        public static bool AddAlbum(int category_id, string musicbrainz_ID, string Title, string ArtistName)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var album = new Album
                {
                    MusicBrainz_ID = musicbrainz_ID,
                    Title = Title,
                    Category_ID = category_id,
                    ArtistName = ArtistName
                };
                db.Album.Add(album);
                db.SaveChanges();
            }
            return true;
        }

        //public static List<Album> GetAlbumsForVotableCategory(string user_id, int category_id)
        //{
        //    List<Album> albums = new List<Album>();

        //    using (TopMusicEntities db = new TopMusicEntities())
        //    {
        //        albums = db.Album
        //                .Where (x => x.Category_ID == category_id && )
        //    }
        //}
    }


}
