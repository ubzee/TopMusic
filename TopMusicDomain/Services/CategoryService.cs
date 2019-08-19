using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMusicDomain.Services
{
    public class CategoryService
    {

        public static int CreateCategory(string name, string description)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var category = new Category
                {
                    Name = name,
                    Description = description,
                    Status = 0,
                    Image = "Evolution à Venir"
                };
                db.Category.Add(category);
                db.SaveChanges();
                return category.Category_ID;
            }
        }

        public static Category GetCategory(int Category_ID)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                return db.Category.Find(Category_ID);
            }
        }

        public static int EditCategory(int category_id, string name, string description, int visibility)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var category = db.Category.Find(category_id);
                category.Name = name;
                category.Description = description;
                category.Status = visibility;

                return db.SaveChanges();
            }
        }

        public static int DeleteCategory(int category_id)
        {
            using (TopMusicEntities db = new TopMusicEntities())
            {
                var category = db.Category.Find(category_id);
                db.Album.RemoveRange(category.Album);
                db.Category.Remove(category);
                return db.SaveChanges();
            }
        }

        //public static List<Category> GetListCategories()
        //{
        //    List<Category> categories = null;
        //    using (TopMusicEntities db = new TopMusicEntities())
        //    {
        //        categories = db.Category.ToList();
        //    }
        //    return categories;
        //}

        public static IEnumerable<Category> GetCategories()
        {
            List<Category> categories = null;
            using (TopMusicEntities db = new TopMusicEntities())
            {
                categories = db.Category.ToList();
            }
            return categories;
        }

    }
}
