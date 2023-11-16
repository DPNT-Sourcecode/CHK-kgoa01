using BeFaster.App.Solutions.SUM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            //Assert.AreEqual(1, 2);
            return SumSolution.Sum(x, y);
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
