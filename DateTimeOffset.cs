using System;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class DateTest
    {
        [Test]
        public void DateTimeOffset()
        {
            // System.DateTimeOffset (.NET 3.5)
            DateTimeOffset axelsTime = new DateTimeOffset(2011, 4, 1, 21, 24, 0, TimeSpan.FromHours(1));
            //Console.WriteLine(axelsTime);
            //Console.WriteLine(axelsTime.ToUniversalTime());
            DateTimeOffset robsTime = new DateTimeOffset(2011, 4, 1, 10, 24, 0, TimeSpan.FromHours(-10));

            Assert.AreEqual(axelsTime, robsTime);
            Assert.AreEqual(axelsTime.ToUniversalTime(), robsTime.ToUniversalTime());
        }
    }
}
