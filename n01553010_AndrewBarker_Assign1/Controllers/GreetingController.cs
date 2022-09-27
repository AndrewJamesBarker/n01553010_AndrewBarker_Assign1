using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01553010_AndrewBarker_Assign1.Controllers
{

    public class GreetingController : ApiController
    {
      
        public string POST()
        /// <summary>
        /// POST request returns string "Hello World!"
        /// </summary>
        /// <return>"Hello World"</return>
        /// <example> in command prompt: curl -d "" localhost:59277/api/Greeting -->"Hello World!"
        /// </example>
        {
            return "Hello World!";
        }
    }
}
