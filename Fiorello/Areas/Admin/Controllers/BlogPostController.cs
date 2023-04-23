using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Areas.Admin.Controllers
{
    public class BlogPostController : Controller
    {
        public async Task<IActionResult> Index()
        {


            return View();
        }
    }
}