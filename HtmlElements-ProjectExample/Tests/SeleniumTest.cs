using Common.Logging;
using HtmlElements.Test.Browsers;
using HtmlElements.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlElements.Test.Tests
{
    public class SeleniumTest : BaseTest
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(SeleniumTest));

        protected IYandexGuiService guiService;

        public IYandexGuiService GuiService
        {
            set
            {
                guiService = value;
            }
        }

        private IBrowserFactory browserFactory;

        public IBrowserFactory BrowserFactory
        {
            set { browserFactory = value; }
        }

        public Browser Browser
        {
            get
            {
                return browserFactory.Get();
            }
        }
    }
}
