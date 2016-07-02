using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace kendo_aspnet_core.Controllers
{
    public class SalesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
