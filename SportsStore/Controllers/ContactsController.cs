using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contacts()
        {
            return View("Contacts");
        }
    }
}