using System.ComponentModel.DataAnnotations;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
