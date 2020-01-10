using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using BrowserSimulator.Models;

namespace BrowserSimulator.Services
{
    public interface IBrowserFactory
    {
        Browser Create(WebBrowser webBrowser);
    }
}
