﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SukisPieShop.Core.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Pie> Pies { get; set; }
    }
}