using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WoWJunkyard.Controllers
{
    public class WoWHeadNewsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }
    }
}