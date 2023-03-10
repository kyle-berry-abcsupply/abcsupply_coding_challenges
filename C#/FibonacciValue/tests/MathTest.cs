using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciValue.Tests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [DataRow(14, 377)]
        [DataRow(28, 317811)]
        public void VerifyFibonacciValue(int fibonacciIndex, int fibonacciExpectedValue)
        {
            var result = new Math();
            var fibonacciActualValue = result.GetFibonacciValue(fibonacciIndex);
            Assert.AreEqual(fibonacciExpectedValue, fibonacciActualValue);
        }
    }
}