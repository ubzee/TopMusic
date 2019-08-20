using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMusicDomain.Services
{
    public class RankingService
    {
        //public static void RemoveVote(int id, string userID)
        //{
        //    using (TopMusicEntities db = new TopMusicEntities())
        //    {
        //        var album = db.Album.Find(id);
        //        var user = db.AspNetUsers.Find(userID);
        //        if (album != null && user != null)
        //        {
        //            album.AspNetUsers.Remove(user);
        //            db.SaveChanges();
        //        }
        //    }
        //}

        //public static int GetNumberVotesForUser(int categoryID, string userID)
        //{
        //    using (TopMusicEntities db = new TopMusicEntities())
        //    {
        //        return db.Album.Count(a => a.CategoryID == categoryID && a.AspNetUsers.Any(u => u.Id == userID));
        //    }
        //}

        public static bool Vote(int album_id, string userID)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var album = db.Album.Find(album_id);
                var user = db.AspNetUsers.Find(userID);
                if (album != null && user != null)
                {
                    album.AspNetUsers.Add(user);
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}
