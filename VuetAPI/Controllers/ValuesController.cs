using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VuetAPI.Models;

namespace VuetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ValueRepository valueRepository = new ValueRepository();
        
        // GET api/values
        [HttpGet]
        public JsonResult All()
        {
            return new JsonResult(new { Values = ValueRepository.values });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Element(int id)
        {
            return new JsonResult(new { Value = valueRepository.Item(id) });
        }

        [HttpGet("routes")]
        public JsonResult Routes(int id)
        {
            return new JsonResult(
                new object[]
                {
                    new { Route = "/api/values/", Result = All() },
                    new { Route = "/api/values/{id}", Result = Element(1)}
                }
                );
        }

        // POST api/values
        [HttpPost]
        public void Insert([FromBody] Value entity)
        {
            valueRepository.Insert(entity);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            valueRepository.Delete(id);
        }
    }
}
