using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        /***
         * Entry Page Action
         **/

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(int num)
        {
            return RedirectToAction("SpinIt", new { luck = 3 });
        }

        /***
         * Spin Action
         **/  
               
        Random random = new Random() ; 

        public IActionResult SpinIt(int luck)
        {
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            Spin mySpin = new Spin(); 
            mySpin.Luck = luck;

            if (a == mySpin.Luck || b == mySpin.Luck || c == mySpin.Luck)
                mySpin.Display = "block";
            else
                mySpin.Display = "none";

            mySpin.A = a;
            mySpin.B = b;
            mySpin.C = c;

            return View(mySpin);
        }
    }
}

