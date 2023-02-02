
using Entities.Entities;

namespace APIServ.IServices
{
    public interface IBrandService
    {
        List<BrandItem> GetAllBrand();
        int InsertBrand(BrandItem brandItem);
        int UpdateBrand(int id);
        int DeleteBrand(int id);

    }
}
