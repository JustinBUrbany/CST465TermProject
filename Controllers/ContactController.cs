using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPTermProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPTermProject.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            return Create(model);
        }
        public IActionResult Create(ContactModel contact)
        {
            return View("Create",contact);
        }
    }
}