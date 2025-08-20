using Eterna_FrontoBack.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_FrontoBack.Controllers
{
    public class HomeController(EternaDbContext eternaDbContext) : Controller
    {
        public IActionResult Index()
        {
            var sliders = eternaDbContext.Sliders.ToList();
            return View(sliders);
        }
    }
}
