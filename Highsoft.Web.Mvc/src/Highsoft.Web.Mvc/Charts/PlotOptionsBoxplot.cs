﻿
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBoxplot




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsBoxplot : BaseObject
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public bool? ColorByPoint { get; set; }

    private bool? ColorByPoint_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public PlotOptionsBoxplotCursor Cursor { get; set; }

    private PlotOptionsBoxplotCursor Cursor_DefaultValue { get; set; }

    public double? Depth { get; set; }

    private double? Depth_DefaultValue { get; set; }

    public string EdgeColor { get; set; }

    private string EdgeColor_DefaultValue { get; set; }

    public double? EdgeWidth { get; set; }

    private double? EdgeWidth_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public PlotOptionsBoxplotEvents Events { get; set; }

    private PlotOptionsBoxplotEvents Events_DefaultValue { get; set; }

    public string FillColor { get; set; }

    private string FillColor_DefaultValue { get; set; }

    public double? GroupPadding { get; set; }

    private double? GroupPadding_DefaultValue { get; set; }

    public double? GroupZPadding { get; set; }

    private double? GroupZPadding_DefaultValue { get; set; }

    public bool? Grouping { get; set; }

    private bool? Grouping_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public string MedianColor { get; set; }

    private string MedianColor_DefaultValue { get; set; }

    public double? MedianWidth { get; set; }

    private double? MedianWidth_DefaultValue { get; set; }

    public string NegativeColor { get; set; }

    private string NegativeColor_DefaultValue { get; set; }

    public PlotOptionsBoxplotPoint Point { get; set; }

    private PlotOptionsBoxplotPoint Point_DefaultValue { get; set; }

    public double? PointInterval { get; set; }

    private double? PointInterval_DefaultValue { get; set; }

    public PlotOptionsBoxplotPointIntervalUnit PointIntervalUnit { get; set; }

    private PlotOptionsBoxplotPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

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

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public PlotOptionsBoxplotStates States { get; set; }

    private PlotOptionsBoxplotStates States_DefaultValue { get; set; }

    public string StemColor { get; set; }

    private string StemColor_DefaultValue { get; set; }

    public PlotOptionsBoxplotStemDashStyle StemDashStyle { get; set; }

    private PlotOptionsBoxplotStemDashStyle StemDashStyle_DefaultValue { get; set; }

    public double? StemWidth { get; set; }

    private double? StemWidth_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public PlotOptionsBoxplotTooltip Tooltip { get; set; }

    private PlotOptionsBoxplotTooltip Tooltip_DefaultValue { get; set; }

    public double? TurboThreshold { get; set; }

    private double? TurboThreshold_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public string WhiskerColor { get; set; }

    private string WhiskerColor_DefaultValue { get; set; }

    public string WhiskerLength { get; set; }

    private string WhiskerLength_DefaultValue { get; set; }

    public double? WhiskerWidth { get; set; }

    private double? WhiskerWidth_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsBoxplotZones Zones { get; set; }

    private PlotOptionsBoxplotZones Zones_DefaultValue { get; set; }

    public PlotOptionsBoxplot()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      this.Color = this.Color_DefaultValue = (string) null;
      nullable1 = new bool?(false);
      this.ColorByPoint_DefaultValue = nullable1;
      this.ColorByPoint = nullable1;
      this.Colors = this.Colors_DefaultValue = new List<string>();
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsBoxplotCursor.Null;
      double? nullable2 = new double?(25.0);
      this.Depth_DefaultValue = nullable2;
      this.Depth = nullable2;
      this.EdgeColor = this.EdgeColor_DefaultValue = "";
      nullable2 = new double?(1.0);
      this.EdgeWidth_DefaultValue = nullable2;
      this.EdgeWidth = nullable2;
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new PlotOptionsBoxplotEvents();
      this.FillColor = this.FillColor_DefaultValue = "#FFFFFF";
      nullable2 = new double?(0.2);
      this.GroupPadding_DefaultValue = nullable2;
      this.GroupPadding = nullable2;
      nullable2 = new double?(1.0);
      this.GroupZPadding_DefaultValue = nullable2;
      this.GroupZPadding = nullable2;
      nullable1 = new bool?(true);
      this.Grouping_DefaultValue = nullable1;
      this.Grouping = nullable1;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      nullable2 = new double?(1.0);
      this.LineWidth_DefaultValue = nullable2;
      this.LineWidth = nullable2;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.MedianColor = this.MedianColor_DefaultValue = "null";
      nullable2 = new double?(2.0);
      this.MedianWidth_DefaultValue = nullable2;
      this.MedianWidth = nullable2;
      this.NegativeColor = this.NegativeColor_DefaultValue = "null";
      this.Point = this.Point_DefaultValue = new PlotOptionsBoxplotPoint();
      nullable2 = new double?(1.0);
      this.PointInterval_DefaultValue = nullable2;
      this.PointInterval = nullable2;
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsBoxplotPointIntervalUnit.Null;
      nullable2 = new double?(0.1);
      this.PointPadding_DefaultValue = nullable2;
      this.PointPadding = nullable2;
      this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
      double? nullable3 = new double?();
      this.PointRange_DefaultValue = nullable3;
      this.PointRange = nullable3;
      nullable3 = new double?(0.0);
      this.PointStart_DefaultValue = nullable3;
      this.PointStart = nullable3;
      double? nullable4 = new double?();
      this.PointWidth_DefaultValue = nullable4;
      this.PointWidth = nullable4;
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      nullable1 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable1;
      this.ShowCheckbox = nullable1;
      nullable1 = new bool?(true);
      this.ShowInLegend_DefaultValue = nullable1;
      this.ShowInLegend = nullable1;
      this.States = this.States_DefaultValue = new PlotOptionsBoxplotStates();
      this.StemColor = this.StemColor_DefaultValue = "null";
      this.StemDashStyle = this.StemDashStyle_DefaultValue = PlotOptionsBoxplotStemDashStyle.Solid;
      double? nullable5 = new double?();
      this.StemWidth_DefaultValue = nullable5;
      this.StemWidth = nullable5;
      nullable1 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsBoxplotTooltip();
      nullable5 = new double?(1000.0);
      this.TurboThreshold_DefaultValue = nullable5;
      this.TurboThreshold = nullable5;
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.WhiskerColor = this.WhiskerColor_DefaultValue = "null";
      this.WhiskerLength = this.WhiskerLength_DefaultValue = "50%";
      nullable5 = new double?(2.0);
      this.WhiskerWidth_DefaultValue = nullable5;
      this.WhiskerWidth = nullable5;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsBoxplotZones();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      bool? allowPointSelect = this.AllowPointSelect;
      bool? selectDefaultValue = this.AllowPointSelect_DefaultValue;
      if ((allowPointSelect.GetValueOrDefault() == selectDefaultValue.GetValueOrDefault() ? (allowPointSelect.HasValue != selectDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      bool? colorByPoint = this.ColorByPoint;
      bool? nullable1 = this.ColorByPoint_DefaultValue;
      if ((colorByPoint.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (colorByPoint.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "colorByPoint", (object) this.ColorByPoint);
      if (this.Colors != this.Colors_DefaultValue)
        hashtable.Add((object) "colors", (object) this.Colors);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      double? depth = this.Depth;
      double? nullable2 = this.Depth_DefaultValue;
      if ((depth.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (depth.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "depth", (object) this.Depth);
      if (this.EdgeColor != this.EdgeColor_DefaultValue)
        hashtable.Add((object) "edgeColor", (object) this.EdgeColor);
      nullable2 = this.EdgeWidth;
      double? nullable3 = this.EdgeWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "edgeWidth", (object) this.EdgeWidth);
      nullable1 = this.EnableMouseTracking;
      bool? nullable4 = this.EnableMouseTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.FillColor != this.FillColor_DefaultValue)
        hashtable.Add((object) "fillColor", (object) this.FillColor);
      nullable3 = this.GroupPadding;
      nullable2 = this.GroupPadding_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "groupPadding", (object) this.GroupPadding);
      nullable2 = this.GroupZPadding;
      nullable3 = this.GroupZPadding_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "groupZPadding", (object) this.GroupZPadding);
      nullable4 = this.Grouping;
      nullable1 = this.Grouping_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "grouping", (object) this.Grouping);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable3 = this.LineWidth;
      nullable2 = this.LineWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.MedianColor != this.MedianColor_DefaultValue)
        hashtable.Add((object) "medianColor", (object) this.MedianColor);
      nullable2 = this.MedianWidth;
      nullable3 = this.MedianWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "medianWidth", (object) this.MedianWidth);
      if (this.NegativeColor != this.NegativeColor_DefaultValue)
        hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable3 = this.PointInterval;
      nullable2 = this.PointInterval_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointInterval", (object) this.PointInterval);
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highcharts.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      nullable2 = this.PointPadding;
      nullable3 = this.PointPadding_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointPadding", (object) this.PointPadding);
      if (this.PointPlacement.IsDirty())
        hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
      nullable3 = this.PointRange;
      nullable2 = this.PointRange_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointRange", (object) this.PointRange);
      nullable2 = this.PointStart;
      nullable3 = this.PointStart_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointStart", (object) this.PointStart);
      nullable3 = this.PointWidth;
      nullable2 = this.PointWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "pointWidth", (object) this.PointWidth);
      nullable1 = this.Selected;
      nullable4 = this.Selected_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      nullable4 = this.ShowCheckbox;
      nullable1 = this.ShowCheckbox_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable1 = this.ShowInLegend;
      nullable4 = this.ShowInLegend_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      if (this.StemColor != this.StemColor_DefaultValue)
        hashtable.Add((object) "stemColor", (object) this.StemColor);
      if (this.StemDashStyle != this.StemDashStyle_DefaultValue)
        hashtable.Add((object) "stemDashStyle", (object) Highcharts.FirstCharacterToLower(this.StemDashStyle.ToString()));
      nullable2 = this.StemWidth;
      nullable3 = this.StemWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stemWidth", (object) this.StemWidth);
      nullable4 = this.StickyTracking;
      nullable1 = this.StickyTracking_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable3 = this.TurboThreshold;
      nullable2 = this.TurboThreshold_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
      nullable1 = this.Visible;
      nullable4 = this.Visible_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      if (this.WhiskerColor != this.WhiskerColor_DefaultValue)
        hashtable.Add((object) "whiskerColor", (object) this.WhiskerColor);
      if (this.WhiskerLength != this.WhiskerLength_DefaultValue)
        hashtable.Add((object) "whiskerLength", (object) this.WhiskerLength);
      nullable2 = this.WhiskerWidth;
      nullable3 = this.WhiskerWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "whiskerWidth", (object) this.WhiskerWidth);
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