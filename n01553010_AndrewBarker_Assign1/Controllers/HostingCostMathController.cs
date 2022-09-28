using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01553010_AndrewBarker_Assign1.Controllers
{
    public class HostingCostMathController : ApiController
    {

        public string Get(int id)
        {
            ///this doesnt work right mathematically but i'm still proud of it, and feel like i'm close.//
            ///
            /// 
            ///I started by going through the examples in the 'microsoft numbers in C#' link you gave us, 
            ///and then tinkering with this problem in the codepen.
            ///I used trial and error to find out what output would support me using integers, decimals and strings together. 
            ///Research/google/luck to find out about the little 'm' at the end of decimals.
            ///geeksforgeeks to find the right way to round (i scrolled until i saw a result with 2 decimal points, and it worked.
            ///
            ///It was just by playing around and entering different numbers that i discovered my HST was displaying with too
            ///many decimal points, so i wrapped the Math.Round around my multiplication. 
            ///
            ///The last stage was just going through my variables and performing the equations in the right places,
            ///and concating with strings.
            ///
            /// I just dont know how to get my equations to fall within the correct parameters. 
            /// Right at the beginning I'm missing a step that will bump anything equal, or greater that an equal division up 
            /// into the next fortnight. I think it's the modulus, but dont know how yet.
            ///
            ///<summary>using Get method, tries to calculate how many fortnights have transpired based on the user entering 
            ///a number denoting days elapsed.
            ///The purpose being to charge the correct fee including HST for web hosting
            ///<param name="b">14 days, or a fornight</param>
            ///<param name="c">fortnight divided by user input</param>
            ///<param name="d">cost per fortnight</param>
            ///<param name="e">HST percentage</param>
            ///<param name="f">total before rounded to 2 decimals</param>
            ///<param name="g">total rounded to 2 decimals</param>
            ///</summary>
            ///<return>supposed to return fee of 5.50 per fortnight plus HST, concated within a string.
            ///</return>
            ///<example>GET localhost:59957/api/HostingCostMath/13 ->1 fortnight at $5.50 / FN = $5.50 CAD + HST 13 % = $0.72 CAD Total = $6.22 CAD 
            ///</example>


            int b = 14;
            int c = id / b;
            decimal d = 5.50m;
            decimal e = 0.13m;
            decimal f = c * d * e + d * c;
            decimal g = Math.Round(f, 2);
            return c + " fortnights at $" + d + "/FN = $" + c * d + " CAD " + "HST 13% = $" + Math.Round(c * d * e,2) + " CAD "
            + "Total = $" + g + " CAD";
        }



    }
}
