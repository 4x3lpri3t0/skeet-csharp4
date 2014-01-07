using System;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class DateTest
    {
        [Test]
        public void TimeZoneInfo_()
        {
            // System.TimeZoneInfo (.NET 3.5) -> Best
            TimeZoneInfo zone = TimeZoneInfo.Local;
            Assert.AreEqual(TimeSpan.FromHours(-3), zone.GetUtcOffset(new DateTime(2011, 3, 27, 0, 0, 0)));
            Assert.AreEqual(TimeSpan.FromHours(-3), zone.GetUtcOffset(new DateTime(2011, 3, 27, 3, 0, 0)));

            Console.WriteLine("{0} \r\n {1} \r\n {2}", zone.Id, zone.DisplayName, zone.DaylightName);
        }
    }
}
