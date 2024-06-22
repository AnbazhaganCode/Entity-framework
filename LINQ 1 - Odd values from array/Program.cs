using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ class one

            // Q)  List the odd values from given array 
            int[] marks = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Ans)
            var oddValues = from i in marks
                            where i % 2 != 0
                            select i;  //Linq
            foreach ( var i in oddValues )
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //Output)
            //1
            //3
            //5
            //7
        }
    }
}
