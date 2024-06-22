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
            //LINQ class two

            // Q)  List the values in acending order from given array 
            int[] marks = { 11, 4, 6, 1, 9, 2, 5, 8 };

            //Ans 1)
            var oddValues = from i in marks
                            orderby i
                            select i;  //Linq

            //Ans 2)
            var result = marks.OrderBy(n => n);  //Linq

            foreach ( var i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //Output)
            //1
            //2
            //4
            //5
            //6
            //8
            //9
            //11
        }
    }
}
