using LibraryTravel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryTravel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly TravelContext _context;

        public ValuesController(TravelContext context)
        {
            _context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Libros> Get()
        {
            IEnumerable<Libros> libros = _context.Libros
                                                 .Include(x=> x.Editoriales);
            
            return libros;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Libros Get(int id)
        {
            Libros libros = _context.Libros.Where(x=> x.Isbn == id).FirstOrDefault();
            return libros;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
