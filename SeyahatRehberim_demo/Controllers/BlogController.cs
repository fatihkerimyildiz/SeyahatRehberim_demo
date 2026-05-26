using Microsoft.AspNetCore.Mvc;
using SeyahatRehberim_demo.Models.Classes;

namespace SeyahatRehberim_demo.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogComment blogComment = new BlogComment();

        public IActionResult Index()
        {
            //var values = context.Blogs.ToList();
            blogComment.Value1 = context.Blogs.ToList();
            blogComment.Value2 = context.Comments.ToList();
            blogComment.Value3 = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogComment);
        }
        public IActionResult BlogDetails(int id)      // blog kısımlarını aynı yedikıta gibi bir iki günlük gezi turu anlatılan şekilde yapmak
        {

            //var findBlogByBlogId = context.Blogs.Where(x => x.ID == id).ToList();
            blogComment.Value1 = context.Blogs.Where(x => x.ID == id).ToList(); 
            blogComment.Value2 = context.Comments.Where(x => x.Blogid == id).ToList();    // sadece o bloga ait yorumlar
            blogComment.Value3 = context.Blogs.ToList();
            return View(blogComment);
        }
    }
}
