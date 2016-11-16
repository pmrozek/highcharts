
// Type: Highsoft.Web.Mvc.Charts.SolidgaugeSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class SolidgaugeSeries : Series
  {
    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public SolidgaugeSeriesCursor Cursor { get; set; }

    private SolidgaugeSeriesCursor Cursor_DefaultValue { get; set; }

    public List<SolidgaugeSeriesData> Data { get; set; }

    private List<SolidgaugeSeriesData> Data_DefaultValue { get; set; }

    public SolidgaugeSeriesDataLabels DataLabels { get; set; }

    private SolidgaugeSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public SolidgaugeSeriesEvents Events { get; set; }

    private SolidgaugeSeriesEvents Events_DefaultValue { get; set; }

    public new string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public new double? Index { get; set; }

    private double? Index_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public new double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public double? Overshoot { get; set; }

    private double? Overshoot_DefaultValue { get; set; }

    public SolidgaugeSeriesPoint Point { get; set; }

    private SolidgaugeSeriesPoint Point_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public SolidgaugeSeriesStates States { get; set; }

    private SolidgaugeSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public SolidgaugeSeriesTooltip Tooltip { get; set; }

    private SolidgaugeSeriesTooltip Tooltip_DefaultValue { get; set; }

    public SolidgaugeSeriesType Type { get; set; }

    private SolidgaugeSeriesType Type_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public bool? Wrap { get; set; }

    private bool? Wrap_DefaultValue { get; set; }

    public new string XAxis { get; set; }

    private string XAxis_DefaultValue { get; set; }

    public new string YAxis { get; set; }

    private string YAxis_DefaultValue { get; set; }

    public new double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public SolidgaugeSeriesZones Zones { get; set; }

    private SolidgaugeSeriesZones Zones_DefaultValue { get; set; }

    public SolidgaugeSeries()
    {
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.Cursor = this.Cursor_DefaultValue = SolidgaugeSeriesCursor.Null;
      this.Data = this.Data_DefaultValue = new List<SolidgaugeSeriesData>();
      this.DataLabels = this.DataLabels_DefaultValue = new SolidgaugeSeriesDataLabels();
      bool? nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new SolidgaugeSeriesEvents();
      this.Id = this.Id_DefaultValue = "";
      double? nullable2 = new double?();
      this.Index_DefaultValue = nullable2;
      this.Index = nullable2;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable3 = new double?();
      this.LegendIndex_DefaultValue = nullable3;
      this.LegendIndex = nullable3;
      this.Name = this.Name_DefaultValue = (string) null;
      nullable3 = new double?(0.0);
      this.Overshoot_DefaultValue = nullable3;
      this.Overshoot = nullable3;
      this.Point = this.Point_DefaultValue = new SolidgaugeSeriesPoint();
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      nullable1 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable1;
      this.ShowCheckbox = nullable1;
      bool? nullable4 = new bool?();
      this.ShowInLegend_DefaultValue = nullable4;
      this.ShowInLegend = nullable4;
      this.States = this.States_DefaultValue = new SolidgaugeSeriesStates();
      nullable4 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable4;
      this.StickyTracking = nullable4;
      this.Tooltip = this.Tooltip_DefaultValue = new SolidgaugeSeriesTooltip();
      this.Type = this.Type_DefaultValue = SolidgaugeSeriesType.Null;
      nullable4 = new bool?(true);
      this.Visible_DefaultValue = nullable4;
      this.Visible = nullable4;
      nullable4 = new bool?(true);
      this.Wrap_DefaultValue = nullable4;
      this.Wrap = nullable4;
      this.XAxis = this.XAxis_DefaultValue = "0";
      this.YAxis = this.YAxis_DefaultValue = "0";
      double? nullable5 = new double?();
      this.ZIndex_DefaultValue = nullable5;
      this.ZIndex = nullable5;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new SolidgaugeSeriesZones();
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
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      double? nullable3 = this.Index;
      double? nullable4 = this.Index_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "index", (object) this.Index);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable4 = this.LegendIndex;
      nullable3 = this.LegendIndex_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      nullable3 = this.Overshoot;
      nullable4 = this.Overshoot_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
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
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
      nullable2 = this.Visible;
      nullable1 = this.Visible_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      nullable1 = this.Wrap;
      nullable2 = this.Wrap_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "wrap", (object) this.Wrap);
      if (this.XAxis != this.XAxis_DefaultValue)
        hashtable.Add((object) "xAxis", (object) this.XAxis);
      if (this.YAxis != this.YAxis_DefaultValue)
        hashtable.Add((object) "yAxis", (object) this.YAxis);
      nullable4 = this.ZIndex;
      nullable3 = this.ZIndex_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
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
