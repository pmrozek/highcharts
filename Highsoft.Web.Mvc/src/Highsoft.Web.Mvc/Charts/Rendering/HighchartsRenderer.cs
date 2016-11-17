
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
    private Highcharts _chart;

    public HighchartsRenderer(Highcharts chart)
    {
      this._chart = chart;
    }

    public string RenderHtml()
    {
      return this.GetStartupJavascript();
    }

    public string GetStartupJavascript()
    {
      StringBuilder stringBuilder = new StringBuilder();
      this._chart.Chart.RenderTo = this._chart.ID;
      string format1 = "<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>";
      string id1 = this._chart.ID;
      double? nullable = this._chart.Chart.Height;
      string str1 = nullable.ToString();
      nullable = this._chart.Chart.Width;
      string str2 = nullable.ToString();
      stringBuilder.AppendFormat(format1, (object) id1, (object) str1, (object) str2);
      string str3 = "<script type='text/javascript'>";
      stringBuilder.Append(str3);
      string format2 = "var {0};";
      string id2 = this._chart.ID;
      stringBuilder.AppendFormat(format2, (object) id2);
      string str4 = "jQuery(document).ready(function() {";
      stringBuilder.Append(str4);
      string format3 = "var {0}ChartOptions = {1};";
      string id3 = this._chart.ID;
      string startupOptions = this.GetStartupOptions();
      stringBuilder.AppendFormat(format3, (object) id3, (object) startupOptions);
      string format4 = "{0} = new Highcharts.Chart({0}ChartOptions);";
      string id4 = this._chart.ID;
      stringBuilder.AppendFormat(format4, (object) id4);
      string str5 = "});";
      stringBuilder.Append(str5);
      string str6 = "</script>";
      stringBuilder.Append(str6);
      return stringBuilder.ToString();
    }

    private string GetStartupOptions()
    {
      StringBuilder s = new StringBuilder();
      this.RenderChartSettings(s);
      return s.ToString();
    }

    private void RenderChartSettings(StringBuilder s)
    {
      Hashtable hashtable = this._chart.ToHashtable();
      List<Hashtable> hashtableList1 = new List<Hashtable>();
      List<Hashtable> hashtableList2 = new List<Hashtable>();
      if (this._chart.Series != null)
        hashtableList1 = this.SeriesToHashtables(this._chart.Series);
      if (this._chart.Drilldown.Series != null)
        hashtableList2 = this.SeriesToHashtables(this._chart.Drilldown.Series);
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
          int num = 1;
          lineSeries.Type = (LineSeriesType) num;
          hashtable = lineSeries.ToHashtable();
        }
        if (series is SplineSeries)
        {
          SplineSeries splineSeries = series as SplineSeries;
          splineSeries.Data.ForEach((Action<SplineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 2;
          splineSeries.Type = (SplineSeriesType) num;
          hashtable = splineSeries.ToHashtable();
        }
        if (series is AreaSeries)
        {
          AreaSeries areaSeries = series as AreaSeries;
          areaSeries.Data.ForEach((Action<AreaSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 4;
          areaSeries.Type = (AreaSeriesType) num;
          hashtable = areaSeries.ToHashtable();
        }
        if (series is AreasplineSeries)
        {
          AreasplineSeries areasplineSeries = series as AreasplineSeries;
          areasplineSeries.Data.ForEach((Action<AreasplineSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 5;
          areasplineSeries.Type = (AreasplineSeriesType) num;
          hashtable = areasplineSeries.ToHashtable();
        }
        if (series is ArearangeSeries)
        {
          ArearangeSeries arearangeSeries = series as ArearangeSeries;
          arearangeSeries.Data.ForEach((Action<ArearangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 7;
          arearangeSeries.Type = (ArearangeSeriesType) num;
          hashtable = arearangeSeries.ToHashtable();
        }
        if (series is ColumnrangeSeries)
        {
          ColumnrangeSeries columnrangeSeries = series as ColumnrangeSeries;
          columnrangeSeries.Data.ForEach((Action<ColumnrangeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 11;
          columnrangeSeries.Type = (ColumnrangeSeriesType) num;
          hashtable = columnrangeSeries.ToHashtable();
        }
        if (series is BarSeries)
        {
          BarSeries barSeries = series as BarSeries;
          barSeries.Data.ForEach((Action<BarSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 17;
          barSeries.Type = (BarSeriesType) num;
          hashtable = barSeries.ToHashtable();
        }
        if (series is ColumnSeries)
        {
          ColumnSeries columnSeries = series as ColumnSeries;
          columnSeries.Data.ForEach((Action<ColumnSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 3;
          columnSeries.Type = (ColumnSeriesType) num;
          hashtable = columnSeries.ToHashtable();
        }
        if (series is PieSeries)
        {
          PieSeries pieSeries = series as PieSeries;
          pieSeries.Data.ForEach((Action<PieSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 6;
          pieSeries.Type = (PieSeriesType) num;
          hashtable = pieSeries.ToHashtable();
        }
        if (series is ScatterSeries)
        {
          ScatterSeries scatterSeries = series as ScatterSeries;
          scatterSeries.Data.ForEach((Action<ScatterSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 15;
          scatterSeries.Type = (ScatterSeriesType) num;
          hashtable = scatterSeries.ToHashtable();
        }
        if (series is BubbleSeries)
        {
          BubbleSeries bubbleSeries = series as BubbleSeries;
          bubbleSeries.Data.ForEach((Action<BubbleSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 10;
          bubbleSeries.Type = (BubbleSeriesType) num;
          hashtable = bubbleSeries.ToHashtable();
        }
        if (series is GaugeSeries)
        {
          GaugeSeries gaugeSeries = series as GaugeSeries;
          gaugeSeries.Data.ForEach((Action<GaugeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 14;
          gaugeSeries.Type = (GaugeSeriesType) num;
          hashtable = gaugeSeries.ToHashtable();
        }
        if (series is SolidgaugeSeries)
        {
          SolidgaugeSeries solidgaugeSeries = series as SolidgaugeSeries;
          solidgaugeSeries.Data.ForEach((Action<SolidgaugeSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 22;
          solidgaugeSeries.Type = (SolidgaugeSeriesType) num;
          hashtable = solidgaugeSeries.ToHashtable();
        }
        if (series is HeatmapSeries)
        {
          HeatmapSeries heatmapSeries = series as HeatmapSeries;
          heatmapSeries.Data.ForEach((Action<HeatmapSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 18;
          heatmapSeries.Type = (HeatmapSeriesType) num;
          hashtable = heatmapSeries.ToHashtable();
        }
        if (series is BoxplotSeries)
        {
          BoxplotSeries boxplotSeries = series as BoxplotSeries;
          boxplotSeries.Data.ForEach((Action<BoxplotSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 9;
          boxplotSeries.Type = (BoxplotSeriesType) num;
          hashtable = boxplotSeries.ToHashtable();
        }
        if (series is ErrorbarSeries)
        {
          ErrorbarSeries errorbarSeries = series as ErrorbarSeries;
          errorbarSeries.Data.ForEach((Action<ErrorbarSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 12;
          errorbarSeries.Type = (ErrorbarSeriesType) num;
          hashtable = errorbarSeries.ToHashtable();
        }
        if (series is FunnelSeries)
        {
          FunnelSeries funnelSeries = series as FunnelSeries;
          funnelSeries.Data.ForEach((Action<FunnelSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 13;
          funnelSeries.Type = (FunnelSeriesType) num;
          hashtable = funnelSeries.ToHashtable();
        }
        if (series is PyramidSeries)
        {
          PyramidSeries pyramidSeries = series as PyramidSeries;
          pyramidSeries.Data.ForEach((Action<PyramidSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 19;
          pyramidSeries.Type = (PyramidSeriesType) num;
          hashtable = pyramidSeries.ToHashtable();
        }
        if (series is WaterfallSeries)
        {
          WaterfallSeries waterfallSeries = series as WaterfallSeries;
          waterfallSeries.Data.ForEach((Action<WaterfallSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 16;
          waterfallSeries.Type = (WaterfallSeriesType) num;
          hashtable = waterfallSeries.ToHashtable();
        }
        if (series is PolygonSeries)
        {
          PolygonSeries polygonSeries = series as PolygonSeries;
          polygonSeries.Data.ForEach((Action<PolygonSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 20;
          polygonSeries.Type = (PolygonSeriesType) num;
          hashtable = polygonSeries.ToHashtable();
        }
        if (series is TreemapSeries)
        {
          TreemapSeries treemapSeries = series as TreemapSeries;
          treemapSeries.Data.ForEach((Action<TreemapSeriesData>) (data => dataList.Add((object) data.ToHashtable())));
          int num = 21;
          treemapSeries.Type = (TreemapSeriesType) num;
          hashtable = treemapSeries.ToHashtable();
        }
        hashtable.Add((object) "data", (object) dataList);
        hashtableList.Add(hashtable);
      }
      return hashtableList;
    }
  }
}
