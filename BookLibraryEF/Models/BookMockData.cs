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
            new Book { ID = 1, Title = "Sun Rise", Discription = "When the sun rise", Price = 240, ImageUrl = "http://www.drastudio.com/file/coda_books/py.png", PublishDate = new DateTime(1981, 03, 01), InStock = true, CategoryId = 1, Category= _ICategory.Categories.ToList()[0] },
            new Book { ID = 2, Title = "Englis test", Discription = "Engilsh is for everyone", Price = 500, ImageUrl = "http://c711100.r0.cf2.rackcdn.com/Grasp_The_Solution.jpg", PublishDate = new DateTime(1984, 03, 01), InStock = true, CategoryId = 3, Category= _ICategory.Categories.ToList()[1] },
            new Book { ID = 3, Title = "Python ED", Discription = "Python now ready to go", Price = 340, ImageUrl = "https://s3.amazonaws.com/pickfu-media/options/53484/5259db6ff4eca1fffe49cefe81f28f2243a2fc1b.jpg?1451615664", PublishDate = new DateTime(1981, 03, 01), InStock = true, CategoryId = 1, Category= _ICategory.Categories.ToList()[0] },
            new Book { ID = 4, Title = "Dock pipe", Discription = "When the sun set", Price = 500, ImageUrl = "http://d1by67ljd45m4v.cloudfront.net/media/EAA7309C-ADEF-FE93-9C53F2AEF5AF8AC9.jpg", PublishDate = new DateTime(1984, 03, 01), InStock = true, CategoryId = 3, Category= _ICategory.Categories.ToList()[1] },
            new Book { ID = 5, Title = "Testable code", Discription = "Become senior in one day", Price = 600, ImageUrl = "http://www.personalbrandingblog.com/wp-content/uploads/2010/05/books-drive-success-big-194x300.jpg", PublishDate = new DateTime(1985, 03, 01), InStock = true, CategoryId = 1, Category= _ICategory.Categories.ToList()[0] },
            new Book { ID = 6, Title = "Sun Set", Discription = "When the sun set", Price = 500, ImageUrl = "http://stage.bookcountry.com/uploadedImages/Book_Country/Read_and_Review/Books/Genre_Map/Young_Adult/Young_Adult_Contemporary/Young_Adult_Contemporary_Book_The_Fault_in_Our_Stars.jpg", PublishDate = new DateTime(1984, 03, 01), InStock = true, CategoryId = 3, Category= _ICategory.Categories.ToList()[1] }

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
