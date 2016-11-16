
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsPie




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsPie : BaseObject
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public string[] Center { get; set; }

    private string[] Center_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public PlotOptionsPieCursor Cursor { get; set; }

    private PlotOptionsPieCursor Cursor_DefaultValue { get; set; }

    public PlotOptionsPieDataLabels DataLabels { get; set; }

    private PlotOptionsPieDataLabels DataLabels_DefaultValue { get; set; }

    public double? Depth { get; set; }

    private double? Depth_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public double? EndAngle { get; set; }

    private double? EndAngle_DefaultValue { get; set; }

    public PlotOptionsPieEvents Events { get; set; }

    private PlotOptionsPieEvents Events_DefaultValue { get; set; }

    public bool? IgnoreHiddenPoint { get; set; }

    private bool? IgnoreHiddenPoint_DefaultValue { get; set; }

    public string InnerSize { get; set; }

    private string InnerSize_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public double? MinSize { get; set; }

    private double? MinSize_DefaultValue { get; set; }

    public PlotOptionsPiePoint Point { get; set; }

    private PlotOptionsPiePoint Point_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public string Size { get; set; }

    private string Size_DefaultValue { get; set; }

    public double? SlicedOffset { get; set; }

    private double? SlicedOffset_DefaultValue { get; set; }

    public double? StartAngle { get; set; }

    private double? StartAngle_DefaultValue { get; set; }

    public PlotOptionsPieStates States { get; set; }

    private PlotOptionsPieStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public PlotOptionsPieTooltip Tooltip { get; set; }

    private PlotOptionsPieTooltip Tooltip_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsPieZones Zones { get; set; }

    private PlotOptionsPieZones Zones_DefaultValue { get; set; }

    public PlotOptionsPie()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.BorderColor = this.BorderColor_DefaultValue = "#FFFFFF";
      double? nullable2 = new double?(1.0);
      this.BorderWidth_DefaultValue = nullable2;
      this.BorderWidth = nullable2;
      this.Center = this.Center_DefaultValue = new string[2];
      this.Colors = this.Colors_DefaultValue = new List<string>();
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsPieCursor.Null;
      this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsPieDataLabels();
      nullable2 = new double?(0.0);
      this.Depth_DefaultValue = nullable2;
      this.Depth = nullable2;
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      double? nullable3 = new double?();
      this.EndAngle_DefaultValue = nullable3;
      this.EndAngle = nullable3;
      this.Events = this.Events_DefaultValue = new PlotOptionsPieEvents();
      nullable1 = new bool?(true);
      this.IgnoreHiddenPoint_DefaultValue = nullable1;
      this.IgnoreHiddenPoint = nullable1;
      this.InnerSize = this.InnerSize_DefaultValue = "0";
      this.Keys = this.Keys_DefaultValue = new List<string>();
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      nullable3 = new double?(80.0);
      this.MinSize_DefaultValue = nullable3;
      this.MinSize = nullable3;
      this.Point = this.Point_DefaultValue = new PlotOptionsPiePoint();
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
      this.Size = this.Size_DefaultValue = " ";
      nullable3 = new double?(10.0);
      this.SlicedOffset_DefaultValue = nullable3;
      this.SlicedOffset = nullable3;
      nullable3 = new double?(0.0);
      this.StartAngle_DefaultValue = nullable3;
      this.StartAngle = nullable3;
      this.States = this.States_DefaultValue = new PlotOptionsPieStates();
      nullable1 = new bool?(false);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsPieTooltip();
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsPieZones();
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
      nullable2 = this.EndAngle;
      nullable1 = this.EndAngle_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "endAngle", (object) this.EndAngle);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      nullable3 = this.IgnoreHiddenPoint;
      bool? nullable4 = this.IgnoreHiddenPoint_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "ignoreHiddenPoint", (object) this.IgnoreHiddenPoint);
      if (this.InnerSize != this.InnerSize_DefaultValue)
        hashtable.Add((object) "innerSize", (object) this.InnerSize);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      nullable1 = this.MinSize;
      nullable2 = this.MinSize_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minSize", (object) this.MinSize);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
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
      if (this.Size != this.Size_DefaultValue)
        hashtable.Add((object) "size", (object) this.Size);
      nullable2 = this.SlicedOffset;
      nullable1 = this.SlicedOffset_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "slicedOffset", (object) this.SlicedOffset);
      nullable1 = this.StartAngle;
      nullable2 = this.StartAngle_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "startAngle", (object) this.StartAngle);
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
