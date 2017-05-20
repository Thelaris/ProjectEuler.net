using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {

        public static Boolean IsPalindrome(int n)
        {
            int rev = 0;
            int x = n;

            while (x > 0)
            {
                rev = 10 * rev + x % 10;
                x /= 10;
            }

            return n == rev;
        }

        static void Main(string[] args)
        {
            int max = 100001;

            for (int i = 999; i >= 100; i--)
            {
                if (max >= i * 999)
                {
                    break;
                }
                for (int j = 999; j >= 100; j--)
                {
                    int k = i * j;
                    if (max < k && IsPalindrome(k))
                    {
                        max = k;
                        Console.WriteLine(i);
                        Console.WriteLine(j);
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
