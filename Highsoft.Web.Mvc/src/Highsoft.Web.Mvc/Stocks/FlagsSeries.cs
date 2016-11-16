
// Type: Highsoft.Web.Mvc.Stocks.FlagsSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class FlagsSeries : Series
  {
    public bool? AllowPointSelect { get; set; }

    private bool? AllowPointSelect_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public List<string> Colors { get; set; }

    private List<string> Colors_DefaultValue { get; set; }

    public double? CropThreshold { get; set; }

    private double? CropThreshold_DefaultValue { get; set; }

    public FlagsSeriesCursor Cursor { get; set; }

    private FlagsSeriesCursor Cursor_DefaultValue { get; set; }

    public List<FlagsSeriesData> Data { get; set; }

    private List<FlagsSeriesData> Data_DefaultValue { get; set; }

    public FlagsSeriesDataLabels DataLabels { get; set; }

    private FlagsSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public FlagsSeriesEvents Events { get; set; }

    private FlagsSeriesEvents Events_DefaultValue { get; set; }

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

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public string OnSeries { get; set; }

    private string OnSeries_DefaultValue { get; set; }

    public FlagsSeriesPoint Point { get; set; }

    private FlagsSeriesPoint Point_DefaultValue { get; set; }

    public FlagsSeriesPointIntervalUnit PointIntervalUnit { get; set; }

    private FlagsSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public FlagsSeriesShape Shape { get; set; }

    private FlagsSeriesShape Shape_DefaultValue { get; set; }

    public bool? ShowCheckbox { get; set; }

    private bool? ShowCheckbox_DefaultValue { get; set; }

    public bool? ShowInLegend { get; set; }

    private bool? ShowInLegend_DefaultValue { get; set; }

    public new string Stack { get; set; }

    private string Stack_DefaultValue { get; set; }

    public double? StackDistance { get; set; }

    private double? StackDistance_DefaultValue { get; set; }

    public FlagsSeriesStates States { get; set; }

    private FlagsSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public string Title { get; set; }

    private string Title_DefaultValue { get; set; }

    public FlagsSeriesTooltip Tooltip { get; set; }

    private FlagsSeriesTooltip Tooltip_DefaultValue { get; set; }

    public FlagsSeriesType Type { get; set; }

    private FlagsSeriesType Type_DefaultValue { get; set; }

    public bool? UseHTML { get; set; }

    private bool? UseHTML_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public new string XAxis { get; set; }

    private string XAxis_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public new string YAxis { get; set; }

    private string YAxis_DefaultValue { get; set; }

    public new double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public FlagsSeriesZones Zones { get; set; }

    private FlagsSeriesZones Zones_DefaultValue { get; set; }

    public FlagsSeries()
    {
      bool? nullable1 = new bool?(false);
      this.AllowPointSelect_DefaultValue = nullable1;
      this.AllowPointSelect = nullable1;
      this.Color = this.Color_DefaultValue = "";
      this.Colors = this.Colors_DefaultValue = new List<string>();
      double? nullable2 = new double?(50.0);
      this.CropThreshold_DefaultValue = nullable2;
      this.CropThreshold = nullable2;
      this.Cursor = this.Cursor_DefaultValue = FlagsSeriesCursor.Null;
      this.Data = this.Data_DefaultValue = new List<FlagsSeriesData>();
      this.DataLabels = this.DataLabels_DefaultValue = new FlagsSeriesDataLabels();
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      this.Events = this.Events_DefaultValue = new FlagsSeriesEvents();
      this.Id = this.Id_DefaultValue = "";
      double? nullable3 = new double?();
      this.Index_DefaultValue = nullable3;
      this.Index = nullable3;
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable4 = new double?();
      this.LegendIndex_DefaultValue = nullable4;
      this.LegendIndex = nullable4;
      this.LineColor = this.LineColor_DefaultValue = "'black'";
      nullable4 = new double?(1.0);
      this.LineWidth_DefaultValue = nullable4;
      this.LineWidth = nullable4;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      this.Name = this.Name_DefaultValue = "''";
      this.OnSeries = this.OnSeries_DefaultValue = "undefined";
      this.Point = this.Point_DefaultValue = new FlagsSeriesPoint();
      this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = FlagsSeriesPointIntervalUnit.Null;
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      Shadow shadow1 = new Shadow();
      shadow1.Enabled = false;
      Shadow shadow2 = shadow1;
      this.Shadow_DefaultValue = shadow1;
      this.Shadow = shadow2;
      this.Shape = this.Shape_DefaultValue = FlagsSeriesShape.Flag;
      nullable1 = new bool?(false);
      this.ShowCheckbox_DefaultValue = nullable1;
      this.ShowCheckbox = nullable1;
      nullable1 = new bool?(true);
      this.ShowInLegend_DefaultValue = nullable1;
      this.ShowInLegend = nullable1;
      this.Stack = this.Stack_DefaultValue = "null";
      nullable4 = new double?(12.0);
      this.StackDistance_DefaultValue = nullable4;
      this.StackDistance = nullable4;
      this.States = this.States_DefaultValue = new FlagsSeriesStates();
      nullable1 = new bool?(true);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      this.Style = this.Style_DefaultValue = new Hashtable();
      this.Title = this.Title_DefaultValue = "A";
      this.Tooltip = this.Tooltip_DefaultValue = new FlagsSeriesTooltip();
      this.Type = this.Type_DefaultValue = FlagsSeriesType.Null;
      nullable1 = new bool?(false);
      this.UseHTML_DefaultValue = nullable1;
      this.UseHTML = nullable1;
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      this.XAxis = this.XAxis_DefaultValue = "0";
      nullable4 = new double?(-30.0);
      this.Y_DefaultValue = nullable4;
      this.Y = nullable4;
      this.YAxis = this.YAxis_DefaultValue = "0";
      double? nullable5 = new double?();
      this.ZIndex_DefaultValue = nullable5;
      this.ZIndex = nullable5;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new FlagsSeriesZones();
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
      if (this.Colors != this.Colors_DefaultValue)
        hashtable.Add((object) "colors", (object) this.Colors);
      double? cropThreshold = this.CropThreshold;
      double? nullable1 = this.CropThreshold_DefaultValue;
      if ((cropThreshold.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (cropThreshold.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
      if (this.Cursor != this.Cursor_DefaultValue)
        hashtable.Add((object) "cursor", (object) Highstock.FirstCharacterToLower(this.Cursor.ToString()));
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
      bool? enableMouseTracking = this.EnableMouseTracking;
      bool? nullable2 = this.EnableMouseTracking_DefaultValue;
      if ((enableMouseTracking.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (enableMouseTracking.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      nullable1 = this.Index;
      double? nullable3 = this.Index_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "index", (object) this.Index);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable3 = this.LegendIndex;
      nullable1 = this.LegendIndex_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      nullable1 = this.LineWidth;
      nullable3 = this.LineWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      if (this.OnSeries != this.OnSeries_DefaultValue)
        hashtable.Add((object) "onSeries", (object) this.OnSeries);
      if (this.Point.IsDirty())
        hashtable.Add((object) "point", (object) this.Point.ToHashtable());
      if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
        hashtable.Add((object) "pointIntervalUnit", (object) Highstock.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
      nullable2 = this.Selected;
      bool? nullable4 = this.Selected_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      if (this.Shape != this.Shape_DefaultValue)
        hashtable.Add((object) "shape", (object) Highstock.FirstCharacterToLower(this.Shape.ToString()));
      nullable4 = this.ShowCheckbox;
      nullable2 = this.ShowCheckbox_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
      nullable2 = this.ShowInLegend;
      nullable4 = this.ShowInLegend_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
      if (this.Stack != this.Stack_DefaultValue)
        hashtable.Add((object) "stack", (object) this.Stack);
      nullable3 = this.StackDistance;
      nullable1 = this.StackDistance_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stackDistance", (object) this.StackDistance);
      if (this.States.IsDirty())
        hashtable.Add((object) "states", (object) this.States.ToHashtable());
      nullable4 = this.StickyTracking;
      nullable2 = this.StickyTracking_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      if (this.Title != this.Title_DefaultValue)
        hashtable.Add((object) "title", (object) this.Title);
      if (this.Tooltip.IsDirty())
        hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highstock.FirstCharacterToLower(this.Type.ToString()));
      nullable2 = this.UseHTML;
      nullable4 = this.UseHTML_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "useHTML", (object) this.UseHTML);
      nullable4 = this.Visible;
      nullable2 = this.Visible_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      if (this.XAxis != this.XAxis_DefaultValue)
        hashtable.Add((object) "xAxis", (object) this.XAxis);
      nullable1 = this.Y;
      nullable3 = this.Y_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "y", (object) this.Y);
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
