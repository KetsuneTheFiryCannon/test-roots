using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTester;

namespace MathTester.Tests
{
    [TestClass]
    public class MainClassTester
    {
        [TestMethod]
        public void DiscrementMoreThanNull()
        {
            Roots op1 = MainClass.Discrement(1, -70, 600);
            double actual1 = op1.Num1;
            double actual2 = op1.Num2;
            double expected = 70;
            double answer = actual1 + actual2;
            Assert.AreEqual(expected, answer);
        }
        [TestMethod]
        public void DiscrementLessThanNull()
        {
            Roots op1 = MainClass.Discrement(4, 1, 4);
            double expected = double.NaN;
            double actual1 = op1.Num1;
            Assert.AreEqual(expected, actual1);
        }
        [TestMethod]
        public void DiscrementEqualNull()
        {
            Roots op1 = MainClass.Discrement(1, 2, 1);
            double expected = -1;
            double actual1 = op1.Num1;
            double delta = 1;
            Assert.AreEqual(expected, actual1, delta);
        }
    }
}