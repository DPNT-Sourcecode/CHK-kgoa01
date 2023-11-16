using BeFaster.App.Solutions.CHK;
using BeFaster.App.Solutions.HLO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class CheckoutSolutionTest
    {
        [TestMethod]
        public void ShouldFailWhenInputIsInvalid()
        {
            //Arrange
            string skus = "InvalidInput";
            int expected = -1;
            
            //act
            var result = CheckoutSolution.ComputePrice(skus);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldFailWhenItemIsNotPresent()
        {
            //Arrange
            string skus = "5Z";
            int expected = -1;

            //act
            var result = CheckoutSolution.ComputePrice(skus);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldReturnPriceWithSpecialOffer()
        {
            //Arrange
            string skus = "5A";
            int expected = 230;

            //act
            var result = CheckoutSolution.ComputePrice(skus);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldReturnPriceWithoutSpecialOffer()
        {
            //Arrange
            string skus = "2A";
            int expected = 100;

            //act
            var result = CheckoutSolution.ComputePrice(skus);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}

