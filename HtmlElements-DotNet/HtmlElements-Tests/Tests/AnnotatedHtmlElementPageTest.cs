using System;
using HtmlElements.Tests.TestPages;
using NUnit.Framework;

namespace HtmlElements.Tests
{
    [TestFixture]
    public class AnnotatedHtmlElementPageTest
    {
        private AnnotatedHtmlElementPage page = new AnnotatedHtmlElementPage();

        [Test]
        public void HtmlElementOnPageMustBeNotNull()
        {
            Assert.IsNotNull(page.Element, "HtmlElement on page shouldn't be null");
        }

        [Test]
        public void HtmlElementWrappedElementMustBeNotNull()
        {
            Assert.IsNotNull(page.Element.WrappedElement, "Wrapped IWebElement in HtmlElement on page shouldn't be null");
        }

        [Test]
        public void HtmlElementTagNameMustBeAsDeclared()
        {
            Assert.AreEqual(AnnotatedHtmlElementPage.ElementTagName, page.Element.TagName, "HtmlElement tag name should meet expectation");
        }

        [Test]
        public void HtmlElementNameMustBePopulated()
        {
            Assert.AreEqual(AnnotatedHtmlElementPage.ElementName, page.Element.Name, "HtmlElement Name property should return declared value");
        }

        [Test]
        public void HtmlElementToStringMethodMustReturnPopulatedValue()
        {
            Assert.AreEqual(AnnotatedHtmlElementPage.ElementName, page.Element.ToString(), "HtmlElement .ToString() method should return declared value");
        }
    }
}
