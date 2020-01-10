using System;
using System.Collections.Generic;
using System.Text;
using BrowserSimulator.Html.Models;
using BrowserSimulator.Models;

namespace BrowserSimulator.PageComponents.Services
{
    public interface IPageComponentFactory
    {
        T Create<T>(HtmlElement htmlElement);
    }
}
