﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Resource
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool MustDelete { get; set; }
    }
}
