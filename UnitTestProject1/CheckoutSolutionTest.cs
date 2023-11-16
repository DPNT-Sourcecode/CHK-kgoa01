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
        public void ShouldFailWhenInputWhiteSpaceParseSkus()
        {
            //Arrange
            string skus = "2A";

            //act
            () = ParseSkus(skus);

            //assert

        }
    }
}

