﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
