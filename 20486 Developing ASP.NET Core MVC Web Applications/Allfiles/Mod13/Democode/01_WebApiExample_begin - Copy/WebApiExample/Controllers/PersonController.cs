using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiExample.Models;
using System.Text.Json;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]/[action]")] // El action es colocado si 
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> _people = new List<Person>();
        public PersonController()
        {
            _people.Add(new Person() { Id = 1, FirstName = "James", LastName = "Sprayberry" });
            _people.Add(new Person() { Id = 2, FirstName = "Jason", LastName = "Mosley" });
            _people.Add(new Person() { Id = 3, FirstName = "Jennifer", LastName = "Dietz" });
            _people.Add(new Person() { Id = 4, FirstName = "Bessie", LastName = "Duppstadt" });
        }

        [AcceptVerbs("Get","Head")]
        [Produces("application/json")]
        [ActionName("")] // Se coloca en blanco
        public List<Person> GetAll()
        {
            return _people;
        }

        [HttpGet()]
        [ActionName("GetXml")]
        [Produces("application/xml")]
        public List<Person> Get()
        {
            return _people;
        }

       [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            //var json = JsonSerializer.Serialize(person); Para el IActionResult
            if (person == null)
                return NotFound();
            else
                return person;
        }

        /*[HttpGet("{id}")]
        public Person GetPersonById(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id);
            //var json = JsonSerializer.Serialize(person);
            if (person == null)
                return new Person() { Id = 0, FirstName="", LastName="" };
            else
                return person;
        }*/
    }
}
