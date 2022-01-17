using System;

namespace _159
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string tc = Console.ReadLine();
            string[] vec = tc.Split(' ');


            for (int i = 0; i < n; i++)
            {
                Console.Write(vec[i] + ' ');
                if (int.Parse(vec[i]) % 2 == 0)
                {
                    Console.Write(int.Parse(vec[i]) * 2 + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
