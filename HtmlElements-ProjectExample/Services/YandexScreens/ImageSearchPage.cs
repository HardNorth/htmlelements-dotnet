using HtmlElements.Test.Browsers;
using HtmlElements.Test.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlElements.Test.Services.YandexScreens
{
    [Identity("CssSelector:button[aria-label='Image search']")]
    public class ImageSearchPage : BasicSearchScreen
    {
        public ImageSearchPage(Browser browser)
            : base(browser)
        {
        }

        public override void Open()
        {
            if (!IsOnCurrentPage())
            {
                OpenImageSearchPage();
            }
        }
    }
}
