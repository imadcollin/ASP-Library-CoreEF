using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreLibraryEF.wwwroot.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PublishDate { get; set; }
       
        public bool InStock { get; set; }

        public int CategoryId  { get; set; }

        public virtual Category Category { get; set; }

    }
}
