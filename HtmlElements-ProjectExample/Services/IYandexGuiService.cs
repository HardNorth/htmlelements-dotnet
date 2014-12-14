
using Common.Logging;
using HtmlElements.Test.Browsers;
using HtmlElements.Test.Services.YandexScreens;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HtmlElements.Test.Services
{
    public interface IYandexGuiService
    {
        string BaseUrl
        {
            get;
            set;
        }

        IList<string> Search(string query);
    }
}
