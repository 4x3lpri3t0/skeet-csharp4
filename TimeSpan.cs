using System;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class DateTest
    {
        [Test]
        public void TimeSpanUsage()
        {
            // System.TimeSpan (.NET 1.0) -> Number of tics
            TimeSpan fiveSeconds = TimeSpan.FromSeconds(5);
            TimeSpan halfAMinute = TimeSpan.FromMinutes(.5);
            Assert.AreEqual(TimeSpan.FromMilliseconds(35000), fiveSeconds + halfAMinute);

            // Assert.AreEqual(5000, fiveSeconds.TotalMilliseconds); // FALSE -> Takes only the Miliseconds part, doesn't convert seconds
            Assert.AreEqual(0.5d, halfAMinute.TotalMinutes);
        }
    }
}
