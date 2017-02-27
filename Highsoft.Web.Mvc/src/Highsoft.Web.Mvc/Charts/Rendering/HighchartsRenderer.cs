// Type: Highsoft.Web.Mvc.Charts.Rendering.HighchartsRenderer


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts.Rendering
{
    public class HighchartsRenderer
    {
        private readonly Highcharts chart;

        public HighchartsRenderer(Highcharts chart)
        {
            this.chart = chart;
        }

        public string RenderHtml()
        {
            return this.GetStartupJavascript();
        }

        private string GetStartupJavascript()
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            this.chart.Chart.RenderTo = this.chart.ID;
            StringBuilder stringBuilder2 = stringBuilder1;
            string format = "<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>";
            string id = this.chart.ID;
            double? nullable = this.chart.Chart.Height;
            string str1 = nullable.ToString();
            nullable = this.chart.Chart.Width;
            string str2 = nullable.ToString();
            stringBuilder2.AppendFormat(format, (object) id, (object) str1, (object) str2);
            stringBuilder1.Append("<script type='text/javascript'>");
            stringBuilder1.Append(
                string.Format(
                    "if (document.addEventListener) {{document.addEventListener(\"DOMContentLoaded\", function() {{createChart{0}();}});}} else if (document.attachEvent) {{document.attachEvent(\"onreadystatechange\", function(){{if (document.readyState === \"complete\"){{document.detachEvent(\"onreadystatechange\", arguments.callee);createChart{1}();}}}});}}",
                    (object) this.chart.ID, (object) this.chart.ID));
            stringBuilder1.Append(string.Format("function createChart{0}() {{", (object) this.chart.ID));
            stringBuilder1.Append(string.Format("var ChartOptions = {0};", (object) this.GetStartupOptions()));
            stringBuilder1.Append(string.Format("new Highcharts.chart(\"{0}\",ChartOptions);", (object) this.chart.ID));
            stringBuilder1.Append("}");
            stringBuilder1.Append("</script>");
            return stringBuilder1.ToString();
        }

        public string GetJsonOptions()
        {
            return this.GetStartupOptions();
        }

        private string GetStartupOptions()
        {
            StringBuilder s = new StringBuilder();
            this.RenderChartSettings(s);
            return s.ToString();
        }

        private void RenderChartSettings(StringBuilder s)
        {
            Hashtable hashtable = this.chart.ToHashtable();
            List<Hashtable> hashtableList1 = new List<Hashtable>();
            List<Hashtable> hashtableList2 = new List<Hashtable>();
            if (this.chart.Series != null)
                hashtableList1 = this.SeriesToHashtables(this.chart.Series);
            if (this.chart.Drilldown.Series != null)
                hashtableList2 = this.SeriesToHashtables(this.chart.Drilldown.Series);
            if (hashtableList1.Count > 0)
                hashtable[(object) "series"] = (object) hashtableList1;
            if (hashtableList2.Count > 0)
                (hashtable[(object) "drilldown"] as Hashtable)[(object) "series"] = (object) hashtableList2;
            string str1 = JsonConvert.SerializeObject((object) hashtable);
            Hashtable functions = Highcharts.functions;
            foreach (string key in (IEnumerable) functions.Keys)
            {
                string str2 = (string) functions[(object) key];
                string str3 = key.Split('.')[1];
                string oldValue = string.Format("\"{0}\":\"{1}\"", (object) str3, (object) str2);
                string newValue = string.Format("\"{0}\":{1}", (object) str3, (object) str2);
                str1 = str1.Replace(oldValue, newValue);
            }
            s.Append(str1);
        }

        private List<Hashtable> SeriesToHashtables(List<Series> listOfSeries)
        {
            List<Hashtable> hashtableList = new List<Hashtable>();
            foreach (Series series in listOfSeries)
            {
                List<object> dataList = new List<object>();
                Hashtable hashtable = new Hashtable();
                if (series is LineSeries)
                {
                    LineSeries lineSeries = series as LineSeries;
                    lineSeries.Data.ForEach((Action<LineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    lineSeries.Type = LineSeriesType.Line;
                    hashtable = lineSeries.ToHashtable();
                }
                if (series is SplineSeries)
                {
                    SplineSeries splineSeries = series as SplineSeries;
                    splineSeries.Data.ForEach(
                        (Action<SplineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    splineSeries.Type = SplineSeriesType.Spline;
                    hashtable = splineSeries.ToHashtable();
                }
                if (series is AreaSeries)
                {
                    AreaSeries areaSeries = series as AreaSeries;
                    areaSeries.Data.ForEach((Action<AreaSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    areaSeries.Type = AreaSeriesType.Area;
                    hashtable = areaSeries.ToHashtable();
                }
                if (series is AreasplineSeries)
                {
                    AreasplineSeries areasplineSeries = series as AreasplineSeries;
                    areasplineSeries.Data.ForEach(
                        (Action<AreasplineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    areasplineSeries.Type = AreasplineSeriesType.Areaspline;
                    hashtable = areasplineSeries.ToHashtable();
                }
                if (series is ArearangeSeries)
                {
                    ArearangeSeries arearangeSeries = series as ArearangeSeries;
                    arearangeSeries.Data.ForEach(
                        (Action<ArearangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    arearangeSeries.Type = ArearangeSeriesType.Arearange;
                    hashtable = arearangeSeries.ToHashtable();
                }
                if (series is ColumnrangeSeries)
                {
                    ColumnrangeSeries columnrangeSeries = series as ColumnrangeSeries;
                    columnrangeSeries.Data.ForEach(
                        (Action<ColumnrangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    columnrangeSeries.Type = ColumnrangeSeriesType.Columnrange;
                    hashtable = columnrangeSeries.ToHashtable();
                }
                if (series is BarSeries)
                {
                    BarSeries barSeries = series as BarSeries;
                    barSeries.Data.ForEach((Action<BarSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    barSeries.Type = BarSeriesType.Bar;
                    hashtable = barSeries.ToHashtable();
                }
                if (series is ColumnSeries)
                {
                    ColumnSeries columnSeries = series as ColumnSeries;
                    columnSeries.Data.ForEach(
                        (Action<ColumnSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    columnSeries.Type = ColumnSeriesType.Column;
                    hashtable = columnSeries.ToHashtable();
                }
                if (series is PieSeries)
                {
                    PieSeries pieSeries = series as PieSeries;
                    pieSeries.Data.ForEach((Action<PieSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    pieSeries.Type = PieSeriesType.Pie;
                    hashtable = pieSeries.ToHashtable();
                }
                if (series is ScatterSeries)
                {
                    ScatterSeries scatterSeries = series as ScatterSeries;
                    scatterSeries.Data.ForEach(
                        (Action<ScatterSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    scatterSeries.Type = ScatterSeriesType.Scatter;
                    hashtable = scatterSeries.ToHashtable();
                }
                if (series is BubbleSeries)
                {
                    BubbleSeries bubbleSeries = series as BubbleSeries;
                    bubbleSeries.Data.ForEach(
                        (Action<BubbleSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    bubbleSeries.Type = BubbleSeriesType.Bubble;
                    hashtable = bubbleSeries.ToHashtable();
                }
                if (series is GaugeSeries)
                {
                    GaugeSeries gaugeSeries = series as GaugeSeries;
                    gaugeSeries.Data.ForEach(
                        (Action<GaugeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    gaugeSeries.Type = GaugeSeriesType.Gauge;
                    hashtable = gaugeSeries.ToHashtable();
                }
                if (series is SolidgaugeSeries)
                {
                    SolidgaugeSeries solidgaugeSeries = series as SolidgaugeSeries;
                    solidgaugeSeries.Data.ForEach(
                        (Action<SolidgaugeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    solidgaugeSeries.Type = SolidgaugeSeriesType.Solidgauge;
                    hashtable = solidgaugeSeries.ToHashtable();
                }
                if (series is HeatmapSeries)
                {
                    HeatmapSeries heatmapSeries = series as HeatmapSeries;
                    heatmapSeries.Data.ForEach(
                        (Action<HeatmapSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    heatmapSeries.Type = HeatmapSeriesType.Heatmap;
                    hashtable = heatmapSeries.ToHashtable();
                }
                if (series is BoxplotSeries)
                {
                    BoxplotSeries boxplotSeries = series as BoxplotSeries;
                    boxplotSeries.Data.ForEach(
                        (Action<BoxplotSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    boxplotSeries.Type = BoxplotSeriesType.Boxplot;
                    hashtable = boxplotSeries.ToHashtable();
                }
                if (series is ErrorbarSeries)
                {
                    ErrorbarSeries errorbarSeries = series as ErrorbarSeries;
                    errorbarSeries.Data.ForEach(
                        (Action<ErrorbarSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    errorbarSeries.Type = ErrorbarSeriesType.Errorbar;
                    hashtable = errorbarSeries.ToHashtable();
                }
                if (series is FunnelSeries)
                {
                    FunnelSeries funnelSeries = series as FunnelSeries;
                    funnelSeries.Data.ForEach(
                        (Action<FunnelSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    funnelSeries.Type = FunnelSeriesType.Funnel;
                    hashtable = funnelSeries.ToHashtable();
                }
                if (series is PyramidSeries)
                {
                    PyramidSeries pyramidSeries = series as PyramidSeries;
                    pyramidSeries.Data.ForEach(
                        (Action<PyramidSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    pyramidSeries.Type = PyramidSeriesType.Pyramid;
                    hashtable = pyramidSeries.ToHashtable();
                }
                if (series is WaterfallSeries)
                {
                    WaterfallSeries waterfallSeries = series as WaterfallSeries;
                    waterfallSeries.Data.ForEach(
                        (Action<WaterfallSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    waterfallSeries.Type = WaterfallSeriesType.Waterfall;
                    hashtable = waterfallSeries.ToHashtable();
                }
                if (series is PolygonSeries)
                {
                    PolygonSeries polygonSeries = series as PolygonSeries;
                    polygonSeries.Data.ForEach(
                        (Action<PolygonSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    polygonSeries.Type = PolygonSeriesType.Polygon;
                    hashtable = polygonSeries.ToHashtable();
                }
                if (series is TreemapSeries)
                {
                    TreemapSeries treemapSeries = series as TreemapSeries;
                    treemapSeries.Data.ForEach(
                        (Action<TreemapSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    treemapSeries.Type = TreemapSeriesType.Treemap;
                    hashtable = treemapSeries.ToHashtable();
                }
                hashtable.Add((object) "data", (object) dataList);
                hashtableList.Add(hashtable);
            }
            return hashtableList;
        }
    }
}