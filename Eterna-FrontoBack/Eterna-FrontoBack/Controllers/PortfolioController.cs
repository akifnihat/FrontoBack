using Eterna_FrontoBack.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_FrontoBack.Controllers
{
    public class PortfolioController(EternaDbContext eternaDbContext) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
