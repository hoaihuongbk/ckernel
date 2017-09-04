using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CTool.NetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["tableList"] = new List<SelectListItem>();
            ViewData["viewList"] = new List<SelectListItem>();
            ViewData["spList"] = new List<SelectListItem>();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
