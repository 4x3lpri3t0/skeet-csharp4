using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
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
            using (var md5 = MD5.Create())
            {
                // ENCRYPTION: The encoding of data according to a cipher with the intention of decoding it later on.
                // HASH: A one way, virtually non-decodable encryption of a bit of data.
                byte[] hash = md5.ComputeHash(new byte[10]);

                string hashAsText = Convert.ToBase64String(hash);

                byte[] backAgain = Convert.FromBase64String(hashAsText);
            }
        }
    }
}
