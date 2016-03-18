using System;

namespace ProjectEuler.Core
{
    /// <summary>
    /// Interface for all problem solvers.
    /// </summary>
    public interface IProblem
    {
        void SolveProblem(Action<float> finishCallback);
    }
}
