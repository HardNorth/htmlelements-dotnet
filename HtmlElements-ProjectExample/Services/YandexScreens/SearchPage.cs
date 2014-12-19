using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using HtmlElements.Test.Browsers;
using HtmlElements.Test.Screens;
using HtmlElements.Test.Screens.Exceptions;
using HtmlElements.Test.Services.YandexScreens.Blocks;
using System.Collections.Generic;

namespace HtmlElements.Test.Services.YandexScreens
{
    [Identity("Xpath://span[@class='copyright__name'][contains(text(),'Yandex')]")]
    public class SearchPage : BasicSearchScreen
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'serp-list')]/div[contains(@class,'serp-block')]/div")]
        public IList<IWebElement> allResults;

        public SearchPage(Browser browser)
            : base(browser)
        {
        }

        public override void Open()
        {
            throw new NoRouteToScreenException("This screen only accessible through MainScreen search");
        }

        public IList<string> GetSearchResluts()
        {
            IList<string> result = new List<string>();

            foreach (IWebElement searchResult in allResults)
            {
                IWebElement element = searchResult.FindElement(By.XPath(".//h2/a"));
                result.Add(element.GetAttribute("href"));
            }
            return result;
        }

    }
}