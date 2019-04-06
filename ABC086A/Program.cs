using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC086A
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToArray();
            var a = inputs[0];
            var b = inputs[1];

            var c = a * b % 2;

            if (c == 1)
                Console.WriteLine("Odd");
            else
                Console.WriteLine("Even");

        }
    }
}
