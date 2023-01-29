using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BrandLogic : BaseContextLogic, IBrandLogic
    {
        public BrandLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertBrandItem(BrandItem brandItem)
        {
            _serviceContext.Brand.Add(brandItem);
            _serviceContext.SaveChanges();
        }
    }
}
