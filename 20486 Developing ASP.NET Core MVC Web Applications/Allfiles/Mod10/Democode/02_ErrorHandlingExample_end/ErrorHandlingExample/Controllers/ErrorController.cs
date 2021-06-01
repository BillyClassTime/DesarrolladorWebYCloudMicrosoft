using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorHandlingExample.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Http(int? statusCode)
        {
            string errorMessage = default;
            if (statusCode == null)
                errorMessage = "501 Internal Server";
            else
            {
                errorMessage = $"{statusCode} Message";
            }
            ViewBag.ErrorMessage = errorMessage;
            return View();
        }
    }
}
