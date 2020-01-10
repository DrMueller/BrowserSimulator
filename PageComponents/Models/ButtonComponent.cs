using BrowserSimulator.Html.Models;
using mshtml;

namespace BrowserSimulator.PageComponents.Models
{
    public class ButtonComponent : IPageComponent
    {
        private readonly HtmlElement _htmlElement;

        internal ButtonComponent(HtmlElement htmlElement)
        {
            _htmlElement = htmlElement;
        }

        public void Click()
        {

        }
    }
}
