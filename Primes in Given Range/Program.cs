using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            chekRangeForPrimes(num1, num2);
        }

        private static void chekRangeForPrimes(int num1, int num2)
        {
            List<int> numbers = new List<int>();

            if (num1 > num2)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            if (num1<=1 || num2 < 0)
            {
                num1 = 2;
            }
            for (int i = num1; i <= num2; i++)
            {
                bool IsPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    numbers.Add(i);
                }
            }
            print(numbers);
        }

        private static void print(List<int> numbers)
        {
            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
