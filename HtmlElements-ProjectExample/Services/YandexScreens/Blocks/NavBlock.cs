using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Yandex.HtmlElements.Attributes;
using Yandex.HtmlElements.Elements;

namespace HtmlElements.Test.Services.YandexScreens.Blocks
{
    [Name("Navigation Block")]
    [Block(How = How.CssSelector, Using = "div[class='navigation__region']")]
    public class NavBlock : HtmlElement
    {
        [Name("Navigation Links")]
        [FindsBy(How = How.CssSelector, Using = "a")]
        private IList<Link> navLinks;

        public Link this[string key]
        {
            get
            {
                foreach (Link link in navLinks)
                {
                    if (link.GetReference().Contains(key))
                    {
                        return link;
                    }
                }
                return null;
            }
        }
    }
}
