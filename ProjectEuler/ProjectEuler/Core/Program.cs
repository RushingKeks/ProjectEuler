using ProjectEuler.Problem0003;
using System;

namespace ProjectEuler.Core
{
    /// <summary>
    /// The main thing.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            var startTime = DateTime.Now;
            var problemSolver = new Problem0003P3nG();

            problemSolver.SolveProblem(
                solution =>
                {
                    var finishTime = DateTime.Now;

                    var duration = (finishTime - startTime).TotalMilliseconds;

                    Console.WriteLine(string.Format("Solution: {0}, took {1}ms", solution, duration));
                    Console.ReadKey();
                });
        }
    }
}
