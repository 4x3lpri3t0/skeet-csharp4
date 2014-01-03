using System;

namespace Fundamentals
{
    public class Greeter
    {
        private string speaker;
        public string Speaker { get; set; }

        public Greeter(string speaker)
        {
            this.Speaker = speaker;
        }

        public string SayHello(string recipient)
        {
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient");
            }
            if (Speaker == null)
            {
                return "Hello " + recipient;
            }
            return string.Concat("Hello ", recipient, " from ", Speaker);
        }
    }
}
