using mshtml;

namespace BrowserSimulator.Html.Models
{
    public class HtmlElement
    {
        private readonly IHTMLElement _nativeElement;

        internal HtmlElement(IHTMLElement nativeElement)
        {
            _nativeElement = nativeElement;
        }

        internal IHTMLElement
    }
}
