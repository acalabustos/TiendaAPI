using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBrandLogic
    {
        int InsertBrandItem(BrandItem brandItem);
        List<BrandItem> GetAllBrand();
        void UpdateBrandItem(BrandItem brandItem);
        void DeleteBrandItem(int id);
    }
}
