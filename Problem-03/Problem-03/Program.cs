using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            int i = 2;
            int answer = 0;

            List<long> factors = new List<long>();
            while (n > 1)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
                i += 1;
            }
            answer = Convert.ToInt32(factors.Max());

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
