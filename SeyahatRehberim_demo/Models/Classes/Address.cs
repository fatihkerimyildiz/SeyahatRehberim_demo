using System.ComponentModel.DataAnnotations;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FullAddress { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}
