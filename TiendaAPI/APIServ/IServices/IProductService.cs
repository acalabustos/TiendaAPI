using Entities.Entities;

namespace APIServ.IServices
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);
        void DeleteProduct(int id);
        void UpdatePrduct(int id);
       
    }
}
