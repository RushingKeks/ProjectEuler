namespace ProjectEuler.Core
{
    /// <summary>
    /// This helper provides some mathematic helper methods.
    /// </summary>
    public class MathHelper
    {
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
