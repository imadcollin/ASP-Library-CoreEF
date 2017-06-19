using AspCoreLibraryEF.wwwroot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreLibraryEF.Models
{
    public class CategoryMockData : ICategoryRepo
    {
        public IEnumerable<Category> Categories =>
            
        new List<Category>  {
                     new Category{CategoryId=1, CategoryName="Fiction", Discription="This Category contain some data"},
                     new Category{CategoryId=2, CategoryName="Drama", Discription="This Category contain drama "},
                     new Category{CategoryId=3, CategoryName="Poet", Discription="This Category contain Potry"}

        };
    }
}
