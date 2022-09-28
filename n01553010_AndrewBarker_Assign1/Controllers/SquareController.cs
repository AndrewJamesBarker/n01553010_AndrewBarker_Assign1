using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01553010_AndrewBarker_Assign1.Controllers
{
 
    public class squareController : ApiController
    {
        public int GET(int id)
        /// <summary>
        /// takes user input int and squares it
        /// <param name="id">user input int</param>
        /// </summary>
        /// <returns>user input squared</returns>
        /// <example>localhost:59957/api/square/10 --> 100</example>
        {
            int inputSquared = id * id;
            return inputSquared;
        }
    }
}

