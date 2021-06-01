using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Models;
using System.Text.Json;
namespace WebApiExample.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("GetId/{id}")]
        public string GetId(int id)
        {
            return "Input number is: " + id;
        }
        
        private List<Person> _people = new List<Person>();

        public PersonController()
        {
            _people.Add(new Person() { Id = 1, FirstName = "James", LastName = "Sprayberry" });
            _people.Add(new Person() { Id = 2, FirstName = "Jason", LastName = "Mosley" });
            _people.Add(new Person() { Id = 3, FirstName = "Jennifer", LastName = "Dietz" });
            _people.Add(new Person() { Id = 4, FirstName = "Bessie", LastName = "Duppstadt" });
        }

        [HttpGet("GetAllJson")]
        //[HttpGet]
        public List<Person> GetAllJson()
        {
            return _people;
        }

        [HttpGet("GetAll")]
        [Produces("application/xml")]
        public List<Person> GetAll()
        {
            return _people;
        }

        [HttpGet("GetPById/{id}")]
        [HttpPost("GetPById/{id}")]
        public IActionResult GetPById(int id)
        {
            string json = default;
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person != null)
                json = JsonSerializer.Serialize(person);
            else
                json = "{\"Id\":"+id+", \"FirstName\":\"NOT FOUND\"}";
            return Ok(json);
            //return Content(json);
        }

        [HttpGet("GetPersonByIDJson/{id}")]
        [Produces("application/json")]
        public ActionResult<Person> GetPersonByIDJson(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person == null)
                return NotFound();
            return person;
        }

        [HttpGet("GetPersonByIDXml/{id}")]
        [Produces("application/xml")]
        public ActionResult<Person> GetPersonByIDXml(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            if (person == null)
                return NotFound();
            return person;
        }

    }
}
