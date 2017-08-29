// Type: Highsoft.Web.Mvc.Charts.HighsoftNamespace


using Highsoft.Web.Mvc.Charts.Rendering;
using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Html;

namespace Highsoft.Web.Mvc.Charts
{
    public class HighsoftNamespace
    {
        public HtmlString Highcharts(Highcharts chart, string id)
        {
            HighchartsRenderer highchartsRenderer = new HighchartsRenderer(chart);
            chart.ID = id;
            chart.Chart.RenderTo = id;
            return new HtmlString(highchartsRenderer.RenderHtml());
        }

        public HtmlString GetHighcharts(Highcharts chart, string id)
        {
            HighchartsRenderer highchartsRenderer = new HighchartsRenderer(chart);
            chart.ID = id;
            chart.Chart.RenderTo = id;
            return new HtmlString(highchartsRenderer.RenderHtml());
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