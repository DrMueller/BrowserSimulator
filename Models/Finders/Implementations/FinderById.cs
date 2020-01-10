using System.Linq;
using BrowserSimulator.Services;
using mshtml;

namespace BrowserSimulator.Models.Finders.Implementations
{
    internal class FinderById : FinderBase
    {
        private readonly string _id;

        public FinderById(IWebElementAdapter adapter, string id) : base(adapter)
        {
            _id = id;
        }

        protected override IHTMLElement FindNative()
        {
            return Elements.SingleOrDefault(f => f.id == _id);
        }
    }
}