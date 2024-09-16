using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class LommeRegnerTests
    {
        [TestMethod()]
        public void PlusFunktionTest()
        {
            // Arange
            LommeRegner regner = new LommeRegner();

            // Act
            double expected = 10;
            
            // Assert
            Assert.AreEqual(expected, regner.PlusFunktion(5,5));
        }

        [TestMethod()]
        public void MinusFunktionTest()
        {
            // Arange
            LommeRegner regner = new LommeRegner();

            // Act
            double expected = 10;

            // Assert
            Assert.AreEqual(expected, regner.MinusFunktion(20, 10));
        }

        [TestMethod()]
        public void GangeFunktionTest()
        {
            // Arange
            LommeRegner regner = new LommeRegner();

            // Act
            double expected = 100;

            // Assert
            Assert.AreEqual(expected, regner.GangeFunktion(10,10));
        }

        [TestMethod()]
        public void dividereFunktion()
        {
            LommeRegner regner = new LommeRegner();

            double expected = 100;

            Assert.AreEqual(expected, regner.dividereFunktion(1000, 10));

        }

    }
}