using FioRolle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FioRolle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        
    }
}
