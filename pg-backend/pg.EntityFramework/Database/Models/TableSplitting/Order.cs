namespace pg.EntityFramework.Database.Models.TableSplitting
{
    public class Order
    {
        public int Id { get; set; }

        public OrderStatus? Status { get; set; }

        public DetailedOrder DetailedOrder { get; set; }
    }
}