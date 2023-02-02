using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        List<OrderItem> GetAllOrder();
        int InsertOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(int id);
    }
}
