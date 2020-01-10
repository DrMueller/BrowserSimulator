using BrowserSimulator.Html.Models;

namespace BrowserSimulator.Models.Finders
{
    public interface IFinder
    {
        HtmlElement Find();
    }
}