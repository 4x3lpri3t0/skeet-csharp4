using System.Collections.Generic;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class Collections
    {
        [Test]
        public void ListBasics()
        {
            var names =  new List<string>();
            names.Add("fred");
            Assert.AreEqual("fred", names[0]);

            Assert.AreEqual(1, names.Count);
            names.Add("betty");
            Assert.AreEqual(2, names.Count);

            names.RemoveAt(0); // After we remove Fred, we have Bett
            Assert.AreEqual(1, names.Count);
            Assert.AreEqual("betty", names[0]);

            names[0] = "barney";

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //var integers = new List<int>(50) {10, 20};
            //Equivalent to:
            var tmp = new List<int>(50);
            tmp.Add(10);
            tmp.Add(20);
            var integers = tmp;

            integers = new List<int>() { integers.Count };
            Assert.AreEqual(2, integers[0]);
        }
    }
}
