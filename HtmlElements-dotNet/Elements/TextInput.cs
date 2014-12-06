using OpenQA.Selenium;

namespace Yandex.HtmlElements.Elements
{
    public class TextInput : TypifiedElement
    {
        public TextInput(IWebElement element)
            : base(element)
        { }

        public void Clear()
        {
            WrappedElement.Clear();
        }

        public void SendKeys(string keys)
        {
            WrappedElement.SendKeys(keys);
        }

        public string Text
        {
            get
            {
                if ("textarea" == (WrappedElement.TagName))
                {
                    return WrappedElement.Text;
                }

                string enteredText = WrappedElement.GetAttribute("value");
                if (enteredText == null)
                {
                    return string.Empty;
                }
                return enteredText;
            }
        }
    }
}
