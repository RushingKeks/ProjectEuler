using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Go down from square route of 600851475143 =>			775,146	(in -2 steps)
            If n is prime and X % prime == 0 => n is biggest prime factor			
            */

            var bigNumber = 600851475143;
            var bigNumberSquare = (int)Math.Sqrt(bigNumber);

            if (bigNumberSquare % 2 == 0)
                bigNumberSquare--;

            var wantedPrime = 0;

            for(var counter = bigNumberSquare; counter > 2; counter -= 2)
            {
                if (!IsPrime(counter))
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

        /// <summary>
        /// Returns if the given number is a prime.
        /// Stolen from http://www.dotnetperls.com/prime.
        /// </summary>
        /// <param name="candidate">prime candidate</param>
        /// <returns>true if candidate is a prime, false else</returns>
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
                return candidate == 2;

            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                    return false;
            }

            return candidate != 1;
        }
    }
}
