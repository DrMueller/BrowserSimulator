using System;
using System.Collections.Generic;
using System.Text;
using mshtml;

namespace BrowserSimulator.Services
{
    public interface IWebElementAdapter
    {
        T Adapt<T>(IHTMLElement nativeElement);
    }
}
