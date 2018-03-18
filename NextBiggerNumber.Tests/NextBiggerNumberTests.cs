using System;    
using NUnit.Framework;
using static NextBiggerNumber.Logic.NextBiggerNumber;

namespace NextBiggerNumber.Tests
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321,  ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432,  ExpectedResult = 3462345)]
        [TestCase(3333, ExpectedResult = -1)]
        [TestCase(10,  ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int FindNextBiggerNumber_Result(int number) => FindNextBiggerNumber(number);
        [Test]
        public void FindNextBiggerNumber_Minus8995_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => FindNextBiggerNumber(-8955));
        [Test]
        public void FindNextBiggerNumber_0_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => FindNextBiggerNumber(0));
        [Test]
        public void FindNextBiggerNumber_IntMinValue_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => FindNextBiggerNumber(int.MinValue));
        [Test]
        public void FindNextBiggerNumber_IntMaxValue_Throw_ArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => FindNextBiggerNumber(int.MaxValue));
    }
}
