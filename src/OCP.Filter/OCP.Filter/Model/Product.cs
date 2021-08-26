﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.Filter.Model
{
    class Product
    {
        public Product(ProductColor color)
        {
            this.Color = color;
        }

        public Product(ProductColor color, ProductSize size)
        {
            this.Color = color;
            this.Size = size;
        }

        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; } 
    }
}
