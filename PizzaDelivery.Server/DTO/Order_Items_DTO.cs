namespace PizzaDelivery.Server.DTO
{
    public class Order_Items_DTO
    {
        public int order_id { get; set; }
        public int quantity { get; set; }
        public string payment_status { get; set; }
        public decimal total_amount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
