using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a, b, c;  //数字入れる箱
            string word;
            string[] input;


            a = int.Parse(Console.ReadLine());

            input = Console.ReadLine().Split(' ');
            b = int.Parse(input[0]);
            c = int.Parse(input[1]);

            word = Console.ReadLine();


            Console.WriteLine((a + b + c) + " " + word);
        }
    }
}
