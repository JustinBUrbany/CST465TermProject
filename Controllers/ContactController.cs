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
        public IActionResult Index(ContactModel contact)
        {
            return View(contact);
        }



        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            return View(contact);
        }
    }
}