using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeetupProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Number:  {0}", i);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dodaj = 0;
            for (int i = 0; i < 10; i++)
            {
                dodaj = +i;
            }

            Console.WriteLine("wynik to: {0}", dodaj);

       
            Delegate @delegate;
        }


        //Justa, widzisz to?
        //Widzę :D
        //to super to co tu piszemy?
        //Ala ma kota?
        //czy widać pętlę?
        //Widac, a moja ?XD



    }
}