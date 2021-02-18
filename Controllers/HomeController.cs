
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using freshs.Models;

namespace freshs.Controllers
{

    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("results")]
        public IActionResult Result(string Name, string Locations, string Languages, string Comments){
            Models.Form info = new Models.Form(Name,Locations,Languages,Comments);
            TryValidateModel(info);

            if (ModelState.IsValid)
            {
                return View("results",info);
            }
            else
            {
                return View("index");
            }
        }
    }
}