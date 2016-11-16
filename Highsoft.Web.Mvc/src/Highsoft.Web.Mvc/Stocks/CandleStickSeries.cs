﻿
// Type: Highsoft.Web.Mvc.Stocks.CandleStickSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class CandleStickSeries : Series
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public double? CropThreshold { get; set; }

    private double? CropThreshold_DefaultValue { get; set; }

    public CandleStickSeriesCursor Cursor { get; set; }

    private CandleStickSeriesCursor Cursor_DefaultValue { get; set; }

    public List<CandleStickSeriesData> Data { get; set; }

    private List<CandleStickSeriesData> Data_DefaultValue { get; set; }

    public CandleStickSeriesDataGrouping DataGrouping { get; set; }

    private CandleStickSeriesDataGrouping DataGrouping_DefaultValue { get; set; }

    public CandleStickSeriesDataLabels DataLabels { get; set; }

    private CandleStickSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public CandleStickSeriesEvents Events { get; set; }

    private CandleStickSeriesEvents Events_DefaultValue { get; set; }

    public double? GroupPadding { get; set; }

    private double? GroupPadding_DefaultValue { get; set; }

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

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public CandleStickSeriesMarker Marker { get; set; }

    private CandleStickSeriesMarker Marker_DefaultValue { get; set; }

    public double? MinPointLength { get; set; }

    private double? MinPointLength_DefaultValue { get; set; }

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public CandleStickSeriesPoint Point { get; set; }

    private CandleStickSeriesPoint Point_DefaultValue { get; set; }

    public double? PointInterval { get; set; }

    private double? PointInterval_DefaultValue { get; set; }

    public CandleStickSeriesPointIntervalUnit PointIntervalUnit { get; set; }

    private CandleStickSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

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

    public CandleStickSeriesStates States { get; set; }

    private CandleStickSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public CandleStickSeriesTooltip Tooltip { get; set; }

    private CandleStickSeriesTooltip Tooltip_DefaultValue { get; set; }

    public double? TurboThreshold { get; set; }

    private double? TurboThreshold_DefaultValue { get; set; }

    public CandleStickSeriesType Type { get; set; }

    private CandleStickSeriesType Type_DefaultValue { get; set; }

    public string UpColor { get; set; }

    private string UpColor_DefaultValue { get; set; }

    public string UpLineColor { get; set; }

    private string UpLineColor_DefaultValue { get; set; }

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

    public CandleStickSeriesZones Zones { get; set; }

    private CandleStickSeriesZones Zones_DefaultValue { get; set; }

    public CandleStickSeries()
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
      this.Colors = this.Colors_DefaultValue = new List<string>();
      double? nullable2 = new double?(50.0);
      this.CropThreshold_DefaultValue = nullable2;
      this.CropThreshold = nullable2;
      this.Cursor = this.Cursor_DefaultValue = CandleStickSeriesCursor.Null;
      this.Data = this.Data_DefaultValue = new List<CandleStickSeriesData>();
      this.DataGrouping = this.DataGrouping_DefaultValue = new CandleStickSeriesDataGrouping();
      this.DataLabels = this.DataLabels_DefaultValue = new CandleStickSeriesDataLabels();
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new CandleStickSeriesEvents();
      nullable2 = new double?(0.2);
      this.GroupPadding_DefaultValue = nullable2;
      this.GroupPadding = nullable2;
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
      this.LineColor = this.LineColor_DefaultValue = "#000000";
      nullable4 = new double?(1.0);
      this.LineWidth_DefaultValue = nullable4;
      this.LineWidth = nullable4;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Marker = this.Marker_DefaultValue = new CandleStickSeriesMarker();
      nullable4 = new double?(0.0);
      this.MinPointLength_DefaultValue = nullable4;
      this.MinPointLength = nullable4;
      this.Name = this.Name_DefaultValue = "''";
      this.Point = this.Point_DefaultValue = new CandleStickSeriesPoint();
      nullable4 = new double?(1.0);
      this.PointInterval_DefaultValue = nullable4;
      this.PointInterval = nullable4;
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = CandleStickSeriesPointIntervalUnit.Null;
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
      this.Stack = this.Stack_DefaultValue = "null";
      this.States = this.States_DefaultValue = new CandleStickSeriesStates();
      nullable1 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      this.Tooltip = this.Tooltip_DefaultValue = new CandleStickSeriesTooltip();
      nullable6 = new double?(1000.0);
      this.TurboThreshold_DefaultValue = nullable6;
      this.TurboThreshold = nullable6;
      this.Type = this.Type_DefaultValue = CandleStickSeriesType.Null;
      this.UpColor = this.UpColor_DefaultValue = "'white'";
      this.UpLineColor = this.UpLineColor_DefaultValue = "null";
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.XAxis = this.XAxis_DefaultValue = "0";
      this.YAxis = this.YAxis_DefaultValue = "0";
      double? nullable7 = new double?();
      this.ZIndex_DefaultValue = nullable7;
      this.ZIndex = nullable7;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new CandleStickSeriesZones();
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
      if (this.Colors != this.Colors_DefaultValue)
        hashtable.Add((object) "colors", (object) this.Colors);
      double? cropThreshold = this.CropThreshold;
      double? nullable1 = this.CropThreshold_DefaultValue;
      if ((cropThreshold.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (cropThreshold.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highstock.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DataGrouping.IsDirty())
        hashtable.Add((object) "dataGrouping", (object) this.DataGrouping.ToHashtable());
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      bool? enableMouseTracking = this.EnableMouseTracking;
      bool? nullable2 = this.EnableMouseTracking_DefaultValue;
      if ((enableMouseTracking.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (enableMouseTracking.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      nullable1 = this.GroupPadding;
      double? nullable3 = this.GroupPadding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "groupPadding", (object) this.GroupPadding);
      nullable2 = this.Grouping;
      bool? nullable4 = this.Grouping_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "grouping", (object) this.Grouping);
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      nullable3 = this.Index;
      nullable1 = this.Index_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "index", (object) this.Index);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable1 = this.LegendIndex;
      nullable3 = this.LegendIndex_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      nullable3 = this.LineWidth;
      nullable1 = this.LineWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Marker.IsDirty())
        hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
      nullable1 = this.MinPointLength;
      nullable3 = this.MinPointLength_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minPointLength", (object) this.MinPointLength);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable3 = this.PointInterval;
      nullable1 = this.PointInterval_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointInterval", (object) this.PointInterval);
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highstock.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      nullable1 = this.PointPadding;
      nullable3 = this.PointPadding_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointPadding", (object) this.PointPadding);
      if (this.PointPlacement.IsDirty())
        hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
      nullable3 = this.PointRange;
      nullable1 = this.PointRange_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointRange", (object) this.PointRange);
      nullable1 = this.PointStart;
      nullable3 = this.PointStart_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointStart", (object) this.PointStart);
      nullable3 = this.PointWidth;
      nullable1 = this.PointWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointWidth", (object) this.PointWidth);
      nullable4 = this.Selected;
      nullable2 = this.Selected_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable2 = this.ShowCheckbox;
      nullable4 = this.ShowCheckbox_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable4 = this.ShowInLegend;
      nullable2 = this.ShowInLegend_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.Stack != this.Stack_DefaultValue)
        hashtable.Add((object) "stack", (object) this.Stack);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable2 = this.StickyTracking;
      nullable4 = this.StickyTracking_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable1 = this.TurboThreshold;
      nullable3 = this.TurboThreshold_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highstock.FirstCharacterToLower(this.Type.ToString()));
      if (this.UpColor != this.UpColor_DefaultValue)
        hashtable.Add((object) "upColor", (object) this.UpColor);
      if (this.UpLineColor != this.UpLineColor_DefaultValue)
        hashtable.Add((object) "upLineColor", (object) this.UpLineColor);
      nullable4 = this.Visible;
      nullable2 = this.Visible_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      if (this.XAxis != this.XAxis_DefaultValue)
        hashtable.Add((object) "xAxis", (object) this.XAxis);
      if (this.YAxis != this.YAxis_DefaultValue)
        hashtable.Add((object) "yAxis", (object) this.YAxis);
      nullable3 = this.ZIndex;
      nullable1 = this.ZIndex_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
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
