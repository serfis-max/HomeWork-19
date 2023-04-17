using Microsoft.AspNetCore.Mvc;
using System;
using HW_191.Data;

namespace HW_191.Controllers
{
    public class MyDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View(new Repository().Users);
        }
    }
}