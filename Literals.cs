using NUnit.Framework;
using System.Windows.Forms;

namespace Fundamentals.Tests
{
    [TestFixture]
    class SimpleTypes
    {
        [Test]
        public void Literals()
        {
            char x = 'x';
            string y = "y\0notseen";
            MessageBox.Show(y);
            string quote = "quote\"";
            MessageBox.Show(quote);
            string z = @"z\0seen"; // Verbatum String Literal -> @"Some Text" -> Removes all escapes and alllows you to work with a string "as is"
            MessageBox.Show(z);
            string multiLine = @"This
                                 is the power of
                                 Verbatum";
        }
    }
}
