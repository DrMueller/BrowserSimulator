using System.Collections.Generic;
using System.Linq;
using BrowserSimulator.Html.Models;
using BrowserSimulator.PageComponents.Models;
using BrowserSimulator.Services;
using mshtml;

namespace BrowserSimulator.Models.Finders.Implementations
{
    internal abstract class FinderBase : IFinder
    {
        private readonly IWebElementAdapter _adapter;
        protected IHTMLDocument2 Document { get; private set; }
        protected IReadOnlyCollection<IHTMLElement> Elements { get; private set; }

        protected abstract IHTMLElement FindNative();

        protected FinderBase(IWebElementAdapter adapter)
        {
            _adapter = adapter;
        }

        internal void Initialize(IHTMLDocument2 document)
        {
            Document = document;
            Elements = document.all.Cast<IHTMLElement>().ToList();
        }

        public HtmlElement Find()
        {
            var native = FindNative();
            var element = new HtmlElement(native);
            return element;
        }
    }
}