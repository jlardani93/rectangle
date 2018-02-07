using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RectangleProject.Models;

namespace RectangleProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
