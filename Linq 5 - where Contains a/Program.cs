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
            //LINQ class 5

            // Q)  List the values where Contains 'a' from given array 
            string[] marks = { "Anbu","Balu","Somu" };

            //Ans)
            var result = marks.Where(n=> n.Contains("a"));  //Linq

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            //Output)
            //Balu
        }
    }
}
