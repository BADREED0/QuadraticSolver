using NUnit.Framework;
using System;

namespace QuadraticSolver.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Solve_TwoDistinctRoots_ReturnsCorrectSolutions()
        {
            var result = Program.Solve(1, -3, 2); // x^2 - 3x + 2 = 0
            Assert.That(result.Item1, Is.EqualTo(2.0));
            Assert.That(result.Item2, Is.EqualTo(1.0));
        }

        [Test]
        public void Solve_OneDoubleRoot_ReturnsCorrectSolution()
        {
            var result = Program.Solve(1, -2, 1); // x^2 - 2x + 1 = 0
            Assert.That(result.Item1, Is.EqualTo(1.0));
            Assert.That(result.Item2, Is.Null);
        }

        [Test]
        public void Solve_NoRealRoots_ReturnsNullSolutions()
        {
            var result = Program.Solve(1, 0, 1); // x^2 + 1 = 0
            Assert.That(result.Item1, Is.Null);
            Assert.That(result.Item2, Is.Null);
        }

        [Test]
        public void Solve_ZeroCoefficientA_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Program.Solve(0, 2, 1));
        }
    }
}
