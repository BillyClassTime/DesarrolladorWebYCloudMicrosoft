using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutesExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id = 50)
        {
            //eturn View();
            return Content($"Este es el valor del parametro por defecto del controlador Home:{id}");
        }
        [Route("Hello/{firstName}/{LastName}")]
        public IActionResult Greeting(string firstName, string LastName)
        {
            return Content($"Hello {firstName} {LastName} Desde modulo 4 demo 2");
        }
    }
}
