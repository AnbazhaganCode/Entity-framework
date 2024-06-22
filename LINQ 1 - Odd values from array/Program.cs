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

            //Ans 1)
            var oddValues = from i in marks
                            where i % 2 != 0
                            select i;  //Linq
            //Ans 2)
            var results = marks.Ware(n => n %2 != 0);
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
