using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SportsStore.Controllers
{
    public class TestController : Controller
    {
        public JsonResult Index()
        {
            //var data = System.IO.File.ReadAllText("people.json");
            var new_data = JsonConvert.DeserializeObject(System.IO.File.ReadAllText("people.json"));
            return Json(new_data);
        }
    }
}