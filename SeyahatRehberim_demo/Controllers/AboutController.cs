using Microsoft.AspNetCore.Mvc;
using SeyahatRehberim_demo.Models.Classes;

namespace SeyahatRehberim_demo.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}
