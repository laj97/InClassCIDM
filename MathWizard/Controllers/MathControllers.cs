using Microsoft.AspNetCore.Mvc;
using System;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int left, int right)
        {

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sum = leftop + rightop;

            if (rightop == 0)
            {
                //string path = @"C:\Temp\files";
                ViewData["Message"] = @"You can't divide by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} plus {right} equals {sum}";
            }

            return View();
        }

        public IActionResult Subtract(double left, double right)
        {

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sum = leftop - rightop;

            if (rightop == 0)
            {
                //string path = @"C:\Temp\files";
                ViewData["Message"] = @"You can't divide by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} plus {right} equals {sum}";
            }

            return View();
        }
        public IActionResult Test()
        {
            return View();
        }

    }
}