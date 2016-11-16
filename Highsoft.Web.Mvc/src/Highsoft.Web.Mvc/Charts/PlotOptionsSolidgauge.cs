
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsSolidgauge




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsSolidgauge : BaseObject
  {
    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public PlotOptionsSolidgaugeCursor Cursor { get; set; }

    private PlotOptionsSolidgaugeCursor Cursor_DefaultValue { get; set; }

    public PlotOptionsSolidgaugeDataLabels DataLabels { get; set; }

    private PlotOptionsSolidgaugeDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public PlotOptionsSolidgaugeEvents Events { get; set; }

    private PlotOptionsSolidgaugeEvents Events_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public double? Overshoot { get; set; }

    private double? Overshoot_DefaultValue { get; set; }

    public PlotOptionsSolidgaugePoint Point { get; set; }

    private PlotOptionsSolidgaugePoint Point_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public PlotOptionsSolidgaugeStates States { get; set; }

    private PlotOptionsSolidgaugeStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public PlotOptionsSolidgaugeTooltip Tooltip { get; set; }

    private PlotOptionsSolidgaugeTooltip Tooltip_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public bool? Wrap { get; set; }

    private bool? Wrap_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PlotOptionsSolidgaugeZones Zones { get; set; }

    private PlotOptionsSolidgaugeZones Zones_DefaultValue { get; set; }

    public PlotOptionsSolidgauge()
    {
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.Cursor = this.Cursor_DefaultValue = PlotOptionsSolidgaugeCursor.Null;
      this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsSolidgaugeDataLabels();
      bool? nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new PlotOptionsSolidgaugeEvents();
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable2 = new double?(0.0);
      this.Overshoot_DefaultValue = nullable2;
      this.Overshoot = nullable2;
      this.Point = this.Point_DefaultValue = new PlotOptionsSolidgaugePoint();
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      nullable1 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable1;
      this.ShowCheckbox = nullable1;
      bool? nullable3 = new bool?();
      this.ShowInLegend_DefaultValue = nullable3;
      this.ShowInLegend = nullable3;
      this.States = this.States_DefaultValue = new PlotOptionsSolidgaugeStates();
      nullable3 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable3;
      this.StickyTracking = nullable3;
      this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsSolidgaugeTooltip();
      nullable3 = new bool?(true);
      this.Visible_DefaultValue = nullable3;
      this.Visible = nullable3;
      nullable3 = new bool?(true);
      this.Wrap_DefaultValue = nullable3;
      this.Wrap = nullable3;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PlotOptionsSolidgaugeZones();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      bool? nullable1 = this.EnableMouseTracking;
      bool? nullable2 = this.EnableMouseTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      double? overshoot = this.Overshoot;
      double? overshootDefaultValue = this.Overshoot_DefaultValue;
      if ((overshoot.GetValueOrDefault() == overshootDefaultValue.GetValueOrDefault() ? (overshoot.HasValue != overshootDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "overshoot", (object) this.Overshoot);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      nullable2 = this.Selected;
      nullable1 = this.Selected_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      nullable1 = this.ShowCheckbox;
      nullable2 = this.ShowCheckbox_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable2 = this.ShowInLegend;
      nullable1 = this.ShowInLegend_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable1 = this.StickyTracking;
      nullable2 = this.StickyTracking_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      nullable2 = this.Visible;
      nullable1 = this.Visible_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      nullable1 = this.Wrap;
      nullable2 = this.Wrap_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "wrap", (object) this.Wrap);
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
