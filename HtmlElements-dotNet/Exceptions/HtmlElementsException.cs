using System;

namespace Yandex.HtmlElements.Exceptions
{
    public class HtmlElementsException : Exception
    {
        public HtmlElementsException()
            : base()
        {
        }

        public HtmlElementsException(string message)
            : base(message)
        {
        }

        public HtmlElementsException(string message, Exception isserException)
            : base(message, isserException)
        {
        }
    }
}
