using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01553010_AndrewBarker_Assign1.Controllers
{
   
    public class MultiGreetingController : ApiController
    {   public string GET(int id)
        /// <summary>
        /// takes user input int and concatenates that number to a greeting message
        /// <param name="id"/>user input integer</param>
        /// </summary>
        /// <return>"greetings to id people!</return>
        /// <example>localhost:59957/api/multigreeting/get/10 --> Greetings to 10 people!</example>
        {
            return "Greetings to " + id + " people!";

        }


    }
}
