using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VuetAPI.Models;
using Microsoft.AspNetCore.Mvc.Formatters.Json;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

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
            return new JsonResult(ValueRepository.values);
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Element(int id)
        {
            return new JsonResult(valueRepository.Item(id));
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
