using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace PizzaDelivery.Server.Model
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get;set; }
        public int user_id { get; set; }
        public decimal total_amount { get; set; }
        public DateTime order_date { get; set; }
        public string status { get; set; }
        public List<Order_Items> items { get; set; }
        



    }
}
