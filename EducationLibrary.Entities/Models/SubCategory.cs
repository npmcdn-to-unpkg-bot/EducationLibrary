﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationLibrary.Entities.Entities
{
    public class SubCategory
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }

    }
}
