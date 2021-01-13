using System;

namespace primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många primtal vill du ha?");
            int primeCount = Convert.ToInt32(Console.ReadLine());
            
            int i = 0;
            int j = 2;
            Console.WriteLine("Primtal i kronologisk ordning: "); 
            while (i < primeCount)
            {
                if (testPrime(j) == 0)
                {
                    
                }
                else
                {
                    Console.WriteLine($"{ j }");
                    i++;
                }
                j++;
            }

        }

        private static int testPrime(int num)
        {
            int i;
            for (i = 2; i < num; i++)
            {
                
                if (num % i == 0)
                {
                    return 0;
                }
            }
            if (i == num)
            {
                return num;
            }
            return 0;
        }
    }
}
