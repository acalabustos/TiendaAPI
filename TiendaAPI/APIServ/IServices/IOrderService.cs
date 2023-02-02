using Entities.Entities;

namespace APIServ.IServices
{
    public class IOrderService
    {
        List<OrderItem> GetAllOrder();
        int InsertOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(int id);
    }
}
