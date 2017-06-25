using AspCoreLibraryEF.wwwroot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryEF.Models
{
    public class BookRepoDbcontext :IBookRepository
    {
        private readonly DBContext _appContext;
        public BookRepoDbcontext(DBContext appContext) {
            _appContext = appContext;
        }

        public IEnumerable<Book> Books => throw new NotImplementedException();

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
