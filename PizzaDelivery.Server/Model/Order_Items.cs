using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace PizzaDelivery.Server.Model
{
    public class Order_Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int order_item_id { get; set;}
        public int order_id { get; set;}
        public int pizza_id { get; set;}
        public int quantity { get; set;}
        public decimal price { get; set;}


        /*public int order_item_id { get; set; }
        public int order_id { get; set; }
        public int user_id { get; set; }
        public int pizza_id { get; set; }
        public int quantity { get; set; }
        public string payment_status { get; set; }
        public decimal total_amount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }*/


        



    }
}
