namespace pg.EntityFramework.Database.Models.TableSplitting
{
    public class DetailedOrder
    {
        public int Id { get; set; }

        public OrderStatus? Status { get; set; }

        public string BillingAddress { get; set; }

        public string ShippingAddress { get; set; }
    }
}