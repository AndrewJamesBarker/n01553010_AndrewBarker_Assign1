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
        public int GetMultipleOper(int id)
        /// <summary> I may have misunderstood the question, so I have updated with
        /// a new web config that takes {action} into the route, and can perform 4 independant mathematical operations.
        /// the first route 'Get Multiple'
        /// Performs four mathematical operations on the users input.
        /// Takes user input integer and divides it by the square root of Ten plus Two. 
        /// It then multiplies everything by Two,
        /// and returns the answer as an integer.
        /// <param name="id">user input integer</param>
        /// <returns>squareroot of 12 divided by user input and multiplied by 2</returns>
        /// </summary>
        /// <example> localhost:59277/api/numbermachine/MultipleOper/100 --> 57 </example>
        {
            decimal fourOperations = (int)(id / Math.Sqrt(10 + 2) * 2);
            return (int)fourOperations;
        }

        public int GetAddFour(int id)
        {
            ///<sumary>
            /// this adds 4 to the users input
            /// </summary>
            /// <returns>plus four of user input</returns>
            /// <example> localhost:59277/api/numbermachine/addfour/100 --> 104 </example>
            int addFour = (int)(id + 4);
            return addFour;
        }

        public double GetDivideTwo(double id)
        {
            ///<sumary>
            /// divides user input by 2, integer or decimal
            /// </summary>
            /// <returns>user input bu two</returns>
            /// <example> localhost:59277/api/numbermachine/dividetwo/11 --> 5.5 </example>
            double divideTwo = (double)(id / 2);
            return divideTwo;
        }

        public int GetMinusTen(int id)
        {

            ///<sumary>
            /// subtracts 10 from user input
            /// </summary>
            /// <returns>user input minus 10</returns>
            /// <example> localhost:59277/api/numbermachine/minusTen/4 --> -6 </example>
            int minusTen = (int)(id - 10);
            return minusTen;
        }
      
    }
}
