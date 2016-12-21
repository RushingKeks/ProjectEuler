using System;
using ProjectEuler.Core;
using System.Collections.Generic;

namespace ProjectEuler.Problem0004
{
    /* Solution:
        Brute force. 999 * 999 = palindromic? 999 * 998 = palindromic? etc.

        Iteration 0: 241ms
        Iteration 1: 109ms
        Iteration 2:   0ms !
    */

    /// <summary>
    /// To solve problem #4.
    /// https://projecteuler.net/problem=4
    /// </summary>
    class Problem0004P3nG : IProblem
    {
        public void SolveProblem(Action<float> finishCallback)
        {
            var largestPalindrome = 0;

            var foundPalindroms = new List<int>();

            // *2 Introduced a minimal digit2 number to try less loop iterations.
            var minimalDigit2 = 100;

            // Find all possible palindromes.
            for (var digit1 = 999; digit1 >= 100; digit1--)
            {
                // *1 Changed from "var digit2 = 999" to "var digit2 = digit1" => needs half the duration.
                for (var digit2 = digit1; digit2 >= minimalDigit2; digit2--)
                {
                    var product = digit1 * digit2;
                    if (IsPalindrome(product))
                    {
                        // *2 Set minimum for inner loop to current digit2
                        //    Reason: The product of digit1 and digit2 will always be smaller than
                        //            one of the found palindromes. So we don't have to check these anymore.
                        minimalDigit2 = digit2;

                        foundPalindroms.Add(product);
                    }
                }
            }

            Console.WriteLine(string.Format("\n{0}:\n Number of found palindrome numbers: {1}\n", GetType(), foundPalindroms.Count));

            // Sort and reverse found numbers so the first one is the largest.
            if (foundPalindroms.Count > 0)
            {
                foundPalindroms.Sort();
                foundPalindroms.Reverse();

                largestPalindrome = foundPalindroms[0];
            }

            if (finishCallback != null)
                finishCallback(largestPalindrome);
        }

        /// <summary>
        /// Check if the given number is a palindrome number.
        /// </summary>
        /// <param name="number">Number to check.</param>
        /// <returns>True if number is a palindrome, false else.</returns>
        private bool IsPalindrome(int number)
        {
            var numberAsString = number.ToString();
            int midDigitIndex;

            if (numberAsString.Length % 2 != 0)
            {
                midDigitIndex = (int)((numberAsString.Length - 1) / 2);

                // If the number has an odd number of digits the middle one is not of any interest for the test.
                numberAsString.Remove(midDigitIndex);
            }
            else
            {
                midDigitIndex = (int)((numberAsString.Length) / 2);
            }

            // Check for palindrome attribute.
            for(var digitIndex = 0; digitIndex < midDigitIndex; digitIndex++)
            {
                if(numberAsString[digitIndex] != numberAsString[numberAsString.Length - 1 - digitIndex])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
