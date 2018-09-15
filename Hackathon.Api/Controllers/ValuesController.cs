using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("{number}")]
        public object Get(string number)
        {
            try{
                var N = int.Parse(number);
                var cal = new Logic();

                var result =  cal.CalConsecutiveNumber(N);

                string Display = " "; 
                foreach (var item in result)
                {
                   Display += item +" ";
                }
 
                return new { Display =  Display} ;
            } catch{

                return "Not Macth";
            }
        
        }

       
    }
}
