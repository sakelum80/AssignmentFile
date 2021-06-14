﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDataModel
{
    public class Item
    {
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }        
    }
}
