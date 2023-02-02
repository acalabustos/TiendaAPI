
using Entities.Entities;

namespace APIServ.IServices
{
    public interface IBrandService
    {
        List<BrandItem> GetAllBrand();
        int InsertBrand(BrandItem brandItem);
        void UpdateBrand(int id);
        void DeleteBrand(int id);

    }
}
