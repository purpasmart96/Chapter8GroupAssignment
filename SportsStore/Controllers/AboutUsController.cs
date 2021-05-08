using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SportsStore.Controllers
{
    [Route("[action]/[controller]")]
    public class AboutUsController : Controller
    {
        //[Route("/About")]
        public IActionResult About()
        {
            return View("About");
        }
    }
}
