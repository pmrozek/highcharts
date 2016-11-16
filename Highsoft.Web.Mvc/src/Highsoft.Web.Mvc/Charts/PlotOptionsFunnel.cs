﻿
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsFunnel




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsFunnel : BaseObject
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public string[] Center { get; set; }

    private string[] Center_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public PlotOptionsFunnelCursor Cursor { get; set; }

    private PlotOptionsFunnelCursor Cursor_DefaultValue { get; set; }

    public PlotOptionsFunnelDataLabels DataLabels { get; set; }

    private PlotOptionsFunnelDataLabels DataLabels_DefaultValue { get; set; }

    public double? Depth { get; set; }

    private double? Depth_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public PlotOptionsFunnelEvents Events { get; set; }

    private PlotOptionsFunnelEvents Events_DefaultValue { get; set; }

    public string Height { get; set; }

    private string Height_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public double? MinSize { get; set; }

    private double? MinSize_DefaultValue { get; set; }

    public string NeckHeight { get; set; }

    private string NeckHeight_DefaultValue { get; set; }

    public string NeckWidth { get; set; }

    private string NeckWidth_DefaultValue { get; set; }

    public PlotOptionsFunnelPoint Point { get; set; }

    private PlotOptionsFunnelPoint Point_DefaultValue { get; set; }

    public bool? Reversed { get; set; }

    private bool? Reversed_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public double? SlicedOffset { get; set; }

    private double? SlicedOffset_DefaultValue { get; set; }

    public PlotOptionsFunnelStates States { get; set; }

    private PlotOptionsFunnelStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public PlotOptionsFunnelTooltip Tooltip { get; set; }

    private PlotOptionsFunnelTooltip Tooltip_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public string Width { get; set; }

    private string Width_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsFunnelZones Zones { get; set; }

    private PlotOptionsFunnelZones Zones_DefaultValue { get; set; }

    public PlotOptionsFunnel()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      this.BorderColor = this.BorderColor_DefaultValue = "#FFFFFF";
      double? nullable2 = new double?(1.0);
      this.BorderWidth_DefaultValue = nullable2;
      this.BorderWidth = nullable2;
      this.Center = this.Center_DefaultValue = new string[2];
      this.Colors = this.Colors_DefaultValue = new List<string>();
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsFunnelCursor.Null;
      this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsFunnelDataLabels();
      nullable2 = new double?(0.0);
      this.Depth_DefaultValue = nullable2;
      this.Depth = nullable2;
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new PlotOptionsFunnelEvents();
      this.Height = this.Height_DefaultValue = (string) null;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      nullable2 = new double?(80.0);
      this.MinSize_DefaultValue = nullable2;
      this.MinSize = nullable2;
      this.NeckHeight = this.NeckHeight_DefaultValue = "25%";
      this.NeckWidth = this.NeckWidth_DefaultValue = "30%";
      this.Point = this.Point_DefaultValue = new PlotOptionsFunnelPoint();
      nullable1 = new bool?(false);
      this.Reversed_DefaultValue = nullable1;
      this.Reversed = nullable1;
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      Shadow shadow1 = new Shadow();
      shadow1.Enabled = false;
      Shadow shadow2 = shadow1;
      this.Shadow_DefaultValue = shadow1;
      this.Shadow = shadow2;
      nullable1 = new bool?(false);
      this.ShowInLegend_DefaultValue = nullable1;
      this.ShowInLegend = nullable1;
      nullable2 = new double?(10.0);
      this.SlicedOffset_DefaultValue = nullable2;
      this.SlicedOffset = nullable2;
      this.States = this.States_DefaultValue = new PlotOptionsFunnelStates();
      nullable1 = new bool?(false);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsFunnelTooltip();
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.Width = this.Width_DefaultValue = "90%";
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsFunnelZones();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      bool? allowPointSelect = this.AllowPointSelect;
      bool? selectDefaultValue = this.AllowPointSelect_DefaultValue;
      if ((allowPointSelect.GetValueOrDefault() == selectDefaultValue.GetValueOrDefault() ? (allowPointSelect.HasValue != selectDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? borderWidth = this.BorderWidth;
      double? nullable1 = this.BorderWidth_DefaultValue;
      if ((borderWidth.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (borderWidth.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      if (this.Center != this.Center_DefaultValue)
        hashtable.Add((object) "center", (object) this.Center);
      if (this.Colors != this.Colors_DefaultValue)
        hashtable.Add((object) "colors", (object) this.Colors);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      nullable1 = this.Depth;
      double? nullable2 = this.Depth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "depth", (object) this.Depth);
      bool? enableMouseTracking = this.EnableMouseTracking;
      bool? nullable3 = this.EnableMouseTracking_DefaultValue;
      if ((enableMouseTracking.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (enableMouseTracking.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Height != this.Height_DefaultValue)
        hashtable.Add((object) "height", (object) this.Height);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      nullable2 = this.MinSize;
      nullable1 = this.MinSize_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minSize", (object) this.MinSize);
      if (this.NeckHeight != this.NeckHeight_DefaultValue)
        hashtable.Add((object) "neckHeight", (object) this.NeckHeight);
      if (this.NeckWidth != this.NeckWidth_DefaultValue)
        hashtable.Add((object) "neckWidth", (object) this.NeckWidth);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable3 = this.Reversed;
      bool? nullable4 = this.Reversed_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "reversed", (object) this.Reversed);
      nullable4 = this.Selected;
      nullable3 = this.Selected_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable3 = this.ShowInLegend;
      nullable4 = this.ShowInLegend_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      nullable1 = this.SlicedOffset;
      nullable2 = this.SlicedOffset_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "slicedOffset", (object) this.SlicedOffset);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable4 = this.StickyTracking;
      nullable3 = this.StickyTracking_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable3 = this.Visible;
      nullable4 = this.Visible_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      if (this.Width != this.Width_DefaultValue)
        hashtable.Add((object) "width", (object) this.Width);
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