using System;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class DateTest
    {
        [Test]
        public void DateTimeUsage()
        {
            // System.DateTime (.NET 1.0)
            DateTime axelsTime = new DateTime(2011, 4, 1, 17, 24, 0, DateTimeKind.Local);
            DateTime robsTime = new DateTime(2011, 4, 1, 10, 24, 0, DateTimeKind.Local);
            DateTime utcTime = new DateTime(2011, 4, 1, 20, 24, 0, DateTimeKind.Utc);
            DateTime unspecifiedFive = new DateTime(2011, 4, 1, 17, 24, 0, DateTimeKind.Unspecified);
            DateTime unspecifiedEight = new DateTime(2011, 4, 1, 20, 24, 0, DateTimeKind.Unspecified);

            Assert.AreEqual(utcTime, axelsTime.ToUniversalTime());
            Assert.AreEqual(utcTime, utcTime.ToUniversalTime());

            Assert.AreEqual(axelsTime, axelsTime.ToLocalTime());
            Assert.AreEqual(axelsTime, utcTime.ToLocalTime());

            Assert.AreEqual(utcTime, unspecifiedFive.ToUniversalTime()); // Asumes is local
            Assert.AreEqual(axelsTime, unspecifiedEight.ToLocalTime()); // Asumes is UTC

            DateTime bedTime = axelsTime + TimeSpan.FromHours(5); // 22hs
            Assert.AreEqual(new DateTime(2011, 4, 1, 22, 24, 0, DateTimeKind.Local),
                            bedTime);

            DateTime beforeTransition = new DateTime(2011, 3, 27, 0, 0, 0);
            DateTime afterTransition = new DateTime(2011, 3, 27, 3, 0, 0);
            Assert.AreEqual(TimeSpan.FromHours(3), afterTransition - beforeTransition);

            DateTime beforeTransitionUtc = beforeTransition.ToUniversalTime();
            DateTime afterTransitionUtc = afterTransition.ToUniversalTime();
            Assert.AreEqual(TimeSpan.FromHours(3), afterTransitionUtc - beforeTransitionUtc);
        }
    }
}
