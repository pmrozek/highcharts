
// Type: Highsoft.Web.Mvc.Charts.PieSeries




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PieSeries : Series
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

    public PieSeriesCursor Cursor { get; set; }

    private PieSeriesCursor Cursor_DefaultValue { get; set; }

    public List<PieSeriesData> Data { get; set; }

    private List<PieSeriesData> Data_DefaultValue { get; set; }

    public PieSeriesDataLabels DataLabels { get; set; }

    private PieSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public double? Depth { get; set; }

    private double? Depth_DefaultValue { get; set; }

    public bool? EnableMouseTracking { get; set; }

    private bool? EnableMouseTracking_DefaultValue { get; set; }

    public double? EndAngle { get; set; }

    private double? EndAngle_DefaultValue { get; set; }

    public PieSeriesEvents Events { get; set; }

    private PieSeriesEvents Events_DefaultValue { get; set; }

    public new string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public bool? IgnoreHiddenPoint { get; set; }

    private bool? IgnoreHiddenPoint_DefaultValue { get; set; }

    public new double? Index { get; set; }

    private double? Index_DefaultValue { get; set; }

    public string InnerSize { get; set; }

    private string InnerSize_DefaultValue { get; set; }

    public List<string> Keys { get; set; }

    private List<string> Keys_DefaultValue { get; set; }

    public new double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public string LinkedTo { get; set; }

    private string LinkedTo_DefaultValue { get; set; }

    public double? MinSize { get; set; }

    private double? MinSize_DefaultValue { get; set; }

    public new string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public PieSeriesPoint Point { get; set; }

    private PieSeriesPoint Point_DefaultValue { get; set; }

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

    public PieSeriesStates States { get; set; }

    private PieSeriesStates States_DefaultValue { get; set; }

    public bool? StickyTracking { get; set; }

    private bool? StickyTracking_DefaultValue { get; set; }

    public PieSeriesTooltip Tooltip { get; set; }

    private PieSeriesTooltip Tooltip_DefaultValue { get; set; }

    public PieSeriesType Type { get; set; }

    private PieSeriesType Type_DefaultValue { get; set; }

    public bool? Visible { get; set; }

    private bool? Visible_DefaultValue { get; set; }

    public new double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public string ZoneAxis { get; set; }

    private string ZoneAxis_DefaultValue { get; set; }

    public PieSeriesZones Zones { get; set; }

    private PieSeriesZones Zones_DefaultValue { get; set; }

    public PieSeries()
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
      this.Cursor = this.Cursor_DefaultValue = PieSeriesCursor.Null;
      this.Data = this.Data_DefaultValue = new List<PieSeriesData>();
      this.DataLabels = this.DataLabels_DefaultValue = new PieSeriesDataLabels();
      nullable2 = new double?(0.0);
      this.Depth_DefaultValue = nullable2;
      this.Depth = nullable2;
      nullable1 = new bool?(true);
      this.EnableMouseTracking_DefaultValue = nullable1;
      this.EnableMouseTracking = nullable1;
      double? nullable3 = new double?();
      this.EndAngle_DefaultValue = nullable3;
      this.EndAngle = nullable3;
      this.Events = this.Events_DefaultValue = new PieSeriesEvents();
      this.Id = this.Id_DefaultValue = "";
      nullable1 = new bool?(true);
      this.IgnoreHiddenPoint_DefaultValue = nullable1;
      this.IgnoreHiddenPoint = nullable1;
      double? nullable4 = new double?();
      this.Index_DefaultValue = nullable4;
      this.Index = nullable4;
      this.InnerSize = this.InnerSize_DefaultValue = "0";
      this.Keys = this.Keys_DefaultValue = new List<string>();
      double? nullable5 = new double?();
      this.LegendIndex_DefaultValue = nullable5;
      this.LegendIndex = nullable5;
      this.LinkedTo = this.LinkedTo_DefaultValue = "";
      nullable5 = new double?(80.0);
      this.MinSize_DefaultValue = nullable5;
      this.MinSize = nullable5;
      this.Name = this.Name_DefaultValue = (string) null;
      this.Point = this.Point_DefaultValue = new PieSeriesPoint();
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
      nullable5 = new double?(10.0);
      this.SlicedOffset_DefaultValue = nullable5;
      this.SlicedOffset = nullable5;
      nullable5 = new double?(0.0);
      this.StartAngle_DefaultValue = nullable5;
      this.StartAngle = nullable5;
      this.States = this.States_DefaultValue = new PieSeriesStates();
      nullable1 = new bool?(false);
      this.StickyTracking_DefaultValue = nullable1;
      this.StickyTracking = nullable1;
      this.Tooltip = this.Tooltip_DefaultValue = new PieSeriesTooltip();
      this.Type = this.Type_DefaultValue = PieSeriesType.Null;
      nullable1 = new bool?(true);
      this.Visible_DefaultValue = nullable1;
      this.Visible = nullable1;
      double? nullable6 = new double?();
      this.ZIndex_DefaultValue = nullable6;
      this.ZIndex = nullable6;
      this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
      this.Zones = this.Zones_DefaultValue = new PieSeriesZones();
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
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      nullable3 = this.IgnoreHiddenPoint;
      bool? nullable4 = this.IgnoreHiddenPoint_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "ignoreHiddenPoint", (object) this.IgnoreHiddenPoint);
      nullable1 = this.Index;
      nullable2 = this.Index_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "index", (object) this.Index);
      if (this.InnerSize != this.InnerSize_DefaultValue)
        hashtable.Add((object) "innerSize", (object) this.InnerSize);
      if (this.Keys != this.Keys_DefaultValue)
        hashtable.Add((object) "keys", (object) this.Keys);
      nullable2 = this.LegendIndex;
      nullable1 = this.LegendIndex_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.LinkedTo != this.LinkedTo_DefaultValue)
        hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
      nullable1 = this.MinSize;
      nullable2 = this.MinSize_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "minSize", (object) this.MinSize);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
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
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
      nullable3 = this.Visible;
      nullable4 = this.Visible_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "visible", (object) this.Visible);
      nullable2 = this.ZIndex;
      nullable1 = this.ZIndex_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
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
