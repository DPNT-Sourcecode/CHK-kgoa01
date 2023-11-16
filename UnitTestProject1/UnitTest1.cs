using BeFaster.App.Solutions.HLO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFriendName()
        {
            //Arrange
            var name = "Peter";
            var expected = "Hello, Peter!";

            //act
            var result = HelloSolution.Hello(name);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
