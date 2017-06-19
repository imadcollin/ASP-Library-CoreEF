using AspCoreLibraryEF.wwwroot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreLibraryEF.Models
{
   

    public class BookMockData : IBookRepository
    {
        private ICategoryRepo _ICategory = new CategoryMockData();
        public IEnumerable<Book> Books =>
            new List<Book> {
            new Book { ID = 1, Title = "Sun Rise", Discription = "When the sun rise", Price = 240, ImageUrl = "", PublishDate = new DateTime(1981, 03, 01), InStock = true, CategoryId = 1, Category= _ICategory.Categories.ToList()[0] },
            new Book { ID = 2, Title = "Sun Set", Discription = "When the sun set", Price = 500, ImageUrl = "", PublishDate = new DateTime(1984, 03, 01), InStock = true, CategoryId = 3, Category= _ICategory.Categories.ToList()[1] }
        };

        public IEnumerable<Book> MustCommon => throw new NotImplementedException();

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
