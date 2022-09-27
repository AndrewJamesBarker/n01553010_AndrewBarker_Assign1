using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01553010_AndrewBarker_Assign1.Controllers
{
  
    public class AddTenController : ApiController
    {
        public int GET(int id)
        /// <summary>
        /// Adds ten to user input int
        /// </summary>
        /// <returns>user input int plus ten</returns>
        /// <example>localhost:59957/api/addten/3 --> 13 </example>
        {
            int plusTen = id + 10;
            return plusTen;
        }
    }
}
