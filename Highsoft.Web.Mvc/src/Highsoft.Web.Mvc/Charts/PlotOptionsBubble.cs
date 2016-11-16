
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBubble




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsBubble : BaseObject
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public double? CropThreshold { get; set; }

    private double? CropThreshold_DefaultValue { get; set; }

    public PlotOptionsBubbleCursor Cursor { get; set; }

    private PlotOptionsBubbleCursor Cursor_DefaultValue { get; set; }

    public PlotOptionsBubbleDashStyle DashStyle { get; set; }

    private PlotOptionsBubbleDashStyle DashStyle_DefaultValue { get; set; }

    public PlotOptionsBubbleDataLabels DataLabels { get; set; }

    private PlotOptionsBubbleDataLabels DataLabels_DefaultValue { get; set; }

    public bool? DisplayNegative { get; set; }

    private bool? DisplayNegative_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public PlotOptionsBubbleEvents Events { get; set; }

    private PlotOptionsBubbleEvents Events_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public PlotOptionsBubbleMarker Marker { get; set; }

    private PlotOptionsBubbleMarker Marker_DefaultValue { get; set; }

    public string MaxSize { get; set; }

    private string MaxSize_DefaultValue { get; set; }

    public string MinSize { get; set; }

    private string MinSize_DefaultValue { get; set; }

    public string NegativeColor { get; set; }

    private string NegativeColor_DefaultValue { get; set; }

    public PlotOptionsBubblePoint Point { get; set; }

    private PlotOptionsBubblePoint Point_DefaultValue { get; set; }

    public double? PointInterval { get; set; }

    private double? PointInterval_DefaultValue { get; set; }

    public PlotOptionsBubblePointIntervalUnit PointIntervalUnit { get; set; }

    private PlotOptionsBubblePointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

    public double? PointStart { get; set; }

    private double? PointStart_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public PlotOptionsBubbleSizeBy SizeBy { get; set; }

    private PlotOptionsBubbleSizeBy SizeBy_DefaultValue { get; set; }

    public PlotOptionsBubbleStates States { get; set; }

    private PlotOptionsBubbleStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public double? Threshold { get; set; }

    private double? Threshold_DefaultValue { get; set; }

    public PlotOptionsBubbleTooltip Tooltip { get; set; }

    private PlotOptionsBubbleTooltip Tooltip_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public double? ZMax { get; set; }

    private double? ZMax_DefaultValue { get; set; }

    public double? ZMin { get; set; }

    private double? ZMin_DefaultValue { get; set; }

    public double? ZThreshold { get; set; }

    private double? ZThreshold_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsBubbleZones Zones { get; set; }

    private PlotOptionsBubbleZones Zones_DefaultValue { get; set; }

    public PlotOptionsBubble()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.Color = this.Color_DefaultValue = (string) null;
      double? nullable2 = new double?(300.0);
      this.CropThreshold_DefaultValue = nullable2;
      this.CropThreshold = nullable2;
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsBubbleCursor.Null;
      this.DashStyle = this.DashStyle_DefaultValue = PlotOptionsBubbleDashStyle.Solid;
      this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsBubbleDataLabels();
      nullable1 = new bool?(true);
      this.DisplayNegative_DefaultValue = nullable1;
      this.DisplayNegative = nullable1;
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new PlotOptionsBubbleEvents();
      this.Keys = this.Keys_DefaultValue = new List<string>();
      nullable2 = new double?(0.0);
      this.LineWidth_DefaultValue = nullable2;
      this.LineWidth = nullable2;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Marker = this.Marker_DefaultValue = new PlotOptionsBubbleMarker();
      this.MaxSize = this.MaxSize_DefaultValue = "20%";
      this.MinSize = this.MinSize_DefaultValue = "8";
      this.NegativeColor = this.NegativeColor_DefaultValue = "null";
      this.Point = this.Point_DefaultValue = new PlotOptionsBubblePoint();
      nullable2 = new double?(1.0);
      this.PointInterval_DefaultValue = nullable2;
      this.PointInterval = nullable2;
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsBubblePointIntervalUnit.Null;
      nullable2 = new double?(0.0);
      this.PointStart_DefaultValue = nullable2;
      this.PointStart = nullable2;
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
      this.SizeBy = this.SizeBy_DefaultValue = PlotOptionsBubbleSizeBy.Area;
      this.States = this.States_DefaultValue = new PlotOptionsBubbleStates();
      nullable1 = new bool?(false);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      nullable2 = new double?(0.0);
      this.Threshold_DefaultValue = nullable2;
      this.Threshold = nullable2;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsBubbleTooltip();
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      double? nullable3 = new double?();
      this.ZMax_DefaultValue = nullable3;
      this.ZMax = nullable3;
      double? nullable4 = new double?();
      this.ZMin_DefaultValue = nullable4;
      this.ZMin = nullable4;
      nullable4 = new double?(0.0);
      this.ZThreshold_DefaultValue = nullable4;
      this.ZThreshold = nullable4;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsBubbleZones();
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
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      double? cropThreshold = this.CropThreshold;
      double? nullable1 = this.CropThreshold_DefaultValue;
      if ((cropThreshold.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (cropThreshold.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DashStyle != this.DashStyle_DefaultValue)
        hashtable.Add((object) "dashStyle", (object) Highcharts.FirstCharacterToLower(this.DashStyle.ToString()));
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      bool? displayNegative = this.DisplayNegative;
      bool? nullable2 = this.DisplayNegative_DefaultValue;
      if ((displayNegative.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (displayNegative.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "displayNegative", (object) this.DisplayNegative);
      nullable2 = this.EnableMouseTracking;
      bool? nullable3 = this.EnableMouseTracking_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable1 = this.LineWidth;
      double? nullable4 = this.LineWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Marker.IsDirty())
        hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
      if (this.MaxSize != this.MaxSize_DefaultValue)
        hashtable.Add((object) "maxSize", (object) this.MaxSize);
      if (this.MinSize != this.MinSize_DefaultValue)
        hashtable.Add((object) "minSize", (object) this.MinSize);
      if (this.NegativeColor != this.NegativeColor_DefaultValue)
        hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable4 = this.PointInterval;
      nullable1 = this.PointInterval_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointInterval", (object) this.PointInterval);
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highcharts.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      nullable1 = this.PointStart;
      nullable4 = this.PointStart_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointStart", (object) this.PointStart);
      nullable3 = this.Selected;
      nullable2 = this.Selected_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable2 = this.ShowCheckbox;
      nullable3 = this.ShowCheckbox_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable3 = this.ShowInLegend;
      nullable2 = this.ShowInLegend_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.SizeBy != this.SizeBy_DefaultValue)
        hashtable.Add((object) "sizeBy", (object) Highcharts.FirstCharacterToLower(this.SizeBy.ToString()));
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable2 = this.StickyTracking;
      nullable3 = this.StickyTracking_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      nullable4 = this.Threshold;
      nullable1 = this.Threshold_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "threshold", (object) this.Threshold);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable3 = this.Visible;
      nullable2 = this.Visible_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      nullable1 = this.ZMax;
      nullable4 = this.ZMax_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "zMax", (object) this.ZMax);
      nullable4 = this.ZMin;
      nullable1 = this.ZMin_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "zMin", (object) this.ZMin);
      nullable1 = this.ZThreshold;
      nullable4 = this.ZThreshold_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "zThreshold", (object) this.ZThreshold);
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
