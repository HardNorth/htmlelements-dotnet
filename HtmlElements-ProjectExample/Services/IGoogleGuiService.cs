
using Common.Logging;
using HtmlElements.Test.Browsers;
using HtmlElements.Test.Services.GoogleScreens;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HtmlElements.Test.Services
{
    public interface IGoogleGuiService
    {
        string BaseUrl
        {
            get;
            set;
        }

        IList<string> Search(string query);
    }
}
