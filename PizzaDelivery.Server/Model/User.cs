using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaDelivery.Server.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int user_id { get; set; }
        public string user_name { get; set; }
        public string email { get; set;}
        public string password { get; set;}

    }
}
