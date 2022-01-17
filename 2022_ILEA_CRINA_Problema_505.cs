using System;

namespace _505
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string t1 = Console.ReadLine();
            string[] v1 = t1.Split(' ');
            string t2 = Console.ReadLine();
            string[] v2 = t2.Split(' ');
            int[] s1 = Array.ConvertAll(v1, int.Parse);
            int[] s2 = Array.ConvertAll(v2, int.Parse);
            bool ok = true;
            int i, j;
            for ( i = 0; i < n; i++)
            {
                bool numereEgale = false;
                for ( j = 0; j < n; j++)
                    if (s1[i] == s2[j] && !numereEgale)
                    {
                        numereEgale = true;
                        s2[j] = -1;
                    }
                if (!numereEgale)
                    ok = false;
            }
            if (ok)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
            Console.ReadKey();
        }
    }
}
