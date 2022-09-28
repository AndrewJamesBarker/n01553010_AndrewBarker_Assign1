using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01553010_AndrewBarker_Assign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int GET(int id)
        /// <summary>
        /// Performs four mathematical operations on the users input.
        /// Takes user input integer and divides it by the square root of Ten plus Two. 
        /// It then multiplies everything by Two,
        /// and returns the answer as an integer.
        /// <param name="id">user input integer</param>
        /// <returns>squareroot of 12 divided by user input and multiplied by 2</returns>
        /// </summary>
        /// <example> localhost:59277/api/numbermachine/100 --> 57 </example>
        {
            decimal fourOperations = (int)(id / Math.Sqrt(10 + 2) * 2);
            return (int)fourOperations;
        }
    }
}
