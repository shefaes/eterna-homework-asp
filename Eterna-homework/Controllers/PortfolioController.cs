using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_homework.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 4;
            return View();
        }
    }
}
