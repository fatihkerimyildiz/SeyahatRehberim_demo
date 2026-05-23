using Microsoft.AspNetCore.Mvc;
using SeyahatRehberim_demo.Models.Classes;
namespace SeyahatRehberim_demo.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();  
        public IActionResult Index()
        {
            var values1  = c.Blogs.ToList();
            var values2 = c.Destinations.ToList();
            HomePageViewModel model = new HomePageViewModel
            {
                Blogs = values1,
                Destinations = values2
            };
            return View(model);
        }
        public ActionResult About()
        {
            return View();
        }
        
    }
}
