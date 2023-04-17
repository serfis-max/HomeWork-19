using Microsoft.AspNetCore.Mvc;
using System;
using HW_192.Data;

namespace HW_192.Controllers
{
    public class MyDefaultController : Controller
    {
        private Repository r = new Repository();

        public IActionResult Index()
        {
            return View(r.Users);
        }

        public IActionResult UsersInfo(int id)
        {
            return View(r.Users[id - 1]);
        }

        [HttpPost]
        public void Update(object obj)
        {
            Console.WriteLine($"{obj}");
        }
    }
}