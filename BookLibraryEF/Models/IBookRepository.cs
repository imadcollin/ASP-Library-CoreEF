using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreLibraryEF.wwwroot.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> MustCommon { get; }
        Book GetBookById(int id);
        Book GetBookByTitle(string title);

    }
}
