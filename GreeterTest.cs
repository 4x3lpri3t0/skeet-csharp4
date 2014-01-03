using System;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    class GreeterTest
    {
        [Test]
        public void SayHello_ReturnsHello()
        {
            Greeter greeter = new Greeter("Rob");
            string greeting = greeter.SayHello("Jon");

            Assert.AreEqual("Hello Jon from Rob", greeting);
        }

        [Test]
        public void CanConstructGreeterWithourSpeakerName()
        {
            new Greeter(null);
        }

        [Test]
        public void SayHello_ReturnsHelloWithRecipientNameButNoSpeakerName()
        {
            Greeter greeter = new Greeter(null);
            string greeting = greeter.SayHello("Jon");

            Assert.AreEqual("Hello Jon", greeting);
        }

        [Test]
        public void SayHello_ThrowsExceptionWithNullRecipient()
        {
            Greeter greeter = new Greeter("Rob");

            Assert.Throws<ArgumentNullException>(() => greeter.SayHello(null));
        }

        [Test]
        public void SpeakerProperty_IsSetFromConstructor()
        {
            Greeter greeter = new Greeter("Rob");

            Assert.AreEqual("Rob", greeter.Speaker);
            Assert.AreNotEqual("rob", greeter.Speaker);
        }

        [Test]
        public void SpeakerProperty_IsWritable()
        {
            Greeter greeter = new Greeter("Rob");
            greeter.Speaker = "Tom";

            Assert.AreEqual("Tom", greeter.Speaker);

            string greeting = greeter.SayHello("Jon");
            Assert.AreEqual("Hello Jon from Tom", greeting);
        }
    }
}
