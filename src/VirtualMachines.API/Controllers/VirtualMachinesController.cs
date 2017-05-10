using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VirtualMachines.API.Controllers
{
    [Route("vm/[controller]")]
    public class VirtualMachineController : Controller
    {
        
        // GET virtualMachines/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET virtualMachines/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST virtualMachines/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT virtualMachines/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE virtualMachines/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
