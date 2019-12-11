using System.Collections.Generic;
using System.Linq;

namespace pg.EntityFramework.Database.Models.TableSplitting
{
    public class OrderService
    {
        private readonly OrdersContext db;

        public OrderService(OrdersContext db)
        {
            this.db = db;
        }

        public void Add(Order order)
        {
            db.Add(order);
            db.SaveChanges();
        }

        public Order Get(int id)
        {
            var order = db.Orders.SingleOrDefault(o => o.Id == id);
            return order;
        }

        public IEnumerable<Order> Get()
        {
            var orders = db.Orders.ToList();
            return orders;
        }
    }
}