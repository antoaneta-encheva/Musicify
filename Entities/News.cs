﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace izpit.Entities
{
    public class News : BaseEntity
    {
       
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

    }
}
