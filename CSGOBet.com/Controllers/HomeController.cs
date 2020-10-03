using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CSGOBet.com.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment environment;
        public HomeController(IWebHostEnvironment env)
        {
            environment = env;
        }
        public IActionResult Index()
        {
            return File(new FileStream(environment.WebRootPath + "/app/public/index.html", FileMode.Open), "text/html; charset=utf8");
        }
    }
}
