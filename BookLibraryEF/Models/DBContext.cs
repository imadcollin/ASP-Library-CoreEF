using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryEF.Models
{
    public class DBContext: DbContext
    {
        
            public DBContext(DbContextOptions<DBContext> options)
                : base(options)
            { }
        public DbSet<AspCoreLibraryEF.wwwroot.Models.Category> Categories { set; get; }
        public DbSet<AspCoreLibraryEF.wwwroot.Models.Book> Books { set; get; }

    }
}
