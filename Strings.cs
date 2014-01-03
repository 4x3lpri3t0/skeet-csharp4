using System.Text;
using System.Threading;
using NUnit.Framework;
using System.Windows.Forms;

namespace Fundamentals.Tests
{
    [TestFixture]
    class Strings
    {
        [Test]
        public void Assignment()
        {
            string x = "hello";
            string y = x;

            x = x.Replace('h', 'j');

            MessageBox.Show(x + y);

            // STRING -> Immutable:
            // * Their value cannot change with respect to variable assigment.
            // * Changing an immutable type results in the creation of a new instance of that type.
        }

        [Test]
        public void DifferentEqualObjects()
        {
            string x = "hello";
            x = x.Replace('h', 'j');
            object o1 = x;
            object o2 = "jello";

            Assert.AreNotSame(o1, o2);
            Assert.IsFalse(o1 == o2);
            Assert.IsTrue(o1.Equals(o2)); // Equals happens at execution time (compare actual types).
            Assert.IsTrue(object.Equals(o1, o2)); // Safer -> If o1 is null doesn't throw an exception (just returns false).

        }

        [Test]
        public void DifferentEqualStrings()
        {
            string x = "hello";
            x = x.Replace('h', 'j');
            string s1 = x;
            string s2 = "jello";

            Assert.AreNotSame(s1, s2);
            Assert.IsTrue(s1 == s2);
            Assert.IsTrue(s1.Equals(s2));
        }

        [Test]
        public void InterningOfConstants()
        {
            string x = "hello";
            string y = "hello";

            Assert.AreSame(x, y);
        }

        [Test]
        public void InterningOfConcatenation()
        {
            string x = "hello";
            string y = "he" + "llo";

            Assert.AreSame(x, y);
        }

        [Test]
        public void NonInterningOfConcatenation()
        {
            string he = "he";
            string x = "hello";
            string y = he + "llo";

            Assert.AreNotSame(x, y); // They don't refer to the same object
            Assert.AreEqual(x, y); // They both are "hello"
        }

        [Test]
        public void BadConcatenation()
        {
            string simple = new string('x', 100000);

            string bad = "";
            for (int i = 0; i < 100000; i++)
            {
                bad += "x"; // Since is an immutable type, creates an extra instance each iteration
            }

            Assert.AreEqual(simple, bad);
        }

        [Test]
        public void GoodConcatenation()
        {
            string simple = new string('x', 100000);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("x"); // Better performance
            }

            string good = builder.ToString();
            builder.Append("this won't appear in good");
            Assert.AreEqual(simple, good);
        }

        [Test]
        public void BadUseOfStringBuilder()
        {
            string x = "x";
            string y = "y";

            StringBuilder builder = new StringBuilder();
            builder.Append(x);
            builder.Append(" ");
            builder.Append(y);
            string result = builder.ToString();
            Assert.AreEqual("x y", result);
        }

        [Test]
        public void GoodUseOfConcatenation()
        {
            string x = "x";
            string y = "y";

            string result = x + " " + y;
            Assert.AreEqual("x y", result); // Slightly less performant, but more readable
        }

        [Test]
        public void CompilerTranslationOfConcatenation()
        {
            string x = "x";
            string y = "y";

            string result = string.Concat(x, " ", y); // More efficient.
            // string.Concat -> Length of the 1st, 2nd, 3rd... reserve that space in memory. Then copy the content of the 1st, 2nd, 3rd.
            Assert.AreEqual("x y", result);
        }

        // FOR LOOP -> StringBuilder
        // Pressing strings together -> String.Concat or just "+"

        [Test]
        public void StringJoin()
        {
            string[] values = {"x", " ", "y" };
            string commaSeparated = string.Join(",", values);
            Assert.AreEqual(", ,y", commaSeparated);

            // Could use StringBuilder but in this case string.Join is better
        }

        [Test]
        public void StringFormat1()
        {
            string x = "x";
            string y = "y";

            string result = string.Format("{0} {1}", x, y);

            Assert.AreEqual("x y", result);
        }

        [Test]
        public void StringFormat2()
        {
            string x = "x";
            string y = "y";

            string result = string.Format("{1} {0}", x, y);

            Assert.AreEqual("y x", result);
        }

        [Test]
        public void StringFormat3()
        {
            int x = 100;
            string y = "y";
            string result = string.Format("x={0} y={1}", x, y);

            Assert.AreEqual("x=100 y=y", result);
        }

        [Test]
        public void StringFormat4()
        {
            int value = 100; // == 0x64 (represented in hex)
            string y = "y";
            string result = string.Format("value=0x{0:x} y={1}", value, y);

            Assert.AreEqual("value=0x64 y=y", result);
        }

        [Test]
        public void StringFormat5()
        {
            decimal price = 10.50444525432m;
            string result = string.Format("price={0:c}", price);

            Assert.AreEqual("price=$10.50", result); // True because it takes 10.50 as value when doing {0:c} (rounds down)
        }
    }
}
