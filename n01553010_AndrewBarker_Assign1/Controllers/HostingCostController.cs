using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

///  Response 1

///  Response 2

///  Response 3





namespace n01553010_AndrewBarker_Assign1.Controllers
{

    public class HostingCostController : ApiController
    {
       
        public string GET(int id)
        {
            /// <summary>
            /// user input determines how much thier webhosting bill based on increments of a fortnight,
            /// This only up to three fortnights because I wasn't sure how to do the math for any random user input
            /// </summary>
            /// <param name="id"></param>
            /// <returns>owed cummulative cost of web hosting based on fortnights</returns>
            /// <example>localhost:59957/api/hostingcost/3 -> 1 fortnight at $5.50 / FN = $5.50 CAD + HST 13 % = $0.72 CAD Total = $6.22 CAD. 
            /// </example>

            if (id < 14)
            {
                return "1 fortnight at $5.50 / FN = $5.50 CAD + HST 13 % = $0.72 CAD Total = $6.22 CAD.";
            }
            else if (id >= 14 && id < 28)
            {
                return "2 fortnights at $5.50 / FN = $11.00 CAD + HST 13% = $1.43 CAD Total = $12.43 CAD.";

            }
            else if (id >= 28 && id <42)
            {
                return "3 fortnights at $5.50/FN = $16.50 CAD + HST 13% = $2.14 CAD Total = $18.64 CAD";
            }
            else
            {
                return "Congrats, you've unlocked free hosting!";
            }
        }
    }
}
