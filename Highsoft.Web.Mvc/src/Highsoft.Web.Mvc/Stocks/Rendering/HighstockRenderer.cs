// Type: Highsoft.Web.Mvc.Stocks.Rendering.HighstockRenderer


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks.Rendering
{
    public class HighstockRenderer
    {
        private readonly Highstock _chart;

        public HighstockRenderer(Highstock chart)
        {
            _chart = chart;
        }

        public string RenderHtml()
        {
            return GetStartupJavascript();
        }

        public string GetJsonOptions()
        {
            return GetStartupOptions();
        }

        private string GetStartupJavascript()
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            _chart.Chart.RenderTo = _chart.ID;
            StringBuilder stringBuilder2 = stringBuilder1;
            string format = "<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>";
            string id = _chart.ID;
            double? nullable = _chart.Chart.Height;
            string str1 = nullable.ToString();
            nullable = _chart.Chart.Width;
            string str2 = nullable.ToString();
            stringBuilder2.AppendFormat(format, (object) id, (object) str1, (object) str2);
            stringBuilder1.Append("<script type='text/javascript'>");
            stringBuilder1.Append(string.Format(
                "if (document.addEventListener) {{document.addEventListener(\"DOMContentLoaded\", function() {{createChart{0}();}});}} else if (document.attachEvent) {{document.attachEvent(\"onreadystatechange\", function(){{if (document.readyState === \"complete\"){{document.detachEvent(\"onreadystatechange\", arguments.callee);createChart{1}();}}}});}}",
                (object) _chart.ID, (object) _chart.ID));
            stringBuilder1.Append(string.Format("function createChart{0}() {{", (object) _chart.ID));
            stringBuilder1.Append(string.Format("var ChartOptions = {0};", (object) GetStartupOptions()));
            stringBuilder1.Append(string.Format("new Highcharts.StockChart(\"{0}\",ChartOptions);",
                (object) _chart.ID));
            stringBuilder1.Append("}");
            stringBuilder1.Append("</script>");
            return stringBuilder1.ToString();
        }

        private string GetStartupOptions()
        {
            StringBuilder s = new StringBuilder();
            RenderChartSettings(s);
            return s.ToString();
        }

        private void RenderChartSettings(StringBuilder s)
        {
            Hashtable hashtable = _chart.ToHashtable();
            List<Hashtable> hashtableList1 = new List<Hashtable>();
            List<Hashtable> hashtableList2 = new List<Hashtable>();
            if (_chart.Series != null)
                hashtableList1 = SeriesToHashtables(_chart.Series);
            if (hashtableList1.Count > 0)
                hashtable[(object) "series"] = (object) hashtableList1;
            if (hashtableList2.Count > 0)
                (hashtable[(object) "drilldown"] as Hashtable)[(object) "series"] = (object) hashtableList2;
            var str1 = JsonConvert.SerializeObject(hashtable);
            Hashtable functions = Highstock.functions;
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
                Hashtable hashtable1 = new Hashtable();
                if (series is LineSeries)
                {
                    if (series.ToHashtable().ContainsKey((object) "data"))
                    {
                        Hashtable hashtable2 = series.ToHashtable();
                        hashtableList.Add(hashtable2);
                        continue;
                    }
                    LineSeries lineSeries = series as LineSeries;
                    lineSeries.Data.ForEach(
                        (Action<LineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    lineSeries.Type = LineSeriesType.Line;
                    hashtable1 = lineSeries.ToHashtable();
                }
                if (series is SplineSeries)
                {
                    SplineSeries splineSeries = series as SplineSeries;
                    splineSeries.Data.ForEach((Action<SplineSeriesData>) (data =>
                        dataList.Add((object) data.ToHashtable())));
                    splineSeries.Type = SplineSeriesType.Spline;
                    hashtable1 = splineSeries.ToHashtable();
                }
                if (series is AreaSeries)
                {
                    AreaSeries areaSeries = series as AreaSeries;
                    areaSeries.Data.ForEach(
                        (Action<AreaSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    areaSeries.Type = AreaSeriesType.Area;
                    hashtable1 = areaSeries.ToHashtable();
                }
                if (series is AreasplineSeries)
                {
                    AreasplineSeries areasplineSeries = series as AreasplineSeries;
                    areasplineSeries.Data.ForEach(
                        (Action<AreasplineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    areasplineSeries.Type = AreasplineSeriesType.Areaspline;
                    hashtable1 = areasplineSeries.ToHashtable();
                }
                if (series is AreasplinerangeSeries)
                {
                    AreasplinerangeSeries areasplinerangeSeries = series as AreasplinerangeSeries;
                    areasplinerangeSeries.Data.ForEach(
                        (Action<AreasplinerangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    areasplinerangeSeries.Type = AreasplinerangeSeriesType.Areasplinerange;
                    hashtable1 = areasplinerangeSeries.ToHashtable();
                }
                if (series is ArearangeSeries)
                {
                    ArearangeSeries arearangeSeries = series as ArearangeSeries;
                    arearangeSeries.Data.ForEach(
                        (Action<ArearangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    arearangeSeries.Type = ArearangeSeriesType.Arearange;
                    hashtable1 = arearangeSeries.ToHashtable();
                }
                if (series is ColumnrangeSeries)
                {
                    ColumnrangeSeries columnrangeSeries = series as ColumnrangeSeries;
                    columnrangeSeries.Data.ForEach(
                        (Action<ColumnrangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    columnrangeSeries.Type = ColumnrangeSeriesType.Columnrange;
                    hashtable1 = columnrangeSeries.ToHashtable();
                }
                if (series is ColumnSeries)
                {
                    ColumnSeries columnSeries = series as ColumnSeries;
                    columnSeries.Data.ForEach((Action<ColumnSeriesData>) (data =>
                        dataList.Add((object) data.ToHashtable())));
                    columnSeries.Type = ColumnSeriesType.Column;
                    hashtable1 = columnSeries.ToHashtable();
                }
                if (series is ScatterSeries)
                {
                    ScatterSeries scatterSeries = series as ScatterSeries;
                    scatterSeries.Data.ForEach(
                        (Action<ScatterSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    scatterSeries.Type = ScatterSeriesType.Scatter;
                    hashtable1 = scatterSeries.ToHashtable();
                }
                if (series is PolygonSeries)
                {
                    PolygonSeries polygonSeries = series as PolygonSeries;
                    polygonSeries.Data.ForEach(
                        (Action<PolygonSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    polygonSeries.Type = PolygonSeriesType.Polygon;
                    hashtable1 = polygonSeries.ToHashtable();
                }
                if (series is CandleStickSeries)
                {
                    CandleStickSeries candleStickSeries = series as CandleStickSeries;
                    candleStickSeries.Data.ForEach(
                        (Action<CandleStickSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    candleStickSeries.Type = CandleStickSeriesType.Candlestick;
                    hashtable1 = candleStickSeries.ToHashtable();
                }
                if (series is FlagsSeries)
                {
                    FlagsSeries flagsSeries = series as FlagsSeries;
                    flagsSeries.Data.ForEach((Action<FlagsSeriesData>) (data =>
                        dataList.Add((object) data.ToHashtable())));
                    flagsSeries.Type = FlagsSeriesType.Flags;
                    hashtable1 = flagsSeries.ToHashtable();
                }
                if (series is OhlcSeries)
                {
                    OhlcSeries ohlcSeries = series as OhlcSeries;
                    ohlcSeries.Data.ForEach(
                        (Action<OhlcSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
                    ohlcSeries.Type = OhlcSeriesType.Ohlc;
                    hashtable1 = ohlcSeries.ToHashtable();
                }
                hashtableList.Add(hashtable1);
            }
            return hashtableList;
        }
    }
}