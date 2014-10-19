using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlElements.Test.Browsers
{
    public interface IBrowserFactory : IDisposable
    {
        Browser Get();
        int LoadTimeout { get; set; }
        int PollingInterval { get; set; }
        string ProfilePath { get; set; }
    }
}
