using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            bool zeroRemainder = false;

            while (n > 0)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (n % i == 0)
                    {
                        zeroRemainder = true;
                    }
                    else
                    {
                        zeroRemainder = false;
                        n++;
                        break;
                    }
                }
                if (zeroRemainder)
                {
                    Console.WriteLine(n);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
