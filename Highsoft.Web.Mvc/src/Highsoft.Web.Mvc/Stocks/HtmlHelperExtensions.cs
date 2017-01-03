// Type: Highsoft.Web.Mvc.Stocks.HtmlHelperExtensions


using Microsoft.AspNetCore.Mvc.Rendering;

namespace Highsoft.Web.Mvc.Stocks
{
    public static class HtmlHelperExtensions
    {
        public static HighsoftNamespace Highsoft(this IHtmlHelper helper)
        {
            return new HighsoftNamespace();
        }
    }
}