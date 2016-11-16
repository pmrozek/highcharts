
// Type: Highsoft.Web.Mvc.Charts.WaterfallSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class WaterfallSeries : Series
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderRadius { get; set; }

    private double? BorderRadius_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public bool? ColorByPoint { get; set; }

    private bool? ColorByPoint_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public WaterfallSeriesCursor Cursor { get; set; }

    private WaterfallSeriesCursor Cursor_DefaultValue { get; set; }

    public string DashStyle { get; set; }

    private string DashStyle_DefaultValue { get; set; }

    public List<WaterfallSeriesData> Data { get; set; }

    private List<WaterfallSeriesData> Data_DefaultValue { get; set; }

    public WaterfallSeriesDataLabels DataLabels { get; set; }

    private WaterfallSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public double? Depth { get; set; }

    private double? Depth_DefaultValue { get; set; }

    public string EdgeColor { get; set; }

    private string EdgeColor_DefaultValue { get; set; }

    public double? EdgeWidth { get; set; }

    private double? EdgeWidth_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public WaterfallSeriesEvents Events { get; set; }

    private WaterfallSeriesEvents Events_DefaultValue { get; set; }

    public double? GroupPadding { get; set; }

    private double? GroupPadding_DefaultValue { get; set; }

    public double? GroupZPadding { get; set; }

    private double? GroupZPadding_DefaultValue { get; set; }

    public bool? Grouping { get; set; }

    private bool? Grouping_DefaultValue { get; set; }

    public new string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public new double? Index { get; set; }

    private double? Index_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public new double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public string LineColor { get; set; }

    private string LineColor_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public double? MinPointLength { get; set; }

    private double? MinPointLength_DefaultValue { get; set; }

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public WaterfallSeriesPoint Point { get; set; }

    private WaterfallSeriesPoint Point_DefaultValue { get; set; }

    public double? PointInterval { get; set; }

    private double? PointInterval_DefaultValue { get; set; }

    public WaterfallSeriesPointIntervalUnit PointIntervalUnit { get; set; }

    private WaterfallSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

    public double? PointPadding { get; set; }

    private double? PointPadding_DefaultValue { get; set; }

    public PointPlacement PointPlacement { get; set; }

    private PointPlacement PointPlacement_DefaultValue { get; set; }

    public double? PointRange { get; set; }

    private double? PointRange_DefaultValue { get; set; }

    public double? PointStart { get; set; }

    private double? PointStart_DefaultValue { get; set; }

    public double? PointWidth { get; set; }

    private double? PointWidth_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public new string Stack { get; set; }

    private string Stack_DefaultValue { get; set; }

    public WaterfallSeriesStates States { get; set; }

    private WaterfallSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public double? Threshold { get; set; }

    private double? Threshold_DefaultValue { get; set; }

    public WaterfallSeriesTooltip Tooltip { get; set; }

    private WaterfallSeriesTooltip Tooltip_DefaultValue { get; set; }

    public WaterfallSeriesType Type { get; set; }

    private WaterfallSeriesType Type_DefaultValue { get; set; }

    public string UpColor { get; set; }

    private string UpColor_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public new string XAxis { get; set; }

    private string XAxis_DefaultValue { get; set; }

    public new string YAxis { get; set; }

    private string YAxis_DefaultValue { get; set; }

    public new double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public WaterfallSeriesZones Zones { get; set; }

    private WaterfallSeriesZones Zones_DefaultValue { get; set; }

    public WaterfallSeries()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.BorderColor = this.BorderColor_DefaultValue = "#333333";
      double? nullable2 = new double?(0.0);
      this.BorderRadius_DefaultValue = nullable2;
      this.BorderRadius = nullable2;
      nullable2 = new double?(1.0);
      this.BorderWidth_DefaultValue = nullable2;
      this.BorderWidth = nullable2;
      this.Color = this.Color_DefaultValue = (string) null;
      nullable1 = new bool?(false);
      this.ColorByPoint_DefaultValue = nullable1;
      this.ColorByPoint = nullable1;
      this.Colors = this.Colors_DefaultValue = new List<string>();
      this.Cursor = this.Cursor_DefaultValue = WaterfallSeriesCursor.Null;
      this.DashStyle = this.DashStyle_DefaultValue = "Dot";
      this.Data = this.Data_DefaultValue = new List<WaterfallSeriesData>();
      this.DataLabels = this.DataLabels_DefaultValue = new WaterfallSeriesDataLabels();
      nullable2 = new double?(25.0);
      this.Depth_DefaultValue = nullable2;
      this.Depth = nullable2;
      this.EdgeColor = this.EdgeColor_DefaultValue = "";
      nullable2 = new double?(1.0);
      this.EdgeWidth_DefaultValue = nullable2;
      this.EdgeWidth = nullable2;
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new WaterfallSeriesEvents();
      nullable2 = new double?(0.2);
      this.GroupPadding_DefaultValue = nullable2;
      this.GroupPadding = nullable2;
      nullable2 = new double?(1.0);
      this.GroupZPadding_DefaultValue = nullable2;
      this.GroupZPadding = nullable2;
      nullable1 = new bool?(true);
      this.Grouping_DefaultValue = nullable1;
      this.Grouping = nullable1;
      this.Id = this.Id_DefaultValue = "";
      double? nullable3 = new double?();
      this.Index_DefaultValue = nullable3;
      this.Index = nullable3;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable4 = new double?();
      this.LegendIndex_DefaultValue = nullable4;
      this.LegendIndex = nullable4;
      this.LineColor = this.LineColor_DefaultValue = "#333333";
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      nullable4 = new double?(0.0);
      this.MinPointLength_DefaultValue = nullable4;
      this.MinPointLength = nullable4;
      this.Name = this.Name_DefaultValue = (string) null;
      this.Point = this.Point_DefaultValue = new WaterfallSeriesPoint();
      nullable4 = new double?(1.0);
      this.PointInterval_DefaultValue = nullable4;
      this.PointInterval = nullable4;
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = WaterfallSeriesPointIntervalUnit.Null;
      nullable4 = new double?(0.1);
      this.PointPadding_DefaultValue = nullable4;
      this.PointPadding = nullable4;
      this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
      double? nullable5 = new double?();
      this.PointRange_DefaultValue = nullable5;
      this.PointRange = nullable5;
      nullable5 = new double?(0.0);
      this.PointStart_DefaultValue = nullable5;
      this.PointStart = nullable5;
      double? nullable6 = new double?();
      this.PointWidth_DefaultValue = nullable6;
      this.PointWidth = nullable6;
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      Shadow shadow1 = new Shadow();
      shadow1.Enabled = false;
      Shadow shadow2 = shadow1;
      this.Shadow_DefaultValue = shadow1;
      this.Shadow = shadow2;
      nullable1 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable1;
      this.ShowCheckbox = nullable1;
      nullable1 = new bool?(true);
      this.ShowInLegend_DefaultValue = nullable1;
      this.ShowInLegend = nullable1;
      this.Stack = this.Stack_DefaultValue = (string) null;
      this.States = this.States_DefaultValue = new WaterfallSeriesStates();
      nullable1 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      nullable6 = new double?(0.0);
      this.Threshold_DefaultValue = nullable6;
      this.Threshold = nullable6;
      this.Tooltip = this.Tooltip_DefaultValue = new WaterfallSeriesTooltip();
      this.Type = this.Type_DefaultValue = WaterfallSeriesType.Null;
      this.UpColor = this.UpColor_DefaultValue = "";
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.XAxis = this.XAxis_DefaultValue = "0";
      this.YAxis = this.YAxis_DefaultValue = "0";
      double? nullable7 = new double?();
      this.ZIndex_DefaultValue = nullable7;
      this.ZIndex = nullable7;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new WaterfallSeriesZones();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      bool? allowPointSelect = this.AllowPointSelect;
      bool? selectDefaultValue = this.AllowPointSelect_DefaultValue;
      if ((allowPointSelect.GetValueOrDefault() == selectDefaultValue.GetValueOrDefault() ? (allowPointSelect.HasValue != selectDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? borderRadius = this.BorderRadius;
      double? nullable1 = this.BorderRadius_DefaultValue;
      if ((borderRadius.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (borderRadius.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
      nullable1 = this.BorderWidth;
      double? nullable2 = this.BorderWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      bool? colorByPoint = this.ColorByPoint;
      bool? nullable3 = this.ColorByPoint_DefaultValue;
      if ((colorByPoint.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (colorByPoint.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "colorByPoint", (object) this.ColorByPoint);
      if (this.Colors != this.Colors_DefaultValue)
        hashtable.Add((object) "colors", (object) this.Colors);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DashStyle != this.DashStyle_DefaultValue)
        hashtable.Add((object) "dashStyle", (object) this.DashStyle);
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      nullable2 = this.Depth;
      nullable1 = this.Depth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "depth", (object) this.Depth);
      if (this.EdgeColor != this.EdgeColor_DefaultValue)
        hashtable.Add((object) "edgeColor", (object) this.EdgeColor);
      nullable1 = this.EdgeWidth;
      nullable2 = this.EdgeWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "edgeWidth", (object) this.EdgeWidth);
      nullable3 = this.EnableMouseTracking;
      bool? nullable4 = this.EnableMouseTracking_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      nullable2 = this.GroupPadding;
      nullable1 = this.GroupPadding_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "groupPadding", (object) this.GroupPadding);
      nullable1 = this.GroupZPadding;
      nullable2 = this.GroupZPadding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "groupZPadding", (object) this.GroupZPadding);
      nullable4 = this.Grouping;
      nullable3 = this.Grouping_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "grouping", (object) this.Grouping);
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      nullable2 = this.Index;
      nullable1 = this.Index_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "index", (object) this.Index);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable1 = this.LegendIndex;
      nullable2 = this.LegendIndex_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      nullable2 = this.MinPointLength;
      nullable1 = this.MinPointLength_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minPointLength", (object) this.MinPointLength);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable1 = this.PointInterval;
      nullable2 = this.PointInterval_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointInterval", (object) this.PointInterval);
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highcharts.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      nullable2 = this.PointPadding;
      nullable1 = this.PointPadding_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointPadding", (object) this.PointPadding);
      if (this.PointPlacement.IsDirty())
        hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
      nullable1 = this.PointRange;
      nullable2 = this.PointRange_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointRange", (object) this.PointRange);
      nullable2 = this.PointStart;
      nullable1 = this.PointStart_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointStart", (object) this.PointStart);
      nullable1 = this.PointWidth;
      nullable2 = this.PointWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointWidth", (object) this.PointWidth);
      nullable3 = this.Selected;
      nullable4 = this.Selected_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable4 = this.ShowCheckbox;
      nullable3 = this.ShowCheckbox_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable3 = this.ShowInLegend;
      nullable4 = this.ShowInLegend_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.Stack != this.Stack_DefaultValue)
        hashtable.Add((object) "stack", (object) this.Stack);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable4 = this.StickyTracking;
      nullable3 = this.StickyTracking_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      nullable2 = this.Threshold;
      nullable1 = this.Threshold_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "threshold", (object) this.Threshold);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
      if (this.UpColor != this.UpColor_DefaultValue)
        hashtable.Add((object) "upColor", (object) this.UpColor);
      nullable3 = this.Visible;
      nullable4 = this.Visible_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      if (this.XAxis != this.XAxis_DefaultValue)
        hashtable.Add((object) "xAxis", (object) this.XAxis);
      if (this.YAxis != this.YAxis_DefaultValue)
        hashtable.Add((object) "yAxis", (object) this.YAxis);
      nullable1 = this.ZIndex;
      nullable2 = this.ZIndex_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "zIndex", (object) this.ZIndex);
      if (this.ZoneAxis != this.ZoneAxis_DefaultValue)
        hashtable.Add((object) "zoneAxis", (object) this.ZoneAxis);
      if (this.Zones.IsDirty())
        hashtable.Add((object) "zones", (object) this.Zones.ToHashtable());
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
  }
}
