using System;

namespace _65
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, z, prod = 1, ok = 0;
            n = int.Parse(Console.ReadLine());
            while(n>1)
            {
                z = n % 10;
                if(z%2==1)
                {
                    prod = prod * z;
                    ok = 1;
                }
                n = n / 10;
            }
            if(ok==0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(prod);
            }
            Console.ReadKey();
        }
    }
}
