using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using julekalenderApi.Models;
using julekalenderApi.Data;

namespace julekalenderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnowledgesController : ControllerBase
    {
        private readonly JuleKalenderApiContext _context;
        public KnowledgesController(JuleKalenderApiContext context)
        {
            _context = context;
        }

        // GET api/values (Knowledges)
        [HttpGet]
        public ActionResult<IEnumerable<Knowledge>> Get()
        {
            return _context.Knowledges.ToList();
        }

        // GET api/values(Knowledges)/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values (Knowledges)
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values (Knowledges)/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values (Knowledges)/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
