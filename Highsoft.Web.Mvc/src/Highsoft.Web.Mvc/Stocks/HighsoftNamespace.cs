
// Type: Highsoft.Web.Mvc.Stocks.HighsoftNamespace




using Highsoft.Web.Mvc.Stocks.Rendering;
using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Html;

namespace Highsoft.Web.Mvc.Stocks
{
  public class HighsoftNamespace
  {
    public HtmlString Highstock(Highstock chart, string id)
    {
      HighstockRenderer highstockRenderer = new HighstockRenderer(chart);
      chart.ID = id;
      chart.Chart.RenderTo = id;
      return new HtmlString(highstockRenderer.RenderHtml());
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private new bool Equals(object value)
    {
      return base.Equals(value);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private new int GetHashCode()
    {
      return base.GetHashCode();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private new Type GetType()
    {
      return base.GetType();
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private new string ToString()
    {
      return base.ToString();
    }
  }
}
