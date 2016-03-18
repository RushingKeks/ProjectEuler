using System;
using ProjectEuler.Core;

namespace ProjectEuler.Problem_0003
{
    /* Solution:
    Go down from square route of 600851475143 => 775,146 (in -2 steps)
    If n is prime and X % prime == 0 => n is biggest prime factor			
    */

    /// <summary>
    /// To solve problem #3.
    /// https://projecteuler.net/problem=3
    /// </summary>
    class Problem0003P3nG
    {
        public void SolveProblem()
        {
            var bigNumber = 600851475143;
            var bigNumberSquare = (int)Math.Sqrt(bigNumber);

            if (bigNumberSquare % 2 == 0)
                bigNumberSquare--;

            var wantedPrime = 0;

            for (var counter = bigNumberSquare; counter > 2; counter -= 2)
            {
                if (!MathHelper.IsPrime(counter))
                    continue;

                if (bigNumber % counter == 0)
                {
                    wantedPrime = counter;
                    break;
                }
            }

            Console.WriteLine("Wanted prime factor: " + wantedPrime);
            Console.ReadKey();
        }
    }
}
