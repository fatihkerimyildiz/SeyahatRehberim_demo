using System.ComponentModel.DataAnnotations;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
