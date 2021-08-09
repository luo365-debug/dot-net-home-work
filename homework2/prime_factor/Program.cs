using System;

namespace prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Int32.Parse(Console.ReadLine());

            int[] result;
            result = new int[num];
            int j = 0;
            int prime = 1;
            while ((++prime) < num)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(prime); i++)
                {
                    if (prime == 2) break;
                    else if (prime % i == 0) { isPrime = false; break; }
                }
                if (num % prime == 0 && isPrime)
                {
                    result[j] = prime;
                    j++;
                }
                //prime++;
            }
            for (int k = 0; k < j; k++)
            {
                Console.Write(result[k]+" ");
            }
        }
    }
}
