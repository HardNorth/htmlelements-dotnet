
using Common.Logging;
using HtmlElements.Test.Browsers;
using HtmlElements.Test.Services.GoogleScreens;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HtmlElements.Test.Services
{
    public class GoogleGuiService : IGoogleGuiService
    {
        private readonly ILog Log = LogManager.GetLogger(typeof(GoogleGuiService));

        private IBrowserFactory browserFactory;
        private string baseUrl;
        private MainPage mainPage;

        public GoogleGuiService(IBrowserFactory browserFactory)
        {
            this.browserFactory = browserFactory;
        }

        private Browser Browser
        {
            get
            {
                return browserFactory.Get();
            }
        }

        public string BaseUrl
        {
            get
            {
                return baseUrl;
            }
            set
            {
                baseUrl = value;
            }
        }

        public IList<string> Search(string query)
        {
            if (mainPage == null)
            {
                mainPage = new MainPage(Browser, baseUrl);
            }
            mainPage.Open();
            SearchPage ss = mainPage.search(query);
            return ss.GetSearchResluts();
        }
    }
}
