using System;

namespace _123A
{
    class Program
    {
        static int OUTChecker(int p, int o, int k)
        {
            if (Math.Abs(p - o) > k)
                return 1;
            else
                return 0;
        }



        static void Main(string[] args)
        {
            int[] Antena = new int[6];
            int k;
            int check = 0;

            for (int a = 0; a < 5; a++)
            {
                Antena[a] = int.Parse(Console.ReadLine());
            }
            k = int.Parse(Console.ReadLine());

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    check += OUTChecker(Antena[a], Antena[b], k);
                }
            }

            if (check == 0)
                Console.WriteLine("Yay!");
            else
                Console.WriteLine(":(");
        }
    }
}
