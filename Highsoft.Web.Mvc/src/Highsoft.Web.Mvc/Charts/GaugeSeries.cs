
// Type: Highsoft.Web.Mvc.Charts.GaugeSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class GaugeSeries : Series
  {
    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public GaugeSeriesCursor Cursor { get; set; }

    private GaugeSeriesCursor Cursor_DefaultValue { get; set; }

    public List<GaugeSeriesData> Data { get; set; }

    private List<GaugeSeriesData> Data_DefaultValue { get; set; }

    public GaugeSeriesDataLabels DataLabels { get; set; }

    private GaugeSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public GaugeSeriesDial Dial { get; set; }

    private GaugeSeriesDial Dial_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public GaugeSeriesEvents Events { get; set; }

    private GaugeSeriesEvents Events_DefaultValue { get; set; }

    public new string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public new double? Index { get; set; }

    private double? Index_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public new double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public string NegativeColor { get; set; }

    private string NegativeColor_DefaultValue { get; set; }

    public double? Overshoot { get; set; }

    private double? Overshoot_DefaultValue { get; set; }

    public GaugeSeriesPivot Pivot { get; set; }

    private GaugeSeriesPivot Pivot_DefaultValue { get; set; }

    public GaugeSeriesPoint Point { get; set; }

    private GaugeSeriesPoint Point_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public GaugeSeriesStates States { get; set; }

    private GaugeSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public double? Threshold { get; set; }

    private double? Threshold_DefaultValue { get; set; }

    public GaugeSeriesTooltip Tooltip { get; set; }

    private GaugeSeriesTooltip Tooltip_DefaultValue { get; set; }

    public GaugeSeriesType Type { get; set; }

    private GaugeSeriesType Type_DefaultValue { get; set; }

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

    public GaugeSeriesZones Zones { get; set; }

    private GaugeSeriesZones Zones_DefaultValue { get; set; }

    public GaugeSeries()
    {
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.Color = this.Color_DefaultValue = (string) null;
      this.Cursor = this.Cursor_DefaultValue = GaugeSeriesCursor.Null;
      this.Data = this.Data_DefaultValue = new List<GaugeSeriesData>();
      this.DataLabels = this.DataLabels_DefaultValue = new GaugeSeriesDataLabels();
      this.Dial = this.Dial_DefaultValue = new GaugeSeriesDial();
      bool? nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new GaugeSeriesEvents();
      this.Id = this.Id_DefaultValue = "";
      double? nullable2 = new double?();
      this.Index_DefaultValue = nullable2;
      this.Index = nullable2;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable3 = new double?();
      this.LegendIndex_DefaultValue = nullable3;
      this.LegendIndex = nullable3;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Name = this.Name_DefaultValue = (string) null;
      this.NegativeColor = this.NegativeColor_DefaultValue = "null";
      nullable3 = new double?(0.0);
      this.Overshoot_DefaultValue = nullable3;
      this.Overshoot = nullable3;
      this.Pivot = this.Pivot_DefaultValue = new GaugeSeriesPivot();
      this.Point = this.Point_DefaultValue = new GaugeSeriesPoint();
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      nullable1 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable1;
      this.ShowCheckbox = nullable1;
      bool? nullable4 = new bool?();
      this.ShowInLegend_DefaultValue = nullable4;
      this.ShowInLegend = nullable4;
      this.States = this.States_DefaultValue = new GaugeSeriesStates();
      nullable4 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable4;
      this.StickyTracking = nullable4;
      nullable3 = new double?(0.0);
      this.Threshold_DefaultValue = nullable3;
      this.Threshold = nullable3;
      this.Tooltip = this.Tooltip_DefaultValue = new GaugeSeriesTooltip();
      this.Type = this.Type_DefaultValue = GaugeSeriesType.Null;
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
      this.Zones = this.Zones_DefaultValue = new GaugeSeriesZones();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      if (this.Dial.IsDirty())
        hashtable.Add((object) "dial", (object) this.Dial.ToHashtable());
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
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      if (this.NegativeColor != this.NegativeColor_DefaultValue)
        hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
      nullable3 = this.Overshoot;
      nullable4 = this.Overshoot_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "overshoot", (object) this.Overshoot);
      if (this.Pivot.IsDirty())
        hashtable.Add((object) "pivot", (object) this.Pivot.ToHashtable());
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
      nullable4 = this.Threshold;
      nullable3 = this.Threshold_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "threshold", (object) this.Threshold);
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
      nullable3 = this.ZIndex;
      nullable4 = this.ZIndex_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
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
