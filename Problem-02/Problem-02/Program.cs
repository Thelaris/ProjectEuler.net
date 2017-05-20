using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;
            int total = 0;

            Console.WriteLine(i);
            Console.WriteLine(j);

            while (i < 4000000 && j < 4000000)
            {
                if (j % 2 == 0)
                {
                    total += j;
                }

                j += i;
                i = j - i;

                //Console.WriteLine(i);
                Console.WriteLine(j);

            }
            Console.WriteLine("Total of even-valued terms: " + total);
            Console.ReadLine();
        }
    }
}
