﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    { 
        List<ProductItem> GetAllProducts();
        int InsertProductItem(ProductItem productItem);
        void UpdateProductItem(int id);
        void DeleteProductItem(int id);
    }
}
