
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreaspline




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsAreaspline : BaseObject
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public string Compare { get; set; }

    private string Compare_DefaultValue { get; set; }

    public bool? ConnectNulls { get; set; }

    private bool? ConnectNulls_DefaultValue { get; set; }

    public double? CropThreshold { get; set; }

    private double? CropThreshold_DefaultValue { get; set; }

    public PlotOptionsAreasplineCursor Cursor { get; set; }

    private PlotOptionsAreasplineCursor Cursor_DefaultValue { get; set; }

    public PlotOptionsAreasplineDashStyle DashStyle { get; set; }

    private PlotOptionsAreasplineDashStyle DashStyle_DefaultValue { get; set; }

    public PlotOptionsAreasplineDataGrouping DataGrouping { get; set; }

    private PlotOptionsAreasplineDataGrouping DataGrouping_DefaultValue { get; set; }

    public PlotOptionsAreasplineDataLabels DataLabels { get; set; }

    private PlotOptionsAreasplineDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public PlotOptionsAreasplineEvents Events { get; set; }

    private PlotOptionsAreasplineEvents Events_DefaultValue { get; set; }

    public string FillColor { get; set; }

    private string FillColor_DefaultValue { get; set; }

    public double? FillOpacity { get; set; }

    private double? FillOpacity_DefaultValue { get; set; }

    public double? GapSize { get; set; }

    private double? GapSize_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public string LineColor { get; set; }

    private string LineColor_DefaultValue { get; set; }

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public PlotOptionsAreasplineMarker Marker { get; set; }

    private PlotOptionsAreasplineMarker Marker_DefaultValue { get; set; }

    public PlotOptionsAreasplinePoint Point { get; set; }

    private PlotOptionsAreasplinePoint Point_DefaultValue { get; set; }

    public double? PointInterval { get; set; }

    private double? PointInterval_DefaultValue { get; set; }

    public PlotOptionsAreasplinePointIntervalUnit PointIntervalUnit { get; set; }

    private PlotOptionsAreasplinePointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

    public PointPlacement PointPlacement { get; set; }

    private PointPlacement PointPlacement_DefaultValue { get; set; }

    public double? PointRange { get; set; }

    private double? PointRange_DefaultValue { get; set; }

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

    public PlotOptionsAreasplineStacking Stacking { get; set; }

    private PlotOptionsAreasplineStacking Stacking_DefaultValue { get; set; }

    public PlotOptionsAreasplineStates States { get; set; }

    private PlotOptionsAreasplineStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public double? Threshold { get; set; }

    private double? Threshold_DefaultValue { get; set; }

    public PlotOptionsAreasplineTooltip Tooltip { get; set; }

    private PlotOptionsAreasplineTooltip Tooltip_DefaultValue { get; set; }

    public bool? TrackByArea { get; set; }

    private bool? TrackByArea_DefaultValue { get; set; }

    public double? TurboThreshold { get; set; }

    private double? TurboThreshold_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsAreasplineZones Zones { get; set; }

    private PlotOptionsAreasplineZones Zones_DefaultValue { get; set; }

    public PlotOptionsAreaspline()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.Color = this.Color_DefaultValue = "";
      this.Compare = this.Compare_DefaultValue = "undefined";
      nullable1 = new bool?(false);
      this.ConnectNulls_DefaultValue = nullable1;
      this.ConnectNulls = nullable1;
      double? nullable2 = new double?(300.0);
      this.CropThreshold_DefaultValue = nullable2;
      this.CropThreshold = nullable2;
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsAreasplineCursor.Null;
      this.DashStyle = this.DashStyle_DefaultValue = PlotOptionsAreasplineDashStyle.Solid;
      this.DataGrouping = this.DataGrouping_DefaultValue = new PlotOptionsAreasplineDataGrouping();
      this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsAreasplineDataLabels();
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new PlotOptionsAreasplineEvents();
      this.FillColor = this.FillColor_DefaultValue = "null";
      nullable2 = new double?(0.75);
      this.FillOpacity_DefaultValue = nullable2;
      this.FillOpacity = nullable2;
      nullable2 = new double?(0.0);
      this.GapSize_DefaultValue = nullable2;
      this.GapSize = nullable2;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      nullable2 = new double?(0.0);
      this.LegendIndex_DefaultValue = nullable2;
      this.LegendIndex = nullable2;
      this.LineColor = this.LineColor_DefaultValue = "null";
      nullable2 = new double?(2.0);
      this.LineWidth_DefaultValue = nullable2;
      this.LineWidth = nullable2;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Marker = this.Marker_DefaultValue = new PlotOptionsAreasplineMarker();
      this.Point = this.Point_DefaultValue = new PlotOptionsAreasplinePoint();
      nullable2 = new double?(1.0);
      this.PointInterval_DefaultValue = nullable2;
      this.PointInterval = nullable2;
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsAreasplinePointIntervalUnit.Null;
      this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
      nullable2 = new double?(0.0);
      this.PointRange_DefaultValue = nullable2;
      this.PointRange = nullable2;
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
      this.Stacking = this.Stacking_DefaultValue = PlotOptionsAreasplineStacking.Null;
      this.States = this.States_DefaultValue = new PlotOptionsAreasplineStates();
      nullable1 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      nullable2 = new double?(0.0);
      this.Threshold_DefaultValue = nullable2;
      this.Threshold = nullable2;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsAreasplineTooltip();
      nullable1 = new bool?(false);
      this.TrackByArea_DefaultValue = nullable1;
      this.TrackByArea = nullable1;
      nullable2 = new double?(1000.0);
      this.TurboThreshold_DefaultValue = nullable2;
      this.TurboThreshold = nullable2;
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsAreasplineZones();
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
      if (this.Compare != this.Compare_DefaultValue)
        hashtable.Add((object) "compare", (object) this.Compare);
      bool? connectNulls = this.ConnectNulls;
      bool? nullable1 = this.ConnectNulls_DefaultValue;
      if ((connectNulls.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (connectNulls.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "connectNulls", (object) this.ConnectNulls);
      double? cropThreshold = this.CropThreshold;
      double? nullable2 = this.CropThreshold_DefaultValue;
      if ((cropThreshold.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (cropThreshold.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highstock.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DashStyle != this.DashStyle_DefaultValue)
        hashtable.Add((object) "dashStyle", (object) Highstock.FirstCharacterToLower(this.DashStyle.ToString()));
      if (this.DataGrouping.IsDirty())
        hashtable.Add((object) "dataGrouping", (object) this.DataGrouping.ToHashtable());
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      nullable1 = this.EnableMouseTracking;
      bool? nullable3 = this.EnableMouseTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.FillColor != this.FillColor_DefaultValue)
        hashtable.Add((object) "fillColor", (object) this.FillColor);
      nullable2 = this.FillOpacity;
      double? nullable4 = this.FillOpacity_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "fillOpacity", (object) this.FillOpacity);
      nullable4 = this.GapSize;
      nullable2 = this.GapSize_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "gapSize", (object) this.GapSize);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable2 = this.LegendIndex;
      nullable4 = this.LegendIndex_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      nullable4 = this.LineWidth;
      nullable2 = this.LineWidth_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Marker.IsDirty())
        hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable2 = this.PointInterval;
      nullable4 = this.PointInterval_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointInterval", (object) this.PointInterval);
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highstock.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      if (this.PointPlacement.IsDirty())
        hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
      nullable4 = this.PointRange;
      nullable2 = this.PointRange_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointRange", (object) this.PointRange);
      nullable2 = this.PointStart;
      nullable4 = this.PointStart_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointStart", (object) this.PointStart);
      nullable3 = this.Selected;
      nullable1 = this.Selected_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable1 = this.ShowCheckbox;
      nullable3 = this.ShowCheckbox_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable3 = this.ShowInLegend;
      nullable1 = this.ShowInLegend_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.Stacking != this.Stacking_DefaultValue)
        hashtable.Add((object) "stacking", (object) Highstock.FirstCharacterToLower(this.Stacking.ToString()));
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable1 = this.StickyTracking;
      nullable3 = this.StickyTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      nullable4 = this.Threshold;
      nullable2 = this.Threshold_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "threshold", (object) this.Threshold);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable3 = this.TrackByArea;
      nullable1 = this.TrackByArea_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "trackByArea", (object) this.TrackByArea);
      nullable2 = this.TurboThreshold;
      nullable4 = this.TurboThreshold_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
      nullable1 = this.Visible;
      nullable3 = this.Visible_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
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
