
// Type: Highsoft.Web.Mvc.Stocks.AreasplineSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class AreasplineSeries : Series
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

    public AreasplineSeriesCursor Cursor { get; set; }

    private AreasplineSeriesCursor Cursor_DefaultValue { get; set; }

    public AreasplineSeriesDashStyle DashStyle { get; set; }

    private AreasplineSeriesDashStyle DashStyle_DefaultValue { get; set; }

    public List<AreasplineSeriesData> Data { get; set; }

    private List<AreasplineSeriesData> Data_DefaultValue { get; set; }

    public AreasplineSeriesDataGrouping DataGrouping { get; set; }

    private AreasplineSeriesDataGrouping DataGrouping_DefaultValue { get; set; }

    public AreasplineSeriesDataLabels DataLabels { get; set; }

    private AreasplineSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public AreasplineSeriesEvents Events { get; set; }

    private AreasplineSeriesEvents Events_DefaultValue { get; set; }

    public string FillColor { get; set; }

    private string FillColor_DefaultValue { get; set; }

    public double? FillOpacity { get; set; }

    private double? FillOpacity_DefaultValue { get; set; }

    public double? GapSize { get; set; }

    private double? GapSize_DefaultValue { get; set; }

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

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public AreasplineSeriesMarker Marker { get; set; }

    private AreasplineSeriesMarker Marker_DefaultValue { get; set; }

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public AreasplineSeriesPoint Point { get; set; }

    private AreasplineSeriesPoint Point_DefaultValue { get; set; }

    public double? PointInterval { get; set; }

    private double? PointInterval_DefaultValue { get; set; }

    public AreasplineSeriesPointIntervalUnit PointIntervalUnit { get; set; }

    private AreasplineSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

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

    public new string Stack { get; set; }

    private string Stack_DefaultValue { get; set; }

    public AreasplineSeriesStacking Stacking { get; set; }

    private AreasplineSeriesStacking Stacking_DefaultValue { get; set; }

    public AreasplineSeriesStates States { get; set; }

    private AreasplineSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public double? Threshold { get; set; }

    private double? Threshold_DefaultValue { get; set; }

    public AreasplineSeriesTooltip Tooltip { get; set; }

    private AreasplineSeriesTooltip Tooltip_DefaultValue { get; set; }

    public bool? TrackByArea { get; set; }

    private bool? TrackByArea_DefaultValue { get; set; }

    public double? TurboThreshold { get; set; }

    private double? TurboThreshold_DefaultValue { get; set; }

    public AreasplineSeriesType Type { get; set; }

    private AreasplineSeriesType Type_DefaultValue { get; set; }

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

    public AreasplineSeriesZones Zones { get; set; }

    private AreasplineSeriesZones Zones_DefaultValue { get; set; }

    public AreasplineSeries()
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
      this.Cursor = this.Cursor_DefaultValue = AreasplineSeriesCursor.Null;
      this.DashStyle = this.DashStyle_DefaultValue = AreasplineSeriesDashStyle.Solid;
      this.Data = this.Data_DefaultValue = new List<AreasplineSeriesData>();
      this.DataGrouping = this.DataGrouping_DefaultValue = new AreasplineSeriesDataGrouping();
      this.DataLabels = this.DataLabels_DefaultValue = new AreasplineSeriesDataLabels();
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new AreasplineSeriesEvents();
      this.FillColor = this.FillColor_DefaultValue = "null";
      nullable2 = new double?(0.75);
      this.FillOpacity_DefaultValue = nullable2;
      this.FillOpacity = nullable2;
      nullable2 = new double?(0.0);
      this.GapSize_DefaultValue = nullable2;
      this.GapSize = nullable2;
      this.Id = this.Id_DefaultValue = "";
      double? nullable3 = new double?();
      this.Index_DefaultValue = nullable3;
      this.Index = nullable3;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable4 = new double?();
      this.LegendIndex_DefaultValue = nullable4;
      this.LegendIndex = nullable4;
      this.LineColor = this.LineColor_DefaultValue = "null";
      nullable4 = new double?(2.0);
      this.LineWidth_DefaultValue = nullable4;
      this.LineWidth = nullable4;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Marker = this.Marker_DefaultValue = new AreasplineSeriesMarker();
      this.Name = this.Name_DefaultValue = "''";
      this.Point = this.Point_DefaultValue = new AreasplineSeriesPoint();
      nullable4 = new double?(1.0);
      this.PointInterval_DefaultValue = nullable4;
      this.PointInterval = nullable4;
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = AreasplineSeriesPointIntervalUnit.Null;
      this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
      nullable4 = new double?(0.0);
      this.PointRange_DefaultValue = nullable4;
      this.PointRange = nullable4;
      nullable4 = new double?(0.0);
      this.PointStart_DefaultValue = nullable4;
      this.PointStart = nullable4;
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
      this.Stack = this.Stack_DefaultValue = "null";
      this.Stacking = this.Stacking_DefaultValue = AreasplineSeriesStacking.Null;
      this.States = this.States_DefaultValue = new AreasplineSeriesStates();
      nullable1 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      nullable4 = new double?(0.0);
      this.Threshold_DefaultValue = nullable4;
      this.Threshold = nullable4;
      this.Tooltip = this.Tooltip_DefaultValue = new AreasplineSeriesTooltip();
      nullable1 = new bool?(false);
      this.TrackByArea_DefaultValue = nullable1;
      this.TrackByArea = nullable1;
      nullable4 = new double?(1000.0);
      this.TurboThreshold_DefaultValue = nullable4;
      this.TurboThreshold = nullable4;
      this.Type = this.Type_DefaultValue = AreasplineSeriesType.Null;
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.XAxis = this.XAxis_DefaultValue = "0";
      this.YAxis = this.YAxis_DefaultValue = "0";
      double? nullable5 = new double?();
      this.ZIndex_DefaultValue = nullable5;
      this.ZIndex = nullable5;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new AreasplineSeriesZones();
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
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      nullable2 = this.Index;
      nullable4 = this.Index_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "index", (object) this.Index);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable4 = this.LegendIndex;
      nullable2 = this.LegendIndex_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      nullable2 = this.LineWidth;
      nullable4 = this.LineWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Marker.IsDirty())
        hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable4 = this.PointInterval;
      nullable2 = this.PointInterval_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointInterval", (object) this.PointInterval);
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highstock.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      if (this.PointPlacement.IsDirty())
        hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
      nullable2 = this.PointRange;
      nullable4 = this.PointRange_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointRange", (object) this.PointRange);
      nullable4 = this.PointStart;
      nullable2 = this.PointStart_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
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
      if (this.Stack != this.Stack_DefaultValue)
        hashtable.Add((object) "stack", (object) this.Stack);
      if (this.Stacking != this.Stacking_DefaultValue)
        hashtable.Add((object) "stacking", (object) Highstock.FirstCharacterToLower(this.Stacking.ToString()));
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable1 = this.StickyTracking;
      nullable3 = this.StickyTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      nullable2 = this.Threshold;
      nullable4 = this.Threshold_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "threshold", (object) this.Threshold);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable3 = this.TrackByArea;
      nullable1 = this.TrackByArea_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "trackByArea", (object) this.TrackByArea);
      nullable4 = this.TurboThreshold;
      nullable2 = this.TurboThreshold_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highstock.FirstCharacterToLower(this.Type.ToString()));
      nullable1 = this.Visible;
      nullable3 = this.Visible_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      if (this.XAxis != this.XAxis_DefaultValue)
        hashtable.Add((object) "xAxis", (object) this.XAxis);
      if (this.YAxis != this.YAxis_DefaultValue)
        hashtable.Add((object) "yAxis", (object) this.YAxis);
      nullable2 = this.ZIndex;
      nullable4 = this.ZIndex_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
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
