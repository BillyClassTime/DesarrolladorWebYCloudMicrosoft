﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutesExample.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult MultByTwo(int num)
        {
            //return View();
            int result = num * 2;
            return Content(result.ToString());
        }
        [Route("Calc/Mult/{num1:int}/{num2:int}")]
        public IActionResult Mult(int num1, int num2)
        {
            int result = num1 * num2;
            return Content(result.ToString());
        }
        [HttpGet("Calc/Divide/{param?}")]
        public IActionResult DivideByTen(int param)
        {
            int result = param / 10;
            return Content(result.ToString());
        }
    }
}
