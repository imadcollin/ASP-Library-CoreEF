﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreLibraryEF.wwwroot.Models
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> Categories { get; }
    }
}
