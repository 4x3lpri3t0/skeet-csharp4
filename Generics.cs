using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class Generics
    {
        [Test]
        public void Generics()
        {
            var fred = new Fred<string>("Hey!");
            Assert.AreEqual("Hey!", fred.Foo());

            var fred2 = new Fred<int>(100);
            Assert.AreEqual(100, fred2.Foo());
        }

        public class Fred<T>
        {
            T greeting;

            public Fred(T greeting)
            {
                this.greeting = greeting;
            }

            public T Foo()
            {
                return greeting;
            }
        }
    }
}
