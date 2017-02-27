// Type: Highsoft.Web.Mvc.Charts.Highcharts


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Highcharts : BaseObject
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

        public Data Data { get; set; }

        private Data Data_DefaultValue { get; set; }

        public object Defs { get; set; }

        private object Defs_DefaultValue { get; set; }

        public Drilldown Drilldown { get; set; }

        private Drilldown Drilldown_DefaultValue { get; set; }

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

        public NoData NoData { get; set; }

        private NoData NoData_DefaultValue { get; set; }

        public Pane Pane { get; set; }

        private Pane Pane_DefaultValue { get; set; }

        public PlotOptions PlotOptions { get; set; }

        private PlotOptions PlotOptions_DefaultValue { get; set; }

        public Responsive Responsive { get; set; }

        private Responsive Responsive_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Charts.Series> Series { get; set; }

        private List<Highsoft.Web.Mvc.Charts.Series> Series_DefaultValue { get; set; }

        public AreaSeries AreaSeries { get; set; }

        private AreaSeries AreaSeries_DefaultValue { get; set; }

        public ArearangeSeries ArearangeSeries { get; set; }

        private ArearangeSeries ArearangeSeries_DefaultValue { get; set; }

        public AreasplineSeries AreasplineSeries { get; set; }

        private AreasplineSeries AreasplineSeries_DefaultValue { get; set; }

        public AreasplinerangeSeries AreasplinerangeSeries { get; set; }

        private AreasplinerangeSeries AreasplinerangeSeries_DefaultValue { get; set; }

        public BarSeries BarSeries { get; set; }

        private BarSeries BarSeries_DefaultValue { get; set; }

        public BoxplotSeries BoxplotSeries { get; set; }

        private BoxplotSeries BoxplotSeries_DefaultValue { get; set; }

        public BubbleSeries BubbleSeries { get; set; }

        private BubbleSeries BubbleSeries_DefaultValue { get; set; }

        public ColumnSeries ColumnSeries { get; set; }

        private ColumnSeries ColumnSeries_DefaultValue { get; set; }

        public ColumnrangeSeries ColumnrangeSeries { get; set; }

        private ColumnrangeSeries ColumnrangeSeries_DefaultValue { get; set; }

        public ErrorbarSeries ErrorbarSeries { get; set; }

        private ErrorbarSeries ErrorbarSeries_DefaultValue { get; set; }

        public FunnelSeries FunnelSeries { get; set; }

        private FunnelSeries FunnelSeries_DefaultValue { get; set; }

        public GaugeSeries GaugeSeries { get; set; }

        private GaugeSeries GaugeSeries_DefaultValue { get; set; }

        public HeatmapSeries HeatmapSeries { get; set; }

        private HeatmapSeries HeatmapSeries_DefaultValue { get; set; }

        public LineSeries LineSeries { get; set; }

        private LineSeries LineSeries_DefaultValue { get; set; }

        public PieSeries PieSeries { get; set; }

        private PieSeries PieSeries_DefaultValue { get; set; }

        public PolygonSeries PolygonSeries { get; set; }

        private PolygonSeries PolygonSeries_DefaultValue { get; set; }

        public PyramidSeries PyramidSeries { get; set; }

        private PyramidSeries PyramidSeries_DefaultValue { get; set; }

        public ScatterSeries ScatterSeries { get; set; }

        private ScatterSeries ScatterSeries_DefaultValue { get; set; }

        public SolidgaugeSeries SolidgaugeSeries { get; set; }

        private SolidgaugeSeries SolidgaugeSeries_DefaultValue { get; set; }

        public SplineSeries SplineSeries { get; set; }

        private SplineSeries SplineSeries_DefaultValue { get; set; }

        public TreemapSeries TreemapSeries { get; set; }

        private TreemapSeries TreemapSeries_DefaultValue { get; set; }

        public WaterfallSeries WaterfallSeries { get; set; }

        private WaterfallSeries WaterfallSeries_DefaultValue { get; set; }

        public Subtitle Subtitle { get; set; }

        private Subtitle Subtitle_DefaultValue { get; set; }

        public Title Title { get; set; }

        private Title Title_DefaultValue { get; set; }

        public Tooltip Tooltip { get; set; }

        private Tooltip Tooltip_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Charts.XAxis> XAxis { get; set; }

        private List<Highsoft.Web.Mvc.Charts.XAxis> XAxis_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Charts.YAxis> YAxis { get; set; }

        private List<Highsoft.Web.Mvc.Charts.YAxis> YAxis_DefaultValue { get; set; }

        public ZAxis ZAxis { get; set; }

        private ZAxis ZAxis_DefaultValue { get; set; }

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

        public Highcharts()
        {
            this.Accessibility = this.Accessibility_DefaultValue = new Accessibility();
            this.Chart = this.Chart_DefaultValue = new Chart();
            this.Colors = this.Colors_DefaultValue = new List<string>();
            this.Credits = this.Credits_DefaultValue = new Credits();
            this.Data = this.Data_DefaultValue = new Data();
            this.Defs = this.Defs_DefaultValue = (object) null;
            this.Drilldown = this.Drilldown_DefaultValue = new Drilldown();
            this.Exporting = this.Exporting_DefaultValue = new Exporting();
            this.Global = this.Global_DefaultValue = new Global();
            this.Labels = this.Labels_DefaultValue = new Labels();
            this.Lang = this.Lang_DefaultValue = new Lang();
            this.Legend = this.Legend_DefaultValue = new Legend();
            this.Loading = this.Loading_DefaultValue = new Loading();
            this.Navigation = this.Navigation_DefaultValue = new Navigation();
            this.NoData = this.NoData_DefaultValue = new NoData();
            this.Pane = this.Pane_DefaultValue = new Pane();
            this.PlotOptions = this.PlotOptions_DefaultValue = new PlotOptions();
            this.Responsive = this.Responsive_DefaultValue = new Responsive();
            this.Series = this.Series_DefaultValue = new List<Highsoft.Web.Mvc.Charts.Series>();
            this.AreaSeries = this.AreaSeries_DefaultValue = new AreaSeries();
            this.ArearangeSeries = this.ArearangeSeries_DefaultValue = new ArearangeSeries();
            this.AreasplineSeries = this.AreasplineSeries_DefaultValue = new AreasplineSeries();
            this.AreasplinerangeSeries = this.AreasplinerangeSeries_DefaultValue = new AreasplinerangeSeries();
            this.BarSeries = this.BarSeries_DefaultValue = new BarSeries();
            this.BoxplotSeries = this.BoxplotSeries_DefaultValue = new BoxplotSeries();
            this.BubbleSeries = this.BubbleSeries_DefaultValue = new BubbleSeries();
            this.ColumnSeries = this.ColumnSeries_DefaultValue = new ColumnSeries();
            this.ColumnrangeSeries = this.ColumnrangeSeries_DefaultValue = new ColumnrangeSeries();
            this.ErrorbarSeries = this.ErrorbarSeries_DefaultValue = new ErrorbarSeries();
            this.FunnelSeries = this.FunnelSeries_DefaultValue = new FunnelSeries();
            this.GaugeSeries = this.GaugeSeries_DefaultValue = new GaugeSeries();
            this.HeatmapSeries = this.HeatmapSeries_DefaultValue = new HeatmapSeries();
            this.LineSeries = this.LineSeries_DefaultValue = new LineSeries();
            this.PieSeries = this.PieSeries_DefaultValue = new PieSeries();
            this.PolygonSeries = this.PolygonSeries_DefaultValue = new PolygonSeries();
            this.PyramidSeries = this.PyramidSeries_DefaultValue = new PyramidSeries();
            this.ScatterSeries = this.ScatterSeries_DefaultValue = new ScatterSeries();
            this.SolidgaugeSeries = this.SolidgaugeSeries_DefaultValue = new SolidgaugeSeries();
            this.SplineSeries = this.SplineSeries_DefaultValue = new SplineSeries();
            this.TreemapSeries = this.TreemapSeries_DefaultValue = new TreemapSeries();
            this.WaterfallSeries = this.WaterfallSeries_DefaultValue = new WaterfallSeries();
            this.Subtitle = this.Subtitle_DefaultValue = new Subtitle();
            this.Title = this.Title_DefaultValue = new Title();
            this.Tooltip = this.Tooltip_DefaultValue = new Tooltip();
            this.XAxis = this.XAxis_DefaultValue = new List<Highsoft.Web.Mvc.Charts.XAxis>();
            this.YAxis = this.YAxis_DefaultValue = new List<Highsoft.Web.Mvc.Charts.YAxis>();
            this.ZAxis = this.ZAxis_DefaultValue = new ZAxis();
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
            if (this.Data.IsDirty())
                hashtable.Add((object) "data", (object) this.Data.ToHashtable());
            if (this.Defs != this.Defs_DefaultValue)
                hashtable.Add((object) "defs", this.Defs);
            if (this.Drilldown.IsDirty())
                hashtable.Add((object) "drilldown", (object) this.Drilldown.ToHashtable());
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
            if (this.NoData.IsDirty())
                hashtable.Add((object) "noData", (object) this.NoData.ToHashtable());
            if (this.Pane.IsDirty())
                hashtable.Add((object) "pane", (object) this.Pane.ToHashtable());
            if (this.PlotOptions.IsDirty())
                hashtable.Add((object) "plotOptions", (object) this.PlotOptions.ToHashtable());
            if (this.Responsive.IsDirty())
                hashtable.Add((object) "responsive", (object) this.Responsive.ToHashtable());
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
            if (this.BarSeries.IsDirty())
                hashtable.Add((object) "barSeries", (object) this.BarSeries.ToHashtable());
            if (this.BoxplotSeries.IsDirty())
                hashtable.Add((object) "boxplotSeries", (object) this.BoxplotSeries.ToHashtable());
            if (this.BubbleSeries.IsDirty())
                hashtable.Add((object) "bubbleSeries", (object) this.BubbleSeries.ToHashtable());
            if (this.ColumnSeries.IsDirty())
                hashtable.Add((object) "columnSeries", (object) this.ColumnSeries.ToHashtable());
            if (this.ColumnrangeSeries.IsDirty())
                hashtable.Add((object) "columnrangeSeries", (object) this.ColumnrangeSeries.ToHashtable());
            if (this.ErrorbarSeries.IsDirty())
                hashtable.Add((object) "errorbarSeries", (object) this.ErrorbarSeries.ToHashtable());
            if (this.FunnelSeries.IsDirty())
                hashtable.Add((object) "funnelSeries", (object) this.FunnelSeries.ToHashtable());
            if (this.GaugeSeries.IsDirty())
                hashtable.Add((object) "gaugeSeries", (object) this.GaugeSeries.ToHashtable());
            if (this.HeatmapSeries.IsDirty())
                hashtable.Add((object) "heatmapSeries", (object) this.HeatmapSeries.ToHashtable());
            if (this.LineSeries.IsDirty())
                hashtable.Add((object) "lineSeries", (object) this.LineSeries.ToHashtable());
            if (this.PieSeries.IsDirty())
                hashtable.Add((object) "pieSeries", (object) this.PieSeries.ToHashtable());
            if (this.PolygonSeries.IsDirty())
                hashtable.Add((object) "polygonSeries", (object) this.PolygonSeries.ToHashtable());
            if (this.PyramidSeries.IsDirty())
                hashtable.Add((object) "pyramidSeries", (object) this.PyramidSeries.ToHashtable());
            if (this.ScatterSeries.IsDirty())
                hashtable.Add((object) "scatterSeries", (object) this.ScatterSeries.ToHashtable());
            if (this.SolidgaugeSeries.IsDirty())
                hashtable.Add((object) "solidgaugeSeries", (object) this.SolidgaugeSeries.ToHashtable());
            if (this.SplineSeries.IsDirty())
                hashtable.Add((object) "splineSeries", (object) this.SplineSeries.ToHashtable());
            if (this.TreemapSeries.IsDirty())
                hashtable.Add((object) "treemapSeries", (object) this.TreemapSeries.ToHashtable());
            if (this.WaterfallSeries.IsDirty())
                hashtable.Add((object) "waterfallSeries", (object) this.WaterfallSeries.ToHashtable());
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
            if (this.ZAxis.IsDirty())
                hashtable.Add((object) "zAxis", (object) this.ZAxis.ToHashtable());
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
            Highcharts.functions[(object) eventName] = (object) functionName;
        }

        public static string FirstCharacterToLower(string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsLower(str, 0))
                return str;
            return char.ToLowerInvariant(str[0]).ToString() + str.Substring(1);
        }
    }
}