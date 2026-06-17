using Microsoft.AspNetCore.Mvc;
using SeyahatRehberim_demo.Models.Classes;

namespace SeyahatRehberim_demo.Controllers
{
    public class DestinationController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var values = context.Destinations.ToList();
            return View(values);
        }
        public IActionResult DestinationDetails(int id)
        {
            var values = context.Destinations.FirstOrDefault(x => x.ID == id);
            if (values == null)
            {
                return NotFound();
            }
            return View(values);
        }
    }
}
