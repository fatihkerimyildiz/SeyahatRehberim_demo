using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class Destination
    {
        [Key]
        public int ID { get; set; }
        public string DestName { get; set; }
        public string DestImage { get; set; }
        public double DestCost { get; set; }
        public string DestDescription { get; set; }
        public string DestUrl { get; set; }
        public string DestFlight { get; set; }
    }
}
