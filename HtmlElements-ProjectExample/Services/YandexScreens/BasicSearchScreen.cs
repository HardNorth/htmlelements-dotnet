using HtmlElements.Test.Browsers;
using HtmlElements.Test.Screens;
using HtmlElements.Test.Services.YandexScreens.Blocks;
using OpenQA.Selenium;
using Yandex.HtmlElements.Elements;

namespace HtmlElements.Test.Services.YandexScreens
{
    public abstract class BasicSearchScreen : BasicScreen
    {
        private NavBlock navBlock;

        public NavBlock TopNav
        {
            get { return navBlock; }
        }

        public BasicSearchScreen(Browser browser)
            : base(browser)
        {
        }

        public ImageSearchPage OpenImageSearchPage()
        {
            IJavaScriptExecutor js = browser.Driver as IJavaScriptExecutor;
            Link link = TopNav["/images/"];
            js.ExecuteScript("arguments[0].setAttribute('target','_self')", link);
            link.Click();
            ImageSearchPage isp = new ImageSearchPage(browser);
            browser.Init(isp);
            return isp;
        }
    }
}
