using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_MVC.Controllers
{
    public class ReferancesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
