using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CocaColaLib;

namespace CocaColaUnittest
{
    [TestClass]
    public class UnitTest1
    {
        ColaLibrary colaLib = new ColaLibrary();

        [TestMethod]
        public void ThreeConvertToCoca()
        {
            int threeNumb = 3;
            string expectedOutput = "Coca";
            string actualOutput = colaLib.ConvertToCoca(threeNumb);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void FiveConvertToCola()
        {
            int fiveNumb = 5;
            string expectedOutput = "Cola";
            string actualOutput = colaLib.ConvertToCola(fiveNumb);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ThreeAndFiveConvertToCocaCola()
        {
            int fiveNumb = 5;
            int threeNumb = 3;

            string expectedOutput = "CocaCola";
            string actualOutput = colaLib.ConvertToCocaCola(fiveNumb, threeNumb);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
