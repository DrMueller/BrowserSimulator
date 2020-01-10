using System;
using System.Collections.Generic;
using System.Text;
using BrowserSimulator.Models.Finders;

namespace BrowserSimulator.Services
{
    public interface IFinderFactory
    {
        IFinder ById(string id);
    }
}
