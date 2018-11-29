using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTermProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTermProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DogSearch(DogModel model)
        {
            return View();
        }
    }
}