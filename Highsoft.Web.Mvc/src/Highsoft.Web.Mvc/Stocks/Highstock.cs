// Type: Highsoft.Web.Mvc.Stocks.Highstock


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Highsoft.Web.Mvc.Stocks.Rendering;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Highstock : BaseObject
    {
        internal static Hashtable functions = new Hashtable();

        public Accessibility Accessibility { get; set; }

        private Accessibility Accessibility_DefaultValue { get; set; }

        public Chart Chart { get; set; }

        private Chart Chart_DefaultValue { get; set; }

        public List<string> Colors { get; set; }

        private List<string> Colors_DefaultValue { get; set; }

        public Credits Credits { get; set; }

        private Credits Credits_DefaultValue { get; set; }

        public object Defs { get; set; }

        private object Defs_DefaultValue { get; set; }

        public Exporting Exporting { get; set; }

        private Exporting Exporting_DefaultValue { get; set; }

        public Global Global { get; set; }

        private Global Global_DefaultValue { get; set; }

        public Labels Labels { get; set; }

        private Labels Labels_DefaultValue { get; set; }

        public Lang Lang { get; set; }

        private Lang Lang_DefaultValue { get; set; }

        public Legend Legend { get; set; }

        private Legend Legend_DefaultValue { get; set; }

        public Loading Loading { get; set; }

        private Loading Loading_DefaultValue { get; set; }

        public Navigation Navigation { get; set; }

        private Navigation Navigation_DefaultValue { get; set; }

        public Navigator Navigator { get; set; }

        private Navigator Navigator_DefaultValue { get; set; }

        public NoData NoData { get; set; }

        private NoData NoData_DefaultValue { get; set; }

        public PlotOptions PlotOptions { get; set; }

        private PlotOptions PlotOptions_DefaultValue { get; set; }

        public RangeSelector RangeSelector { get; set; }

        private RangeSelector RangeSelector_DefaultValue { get; set; }

        public Responsive Responsive { get; set; }

        private Responsive Responsive_DefaultValue { get; set; }

        public Scrollbar Scrollbar { get; set; }

        private Scrollbar Scrollbar_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Stocks.Series> Series { get; set; }

        private List<Highsoft.Web.Mvc.Stocks.Series> Series_DefaultValue { get; set; }

        public AreaSeries AreaSeries { get; set; }

        private AreaSeries AreaSeries_DefaultValue { get; set; }

        public ArearangeSeries ArearangeSeries { get; set; }

        private ArearangeSeries ArearangeSeries_DefaultValue { get; set; }

        public AreasplineSeries AreasplineSeries { get; set; }

        private AreasplineSeries AreasplineSeries_DefaultValue { get; set; }

        public AreasplinerangeSeries AreasplinerangeSeries { get; set; }

        private AreasplinerangeSeries AreasplinerangeSeries_DefaultValue { get; set; }

        public CandleStickSeries CandleStickSeries { get; set; }

        private CandleStickSeries CandleStickSeries_DefaultValue { get; set; }

        public ColumnSeries ColumnSeries { get; set; }

        private ColumnSeries ColumnSeries_DefaultValue { get; set; }

        public ColumnrangeSeries ColumnrangeSeries { get; set; }

        private ColumnrangeSeries ColumnrangeSeries_DefaultValue { get; set; }

        public FlagsSeries FlagsSeries { get; set; }

        private FlagsSeries FlagsSeries_DefaultValue { get; set; }

        public LineSeries LineSeries { get; set; }

        private LineSeries LineSeries_DefaultValue { get; set; }

        public OhlcSeries OhlcSeries { get; set; }

        private OhlcSeries OhlcSeries_DefaultValue { get; set; }

        public PolygonSeries PolygonSeries { get; set; }

        private PolygonSeries PolygonSeries_DefaultValue { get; set; }

        public ScatterSeries ScatterSeries { get; set; }

        private ScatterSeries ScatterSeries_DefaultValue { get; set; }

        public SplineSeries SplineSeries { get; set; }

        private SplineSeries SplineSeries_DefaultValue { get; set; }

        public Subtitle Subtitle { get; set; }

        private Subtitle Subtitle_DefaultValue { get; set; }

        public Title Title { get; set; }

        private Title Title_DefaultValue { get; set; }

        public Tooltip Tooltip { get; set; }

        private Tooltip Tooltip_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Stocks.XAxis> XAxis { get; set; }

        private List<Highsoft.Web.Mvc.Stocks.XAxis> XAxis_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Stocks.YAxis> YAxis { get; set; }

        private List<Highsoft.Web.Mvc.Stocks.YAxis> YAxis_DefaultValue { get; set; }

        public ColorAxis ColorAxis { get; set; }

        private ColorAxis ColorAxis_DefaultValue { get; set; }

        public List<Stop> Stops { get; set; }

        private List<Stop> Stops_DefaultValue { get; set; }

        public double? Min { get; set; }

        private double? Min_DefaultValue { get; set; }

        public double? Max { get; set; }

        private double? Max_DefaultValue { get; set; }

        public bool? StartOnTick { get; set; }

        private bool? StartOnTick_DefaultValue { get; set; }

        public bool? EndOnTick { get; set; }

        private bool? EndOnTick_DefaultValue { get; set; }

        public string MinColor { get; set; }

        private string MinColor_DefaultValue { get; set; }

        public string MaxColor { get; set; }

        private string MaxColor_DefaultValue { get; set; }

        public string ID { get; set; }

        public Highstock()
        {
            this.Accessibility = this.Accessibility_DefaultValue = new Accessibility();
            this.Chart = this.Chart_DefaultValue = new Chart();
            this.Colors = this.Colors_DefaultValue = new List<string>();
            this.Credits = this.Credits_DefaultValue = new Credits();
            this.Defs = this.Defs_DefaultValue = (object) null;
            this.Exporting = this.Exporting_DefaultValue = new Exporting();
            this.Global = this.Global_DefaultValue = new Global();
            this.Labels = this.Labels_DefaultValue = new Labels();
            this.Lang = this.Lang_DefaultValue = new Lang();
            this.Legend = this.Legend_DefaultValue = new Legend();
            this.Loading = this.Loading_DefaultValue = new Loading();
            this.Navigation = this.Navigation_DefaultValue = new Navigation();
            this.Navigator = this.Navigator_DefaultValue = new Navigator();
            this.NoData = this.NoData_DefaultValue = new NoData();
            this.PlotOptions = this.PlotOptions_DefaultValue = new PlotOptions();
            this.RangeSelector = this.RangeSelector_DefaultValue = new RangeSelector();
            this.Responsive = this.Responsive_DefaultValue = new Responsive();
            this.Scrollbar = this.Scrollbar_DefaultValue = new Scrollbar();
            this.Series = this.Series_DefaultValue = new List<Highsoft.Web.Mvc.Stocks.Series>();
            this.AreaSeries = this.AreaSeries_DefaultValue = new AreaSeries();
            this.ArearangeSeries = this.ArearangeSeries_DefaultValue = new ArearangeSeries();
            this.AreasplineSeries = this.AreasplineSeries_DefaultValue = new AreasplineSeries();
            this.AreasplinerangeSeries = this.AreasplinerangeSeries_DefaultValue = new AreasplinerangeSeries();
            this.CandleStickSeries = this.CandleStickSeries_DefaultValue = new CandleStickSeries();
            this.ColumnSeries = this.ColumnSeries_DefaultValue = new ColumnSeries();
            this.ColumnrangeSeries = this.ColumnrangeSeries_DefaultValue = new ColumnrangeSeries();
            this.FlagsSeries = this.FlagsSeries_DefaultValue = new FlagsSeries();
            this.LineSeries = this.LineSeries_DefaultValue = new LineSeries();
            this.OhlcSeries = this.OhlcSeries_DefaultValue = new OhlcSeries();
            this.PolygonSeries = this.PolygonSeries_DefaultValue = new PolygonSeries();
            this.ScatterSeries = this.ScatterSeries_DefaultValue = new ScatterSeries();
            this.SplineSeries = this.SplineSeries_DefaultValue = new SplineSeries();
            this.Subtitle = this.Subtitle_DefaultValue = new Subtitle();
            this.Title = this.Title_DefaultValue = new Title();
            this.Tooltip = this.Tooltip_DefaultValue = new Tooltip();
            this.XAxis = this.XAxis_DefaultValue = new List<Highsoft.Web.Mvc.Stocks.XAxis>();
            this.YAxis = this.YAxis_DefaultValue = new List<Highsoft.Web.Mvc.Stocks.YAxis>();
            this.ColorAxis = this.ColorAxis_DefaultValue = new ColorAxis();
            this.Stops = this.Stops_DefaultValue = (List<Stop>) null;
            double? nullable1 = new double?();
            this.Min_DefaultValue = nullable1;
            this.Min = nullable1;
            double? nullable2 = new double?();
            this.Max_DefaultValue = nullable2;
            this.Max = nullable2;
            bool? nullable3 = new bool?(false);
            this.StartOnTick_DefaultValue = nullable3;
            this.StartOnTick = nullable3;
            nullable3 = new bool?(false);
            this.EndOnTick_DefaultValue = nullable3;
            this.EndOnTick = nullable3;
            this.MinColor = this.MinColor_DefaultValue = (string) null;
            this.MaxColor = this.MaxColor_DefaultValue = (string) null;
        }

        public string ToJsonOptions()
        {
            return new HighstockRenderer(this).GetJsonOptions();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Accessibility.IsDirty())
                hashtable.Add((object) "accessibility", (object) this.Accessibility.ToHashtable());
            if (this.Chart.IsDirty())
                hashtable.Add((object) "chart", (object) this.Chart.ToHashtable());
            if (this.Colors != this.Colors_DefaultValue)
                hashtable.Add((object) "colors", (object) this.Colors);
            if (this.Credits.IsDirty())
                hashtable.Add((object) "credits", (object) this.Credits.ToHashtable());
            if (this.Defs != this.Defs_DefaultValue)
                hashtable.Add((object) "defs", this.Defs);
            if (this.Exporting.IsDirty())
                hashtable.Add((object) "exporting", (object) this.Exporting.ToHashtable());
            if (this.Global.IsDirty())
                hashtable.Add((object) "global", (object) this.Global.ToHashtable());
            if (this.Labels.IsDirty())
                hashtable.Add((object) "labels", (object) this.Labels.ToHashtable());
            if (this.Lang.IsDirty())
                hashtable.Add((object) "lang", (object) this.Lang.ToHashtable());
            if (this.Legend.IsDirty())
                hashtable.Add((object) "legend", (object) this.Legend.ToHashtable());
            if (this.Loading.IsDirty())
                hashtable.Add((object) "loading", (object) this.Loading.ToHashtable());
            if (this.Navigation.IsDirty())
                hashtable.Add((object) "navigation", (object) this.Navigation.ToHashtable());
            if (this.Navigator.IsDirty())
                hashtable.Add((object) "navigator", (object) this.Navigator.ToHashtable());
            if (this.NoData.IsDirty())
                hashtable.Add((object) "noData", (object) this.NoData.ToHashtable());
            if (this.PlotOptions.IsDirty())
                hashtable.Add((object) "plotOptions", (object) this.PlotOptions.ToHashtable());
            if (this.RangeSelector.IsDirty())
                hashtable.Add((object) "rangeSelector", (object) this.RangeSelector.ToHashtable());
            if (this.Responsive.IsDirty())
                hashtable.Add((object) "responsive", (object) this.Responsive.ToHashtable());
            if (this.Scrollbar.IsDirty())
                hashtable.Add((object) "scrollbar", (object) this.Scrollbar.ToHashtable());
            if (this.Series != this.Series_DefaultValue)
                hashtable.Add((object) "series", (object) this.Series);
            if (this.AreaSeries.IsDirty())
                hashtable.Add((object) "areaSeries", (object) this.AreaSeries.ToHashtable());
            if (this.ArearangeSeries.IsDirty())
                hashtable.Add((object) "arearangeSeries", (object) this.ArearangeSeries.ToHashtable());
            if (this.AreasplineSeries.IsDirty())
                hashtable.Add((object) "areasplineSeries", (object) this.AreasplineSeries.ToHashtable());
            if (this.AreasplinerangeSeries.IsDirty())
                hashtable.Add((object) "areasplinerangeSeries", (object) this.AreasplinerangeSeries.ToHashtable());
            if (this.CandleStickSeries.IsDirty())
                hashtable.Add((object) "candleStickSeries", (object) this.CandleStickSeries.ToHashtable());
            if (this.ColumnSeries.IsDirty())
                hashtable.Add((object) "columnSeries", (object) this.ColumnSeries.ToHashtable());
            if (this.ColumnrangeSeries.IsDirty())
                hashtable.Add((object) "columnrangeSeries", (object) this.ColumnrangeSeries.ToHashtable());
            if (this.FlagsSeries.IsDirty())
                hashtable.Add((object) "flagsSeries", (object) this.FlagsSeries.ToHashtable());
            if (this.LineSeries.IsDirty())
                hashtable.Add((object) "lineSeries", (object) this.LineSeries.ToHashtable());
            if (this.OhlcSeries.IsDirty())
                hashtable.Add((object) "ohlcSeries", (object) this.OhlcSeries.ToHashtable());
            if (this.PolygonSeries.IsDirty())
                hashtable.Add((object) "polygonSeries", (object) this.PolygonSeries.ToHashtable());
            if (this.ScatterSeries.IsDirty())
                hashtable.Add((object) "scatterSeries", (object) this.ScatterSeries.ToHashtable());
            if (this.SplineSeries.IsDirty())
                hashtable.Add((object) "splineSeries", (object) this.SplineSeries.ToHashtable());
            if (this.Subtitle.IsDirty())
                hashtable.Add((object) "subtitle", (object) this.Subtitle.ToHashtable());
            if (this.Title.IsDirty())
                hashtable.Add((object) "title", (object) this.Title.ToHashtable());
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.HashifyList((IEnumerable) this.XAxis));
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.HashifyList((IEnumerable) this.YAxis));
            if (this.ColorAxis.IsDirty())
                hashtable.Add((object) "colorAxis", (object) this.ColorAxis.ToHashtable());
            if (this.Stops != this.Stops_DefaultValue)
                hashtable.Add((object) "stops", (object) this.HashifyList((IEnumerable) this.Stops));
            double? nullable1 = this.Min;
            double? nullable2 = this.Min_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "min", (object) this.Min);
            nullable2 = this.Max;
            nullable1 = this.Max_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "max", (object) this.Max);
            bool? nullable3 = this.StartOnTick;
            bool? nullable4 = this.StartOnTick_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "startOnTick", (object) this.StartOnTick);
            nullable4 = this.EndOnTick;
            nullable3 = this.EndOnTick_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "endOnTick", (object) this.EndOnTick);
            if (this.MinColor != this.MinColor_DefaultValue)
                hashtable.Add((object) "minColor", (object) this.MinColor);
            if (this.MaxColor != this.MaxColor_DefaultValue)
                hashtable.Add((object) "maxColor", (object) this.MaxColor);
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.ToHashtable().Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }

        internal static void AddFunction(string eventName, string functionName)
        {
            Highstock.functions[(object) eventName] = (object) functionName;
        }

        public static string FirstCharacterToLower(string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsLower(str, 0))
                return str;
            return char.ToLowerInvariant(str[0]).ToString() + str.Substring(1);
        }
    }
}