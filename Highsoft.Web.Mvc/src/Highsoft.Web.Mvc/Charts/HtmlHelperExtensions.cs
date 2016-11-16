
// Type: Highsoft.Web.Mvc.Charts.HtmlHelperExtensions




using Highsoft.Web.Mvc.Charts.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Highsoft.Web.Mvc.Charts
{
  public static class HtmlHelperExtensions
  {
    public static HighsoftNamespace Highsoft(this IHtmlHelper helper)
    {
      return new HighsoftNamespace();
    }

    public static HtmlString Highcharts(Highcharts chart, string id)
    {
      HighchartsRenderer highchartsRenderer = new HighchartsRenderer(chart);
      chart.ID = id;
      chart.Chart.RenderTo = id;
      return new HtmlString(highchartsRenderer.RenderHtml());
    }
  }
}
