using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIServ.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandLogic _brandLogic;
        public BrandService(IBrandLogic brandLogic)
        {
            _brandLogic = brandLogic;
        }
        public int InsertBrand(BrandItem brandItem)
        {
            _brandLogic.InsertBrandItem(brandItem);
            return brandItem.Id;
        }
    }
}