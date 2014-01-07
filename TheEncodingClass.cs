using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class StringTest
    {
        [Test]
        public void EncodedString()
        {
            Encoding encoding = Encoding.UTF8;
            string text = "ABC";
            byte[] binary = encoding.GetBytes(text);

            Assert.AreEqual(65, binary[0]);
            Assert.AreEqual(66, binary[1]);
            Assert.AreEqual(67, binary[2]);
        }
    }
}
