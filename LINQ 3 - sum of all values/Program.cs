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
            //LINQ class three

            // Q)  List the sum of all values from given array 
            int[] marks = { 11, 4, 6, 1, 9, 2, 5, 8 };

            //Ans)
            var result = marks.Sum();  //Linq

            Console.WriteLine(result);
            
            Console.ReadKey();

            //Output)
            //46
        }
    }
}
