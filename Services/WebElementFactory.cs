using System;
using System.Collections.Generic;
using System.Text;
using BrowserSimulator.PageComponents.Models;
using mshtml;

namespace BrowserSimulator.Services
{
    public static class WebElementFactory
    {
        public static T Create<T>(IHTMLElement nativeElement)
        where T: IPageComponent
        {
            var tType = typeof(T);

            if (tType == typeof(ButtonComponent))
            {
                return new ButtonComponent(nativeElement);
            }
        }
    }
}
