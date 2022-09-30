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
            ///(edit, it works now. all i had to do was add 1 to my division calculating the amount of fortnights.)
            /// 
            ///I started by going through the examples in the 'microsoft numbers in C#' link you gave us, 
            ///and then tinkering with this problem in the codepen.
            ///I used trial and error to find out what output would support my using integers, decimals and strings together. 
            ///Research/google/luck to find out about the little 'm' at the end of decimals.
            ///geeksforgeeks to find the right way to round (i scrolled until i saw a result with 2 decimal points, and it worked.
            ///
            ///It was just by playing around and entering different numbers that i discovered my HST was displaying with too
            ///many decimal points, so i wrapped the Math.Round around my multiplication. 
            ///
            ///The last stage was just going through my variables and performing the equations in the right places,
            ///and concating with strings.
            ///
            ///<summary>using Get method, calculates how many fortnights have transpired based on the user entering 
            ///a number denoting days elapsed.
            ///The purpose being to charge the correct fee including HST for web hosting
            ///<param name="id">user input number of days transpired</param>
            ///<param name="oneFNight">14 days, or a fortnight</param>
            ///<param name="fNightCount">fortnight divided by user input +1 to push into next billing cycle</param>
            ///<param name="fNightCost">cost per fortnight</param>
            ///<param name="hST">HST percentage</param>
            ///<param name="totalPreRound">total before rounded to 2 decimals</param>
            ///<param name="total">total rounded to 2 decimals</param>
            ///</summary>
            ///<return>returns fee of 5.50 per fortnight plus HST, concated within a string.
            ///</return>
            ///<example>GET localhost:59957/api/HostingCostMath/13 ->1 fortnight at $5.50 / FN = $5.50 CAD + HST 13 % = $0.72 CAD Total = $6.22 CAD 
            ///</example>


            int oneFNight = 14;
            int fNightCount = id / oneFNight + 1;
            decimal fNightCost = 5.50m;
            decimal hST = 0.13m;
            decimal totalPreRound = fNightCount * fNightCost * hST + fNightCost * fNightCount;
            decimal total = Math.Round(totalPreRound, 2);
            return fNightCount + " fortnights at $" + fNightCost + "/FN = $" + fNightCount * fNightCost + " CAD " + "HST 13% = $" + 
                Math.Round(fNightCount * fNightCost * hST,2) + " CAD "
            + "Total = $" + total + " CAD";
        }



    }
}
