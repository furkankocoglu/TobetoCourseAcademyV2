﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:Entity<Guid>
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
