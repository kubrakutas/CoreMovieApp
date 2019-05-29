using CoreMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMovieApp.Data
{
    public class CategoryRepository
    {
        public static List<Category> categories = null;

        static CategoryRepository()
        {
            categories = new List<Category>() {
                new Category(){Id=1,Name="Discovery"},
                new Category(){Id=2,Name="Fantastik"},
                new Category(){Id=3,Name="Savaş"},
                new Category(){Id=4,Name="Romantik"},
                new Category(){Id=5,Name="Komedi"}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return categories;
            }
        }

        public static void AddMovie(Category category)
        {
            categories.Add(category);
        }

        public static Category GetByID(int Id)
        {
            return categories.FirstOrDefault(x => x.Id == Id);
        }
    }
}
