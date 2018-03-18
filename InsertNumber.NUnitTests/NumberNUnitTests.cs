using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InsertNumber.Logic;

namespace InsertNumber.NUnitTests
{
    [TestFixture]
    public class NumberNUnitTests
    {
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(89, 5, 1, 4, ExpectedResult = 75)]
        [TestCase(2018, 21, 4, 9, ExpectedResult = 1362)]
        [TestCase(8, 5, 2, 5, ExpectedResult = 20)]
        [TestCase(-15, 8, 0, 2, ExpectedResult = -7)]
        [TestCase(-26, 7, 1, 3, ExpectedResult = -18)]
        public static int InsertNumber_Result(int sourceNumber, int insertNumber, int i, int j) => Number.InsertNumber(sourceNumber, insertNumber, i, j);

        [Test]
        public void InsertNumber_I_8_J_3_Throw_ArgumenException()
            => Assert.Throws<ArgumentException>(() => Number.InsertNumber(8, 15, 8, 3));
        [Test]
        public void InsertNumber_I_Minus3_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => Number.InsertNumber(8, 15, -3, 7));

        [Test]
        public void InsertNumber_J_32_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => Number.InsertNumber(8, 15, 4, 32));
    }
}
