using System.ComponentModel.DataAnnotations;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public string Writer { get; set; }

        //(bir blogda birden çok yorum olabilir) bu bire çok ilişkiyi sağlamak için:
        public ICollection<Comment> Comments { get; set; }  // Blog ile Comment arasında bire çok ilişki kurmak için ICollection kullanıyoruz.
    }
}
