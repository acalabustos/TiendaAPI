﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem(String name, String typeProduct)
        {
            IsActive = true;
            IsPublic = true;
            Name = name;
            TypeProduct = typeProduct;
        }
        public int Id { get; set; }
        public int IdSuplier { get; set; }
        public int IdBrand { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string TypeProduct { get; set; }
        public bool IsActive { get; private set; }
        public bool IsPublic { get; private set; }
    }
}
