using System.Collections.Generic;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class Test
    {
        [Test]
        public void DictionaryBasics()
        {
            var map = new Dictionary<string, int>();
            map.Add("foo", 10);
            map["bar"] = 20;

            //foreach (var entry in map)
            //{
            //    Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            //}

            int value;
            bool keyFound = map.TryGetValue("blah", out value);
            Assert.IsFalse(keyFound);
            Assert.AreEqual(0, value);

            keyFound = map.TryGetValue("foo", out value);
            Assert.IsTrue(keyFound);
            Assert.AreEqual(10, value);

            Assert.AreEqual(2, map.Count);

            map = new Dictionary<string, int>
            {
                {"xyz", 3},
                {"abc", 4}
            };
            // map.Add("xyz", 3); //ERROR -> Already added
        }
    }
}
