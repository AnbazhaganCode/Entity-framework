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
            //LINQ class four

            // Q)  List the odd values where lessthen 6 from given array 
            int[] marks = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Ans)
            var result = marks.Where(n=> n<6 && n%2 != 0);  //Linq

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            //Output)
            //1
            //3
            //5
        }
    }
}
