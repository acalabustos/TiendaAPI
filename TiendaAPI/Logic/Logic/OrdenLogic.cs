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
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public List<OrderItem> GetAllOrdes()
        {
            return _serviceContext.Set<OrderItem>().ToList();
        }
        public int InsertOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
            return orderItem.Id;
        }

        public void UpdateOrderItem(int id)
        {
            _serviceContext.SaveChanges();
            //NO SABEMOS SI TENEMOS QUE PONER UN RETURN
        }

        public void DeleteOrderItem(int id)
        {
            var orderToDelete = _serviceContext.Set<OrderItem>()
                 .Where(u => u.Id == id).First();

            orderToDelete.IsActive = false;

            _serviceContext.SaveChanges();

        }
    }
}
