using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsertNumber.Logic;

namespace InsertNumber.Tests
{
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void InsertNumber_Sorce_8_Insert_15_I_3_J_8()
        {
            int actual = Number.InsertNumber(8, 15, 3, 8);
            int expect = 120;
            Assert.AreEqual(actual, expect);
        }
        [TestMethod]
        public void InsertNumber_Sorce_89_Insert_5_I_1_J_4()
        {
            int actual = Number.InsertNumber(89, 5, 1, 4);
            int expect = 75;
            Assert.AreEqual(actual, expect);
        }
        [TestMethod]
        public void InsertNumber_Sorce_2018_Insert_21_I_4_J_9()
        {
            int actual = Number.InsertNumber(2018, 21, 4, 9);
            int expect = 1362;
            Assert.AreEqual(actual, expect);
        }
        [TestMethod]
        public void InsertNumber_Sorce_Minus15_Insert_8_I_0_J_2()
        {
            int actual = Number.InsertNumber(-15, 8, 0, 2);
            int expect = -7;
            Assert.AreEqual(actual, expect);
        }

        [TestMethod]
        public void InsertNumber_Sorce_0_Insert_7_I_1_J_3()
        {
            int actual = Number.InsertNumber(0, 7, 1, 3);
            int expect = 14;
            Assert.AreEqual(actual, expect);
        }

        [TestMethod]
        public void InsertNumber_Sorce_Minus26_Insert_7_I_1_J_3()
        {
            int actual = Number.InsertNumber(-26, 7, 1, 3);
            int expect = -18;
            Assert.AreEqual(actual, expect);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_Sorce_15_Insert_8_I_6_J_2() => Number.InsertNumber(15, 8, 6, 2);

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_Sorce_15_Insert_8_I_Minus6_J_2() => Number.InsertNumber(15, 8, -6, 2);
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_Sorce_15_Insert_8_I_6_J_32() => Number.InsertNumber(15, 8, 6, 32);

    }
}
