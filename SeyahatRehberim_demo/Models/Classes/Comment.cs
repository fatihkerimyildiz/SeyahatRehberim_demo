using System.ComponentModel.DataAnnotations;

namespace SeyahatRehberim_demo.Models.Classes
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CommentText { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }     // Yorumun hangi bloga ait olduğunu belirtmek için BlogID ekledik (ilişkili tablo)
    }
}
