using System;
using OpenQA.Selenium;
using HtmlElements.Tests.TestElements;
using HtmlElements.Tests.TestPages;
using System.Collections.ObjectModel;
using Yandex.HtmlElements.Loaders;
using System.Collections.Generic;
using NUnit.Framework;

namespace HtmlElements.Tests
{
    [TestFixture]
    public class HtmlElementInitializationTest
    {
        private static IWebDriver driver = SearchPage.MockDriver();

        public static SearchArrow[] Data()
        {
            SearchArrow createdSearchArrow = HtmlElementLoader.Create<SearchArrow>(driver);

            SearchArrow populatedSearchArrow = new SearchArrow();
            HtmlElementLoader.Populate(populatedSearchArrow, driver);

            return new SearchArrow[] { createdSearchArrow, populatedSearchArrow };
        }

        [Test]
        public void WrappedElementOfHtmlElementShouldNotBeNull()
        {
            foreach (SearchArrow element in Data())
            {
                Assert.IsNotNull(element.WrappedElement, "Wrapped element of search arrow should not be null");
            }
        }

        [Test]
        public void InnerElementsOfHtmlElementShouldNotBeNull()
        {
            foreach (SearchArrow element in Data())
            {
                Assert.IsNotNull(element.RequestInput, "Request input of search arrow should not be null");
                Assert.IsNotNull(element.SearchButton, "Submit button of search arrow should not be null");
            }
        }

        [Test]
        public void HtmlElementNameAndToStringMethodShouldBeAsDeclared()
        {
            foreach (SearchArrow element in Data())
            {
                Assert.AreEqual(SearchArrowData.SearchArrowName, element.Name, "HtmlElement Name property should return declared value");
                Assert.AreEqual(SearchArrowData.SearchArrowName, element.ToString(), "HtmlElement .ToString() method should return declared value");
            }
        }
    }
}
