using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int squareOfSum = 0;
            int answer = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }

            for (int j = 1; j <= 100; j++)
            {
                squareOfSum += j;
            }

            squareOfSum *= squareOfSum;

            answer = squareOfSum - sumOfSquares;

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
