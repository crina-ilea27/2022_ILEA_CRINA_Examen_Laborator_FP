using System;

namespace _780
{
    class Program
    {
        public static int cmmdc(int x, int y)
        {
            while (x != y)
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            return x;
        }
        static void Main(string[] args)
        {

            string cp = Console.ReadLine();
            int n = int.Parse(cp.Split(' ')[0]);
            int[,] a = new int[n, n];
            string tx;
            int i, j;
            for (i = 0; i < n; i++)
            {
                tx = Console.ReadLine();
                string[] local = tx.Split(' ');
                for (j = 0; j < n; j++)
                    a[i, j] = int.Parse(local[j]);
            }
            int s1, s2;
            s1 = s2 = 0;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    if (i < j)
                        s1 = s1 + a[i, j];
                    else
                        if (i > j)
                        s2 = s2 + a[i, j];
            Console.WriteLine(cmmdc(s1, s2));
            Console.ReadKey();
        }
    }
}
