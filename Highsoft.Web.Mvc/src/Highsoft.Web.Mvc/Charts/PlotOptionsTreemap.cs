﻿
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsTreemap




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsTreemap : BaseObject
  {
    public PlotOptionsTreemapAllowDrillToNode AllowDrillToNode { get; set; }

    private PlotOptionsTreemapAllowDrillToNode AllowDrillToNode_DefaultValue { get; set; }

    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public PlotOptionsTreemapAlternateStartingDirection AlternateStartingDirection { get; set; }

    private PlotOptionsTreemapAlternateStartingDirection AlternateStartingDirection_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public bool? ColorByPoint { get; set; }

    private bool? ColorByPoint_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public double? CropThreshold { get; set; }

    private double? CropThreshold_DefaultValue { get; set; }

    public PlotOptionsTreemapCursor Cursor { get; set; }

    private PlotOptionsTreemapCursor Cursor_DefaultValue { get; set; }

    public PlotOptionsTreemapDataLabels DataLabels { get; set; }

    private PlotOptionsTreemapDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public PlotOptionsTreemapEvents Events { get; set; }

    private PlotOptionsTreemapEvents Events_DefaultValue { get; set; }

    public bool? InteractByLeaf { get; set; }

    private bool? InteractByLeaf_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public PlotOptionsTreemapLayoutAlgorithm LayoutAlgorithm { get; set; }

    private PlotOptionsTreemapLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }

    public PlotOptionsTreemapLayoutStartingDirection LayoutStartingDirection { get; set; }

    private PlotOptionsTreemapLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }

    public PlotOptionsTreemapLevelIsConstant LevelIsConstant { get; set; }

    private PlotOptionsTreemapLevelIsConstant LevelIsConstant_DefaultValue { get; set; }

    public PlotOptionsTreemapLevels Levels { get; set; }

    private PlotOptionsTreemapLevels Levels_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public PlotOptionsTreemapPoint Point { get; set; }

    private PlotOptionsTreemapPoint Point_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public PlotOptionsTreemapStates States { get; set; }

    private PlotOptionsTreemapStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public PlotOptionsTreemapTooltip Tooltip { get; set; }

    private PlotOptionsTreemapTooltip Tooltip_DefaultValue { get; set; }

    public double? TurboThreshold { get; set; }

    private double? TurboThreshold_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsTreemapZones Zones { get; set; }

    private PlotOptionsTreemapZones Zones_DefaultValue { get; set; }

    public PlotOptionsTreemap()
    {
      this.AllowDrillToNode = this.AllowDrillToNode_DefaultValue = PlotOptionsTreemapAllowDrillToNode.False;
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      this.AlternateStartingDirection = this.AlternateStartingDirection_DefaultValue = PlotOptionsTreemapAlternateStartingDirection.False;
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.BorderColor = this.BorderColor_DefaultValue = "#E0E0E0";
      double? nullable2 = new double?(1.0);
      this.BorderWidth_DefaultValue = nullable2;
      this.BorderWidth = nullable2;
      this.Color = this.Color_DefaultValue = "null";
      nullable1 = new bool?(false);
      this.ColorByPoint_DefaultValue = nullable1;
      this.ColorByPoint = nullable1;
      this.Colors = this.Colors_DefaultValue = new List<string>();
      nullable2 = new double?(300.0);
      this.CropThreshold_DefaultValue = nullable2;
      this.CropThreshold = nullable2;
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsTreemapCursor.Null;
      this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsTreemapDataLabels();
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new PlotOptionsTreemapEvents();
      bool? nullable3 = new bool?();
      this.InteractByLeaf_DefaultValue = nullable3;
      this.InteractByLeaf = nullable3;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      this.LayoutAlgorithm = this.LayoutAlgorithm_DefaultValue = PlotOptionsTreemapLayoutAlgorithm.SliceAndDice;
      this.LayoutStartingDirection = this.LayoutStartingDirection_DefaultValue = PlotOptionsTreemapLayoutStartingDirection.Vertical;
      this.LevelIsConstant = this.LevelIsConstant_DefaultValue = PlotOptionsTreemapLevelIsConstant.True;
      this.Levels = this.Levels_DefaultValue = new PlotOptionsTreemapLevels();
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Point = this.Point_DefaultValue = new PlotOptionsTreemapPoint();
      nullable3 = new bool?(false);
      this.Selected_DefaultValue = nullable3;
      this.Selected = nullable3;
      Shadow shadow1 = new Shadow();
      shadow1.Enabled = false;
      Shadow shadow2 = shadow1;
      this.Shadow_DefaultValue = shadow1;
      this.Shadow = shadow2;
      nullable3 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable3;
      this.ShowCheckbox = nullable3;
      nullable3 = new bool?(false);
      this.ShowInLegend_DefaultValue = nullable3;
      this.ShowInLegend = nullable3;
      this.States = this.States_DefaultValue = new PlotOptionsTreemapStates();
      nullable3 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable3;
      this.StickyTracking = nullable3;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsTreemapTooltip();
      nullable2 = new double?(1000.0);
      this.TurboThreshold_DefaultValue = nullable2;
      this.TurboThreshold = nullable2;
      nullable3 = new bool?(true);
      this.Visible_DefaultValue = nullable3;
      this.Visible = nullable3;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsTreemapZones();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.AllowDrillToNode != this.AllowDrillToNode_DefaultValue)
        hashtable.Add((object) "allowDrillToNode", (object) Highcharts.FirstCharacterToLower(this.AllowDrillToNode.ToString()));
      bool? nullable1 = this.AllowPointSelect;
      bool? nullable2 = this.AllowPointSelect_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
      if (this.AlternateStartingDirection != this.AlternateStartingDirection_DefaultValue)
        hashtable.Add((object) "alternateStartingDirection", (object) Highcharts.FirstCharacterToLower(this.AlternateStartingDirection.ToString()));
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? nullable3 = this.BorderWidth;
      double? nullable4 = this.BorderWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      nullable2 = this.ColorByPoint;
      nullable1 = this.ColorByPoint_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "colorByPoint", (object) this.ColorByPoint);
      if (this.Colors != this.Colors_DefaultValue)
        hashtable.Add((object) "colors", (object) this.Colors);
      nullable4 = this.CropThreshold;
      nullable3 = this.CropThreshold_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      nullable1 = this.EnableMouseTracking;
      nullable2 = this.EnableMouseTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      nullable2 = this.InteractByLeaf;
      nullable1 = this.InteractByLeaf_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "interactByLeaf", (object) this.InteractByLeaf);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      if (this.LayoutAlgorithm != this.LayoutAlgorithm_DefaultValue)
        hashtable.Add((object) "layoutAlgorithm", (object) Highcharts.FirstCharacterToLower(this.LayoutAlgorithm.ToString()));
      if (this.LayoutStartingDirection != this.LayoutStartingDirection_DefaultValue)
        hashtable.Add((object) "layoutStartingDirection", (object) Highcharts.FirstCharacterToLower(this.LayoutStartingDirection.ToString()));
      if (this.LevelIsConstant != this.LevelIsConstant_DefaultValue)
        hashtable.Add((object) "levelIsConstant", (object) Highcharts.FirstCharacterToLower(this.LevelIsConstant.ToString()));
      if (this.Levels.IsDirty())
        hashtable.Add((object) "levels", (object) this.Levels.ToHashtable());
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable1 = this.Selected;
      nullable2 = this.Selected_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      nullable2 = this.ShowCheckbox;
      nullable1 = this.ShowCheckbox_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable1 = this.ShowInLegend;
      nullable2 = this.ShowInLegend_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable2 = this.StickyTracking;
      nullable1 = this.StickyTracking_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable3 = this.TurboThreshold;
      nullable4 = this.TurboThreshold_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
      nullable1 = this.Visible;
      nullable2 = this.Visible_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
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