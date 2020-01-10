using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using BrowserSimulator.Models.Finders;
using BrowserSimulator.PageComponents.Models;
using BrowserSimulator.PageComponents.Services;
using BrowserSimulator.Services;

namespace BrowserSimulator.Models
{
    public class Browser
    {
        private readonly IFinderFactory _finderFactory;
        private readonly IPageComponentFactory _pageComponentFactory;
        private readonly WebBrowser _webBrowser;
        private TaskCompletionSource<object> _navigationSource;
        internal IHTMLDocument2 Document => (IHTMLDocument2)_webBrowser.Document;

        internal Browser(
            WebBrowser webBrowser,
            IFinderFactory finderFactory,
            IPageComponentFactory pageComponentFactory)
        {
            _webBrowser = webBrowser;
            _finderFactory = finderFactory;
            _pageComponentFactory = pageComponentFactory;
            _webBrowser.Navigated += WebBrowser_Navigated;
        }

        public T Find<T>(Func<IFinderFactory, IFinder> finderFactory)
            where T : IPageComponent
        {
            var finder = finderFactory(_finderFactory);
            var elemnt = finder.Find();
            return _pageComponentFactory.Create<T>(elemnt);
        }

        public Task Navigate(string url)
        {
            _navigationSource = new TaskCompletionSource<object>();
            _webBrowser.Navigate(url);
            return _navigationSource.Task;
        }

        private void WebBrowser_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            _navigationSource.SetResult(null);
        }
    }
}