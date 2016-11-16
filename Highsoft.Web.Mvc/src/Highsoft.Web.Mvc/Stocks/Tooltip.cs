
// Type: Highsoft.Web.Mvc.Stocks.Tooltip




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class Tooltip : BaseObject
  {
    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public string BackgroundColor { get; set; }

    private string BackgroundColor_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderRadius { get; set; }

    private double? BorderRadius_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public double? ChangeDecimals { get; set; }

    private double? ChangeDecimals_DefaultValue { get; set; }

    public List<Crosshair> Crosshairs { get; set; }

    private List<Crosshair> Crosshairs_DefaultValue { get; set; }

    public Hashtable DateTimeLabelFormats { get; set; }

    private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public bool? FollowPointer { get; set; }

    private bool? FollowPointer_DefaultValue { get; set; }

    public bool? FollowTouchMove { get; set; }

    private bool? FollowTouchMove_DefaultValue { get; set; }

    public string Formatter { get; set; }

    private string Formatter_DefaultValue { get; set; }

    public string HeaderFormat { get; set; }

    private string HeaderFormat_DefaultValue { get; set; }

    public string PointFormat { get; set; }

    private string PointFormat_DefaultValue { get; set; }

    public string PointFormatter { get; set; }

    private string PointFormatter_DefaultValue { get; set; }

    public string Positioner { get; set; }

    private string Positioner_DefaultValue { get; set; }

    public Shadow Shadow { get; set; }

    private Shadow Shadow_DefaultValue { get; set; }

    public string Shape { get; set; }

    private string Shape_DefaultValue { get; set; }

    public bool? Shared { get; set; }

    private bool? Shared_DefaultValue { get; set; }

    public double? Snap { get; set; }

    private double? Snap_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public bool? UseHTML { get; set; }

    private bool? UseHTML_DefaultValue { get; set; }

    public double? ValueDecimals { get; set; }

    private double? ValueDecimals_DefaultValue { get; set; }

    public string ValuePrefix { get; set; }

    private string ValuePrefix_DefaultValue { get; set; }

    public string ValueSuffix { get; set; }

    private string ValueSuffix_DefaultValue { get; set; }

    public string XDateFormat { get; set; }

    private string XDateFormat_DefaultValue { get; set; }

    public Tooltip()
    {
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.BackgroundColor = this.BackgroundColor_DefaultValue = "rgba(255, 255, 255, 0.85)";
      this.BorderColor = this.BorderColor_DefaultValue = "null";
      double? nullable1 = new double?(3.0);
      this.BorderRadius_DefaultValue = nullable1;
      this.BorderRadius = nullable1;
      nullable1 = new double?(1.0);
      this.BorderWidth_DefaultValue = nullable1;
      this.BorderWidth = nullable1;
      double? nullable2 = new double?();
      this.ChangeDecimals_DefaultValue = nullable2;
      this.ChangeDecimals = nullable2;
      this.Crosshairs = this.Crosshairs_DefaultValue = new List<Crosshair>();
      this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
      bool? nullable3 = new bool?(true);
      this.Enabled_DefaultValue = nullable3;
      this.Enabled = nullable3;
      nullable3 = new bool?(false);
      this.FollowPointer_DefaultValue = nullable3;
      this.FollowPointer = nullable3;
      nullable3 = new bool?(true);
      this.FollowTouchMove_DefaultValue = nullable3;
      this.FollowTouchMove = nullable3;
      this.Formatter = this.Formatter_DefaultValue = "";
      this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
      this.PointFormat = this.PointFormat_DefaultValue = "<span style='color:{point.color}'>●\x008F</span> {series.name}: <b>{point.y}</b><br/>";
      this.PointFormatter = this.PointFormatter_DefaultValue = "";
      this.Positioner = this.Positioner_DefaultValue = "";
      Shadow shadow1 = new Shadow();
      shadow1.Enabled = false;
      Shadow shadow2 = shadow1;
      this.Shadow_DefaultValue = shadow1;
      this.Shadow = shadow2;
      this.Shape = this.Shape_DefaultValue = "callout";
      nullable3 = new bool?(true);
      this.Shared_DefaultValue = nullable3;
      this.Shared = nullable3;
      nullable2 = new double?(0.0);
      this.Snap_DefaultValue = nullable2;
      this.Snap = nullable2;
      this.Style = this.Style_DefaultValue = new Hashtable();
      nullable3 = new bool?(false);
      this.UseHTML_DefaultValue = nullable3;
      this.UseHTML = nullable3;
      double? nullable4 = new double?();
      this.ValueDecimals_DefaultValue = nullable4;
      this.ValueDecimals = nullable4;
      this.ValuePrefix = this.ValuePrefix_DefaultValue = (string) null;
      this.ValueSuffix = this.ValueSuffix_DefaultValue = (string) null;
      this.XDateFormat = this.XDateFormat_DefaultValue = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
        hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? nullable1 = this.BorderRadius;
      double? nullable2 = this.BorderRadius_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
      nullable2 = this.BorderWidth;
      nullable1 = this.BorderWidth_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      nullable1 = this.ChangeDecimals;
      nullable2 = this.ChangeDecimals_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "changeDecimals", (object) this.ChangeDecimals);
      if (this.Crosshairs != this.Crosshairs_DefaultValue)
        hashtable.Add((object) "crosshairs", (object) this.Crosshairs);
      if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
        hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
      bool? nullable3 = this.Enabled;
      bool? nullable4 = this.Enabled_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      nullable4 = this.FollowPointer;
      nullable3 = this.FollowPointer_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "followPointer", (object) this.FollowPointer);
      nullable3 = this.FollowTouchMove;
      nullable4 = this.FollowTouchMove_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
      if (this.Formatter != this.Formatter_DefaultValue)
      {
        hashtable.Add((object) "formatter", (object) this.Formatter);
        Highstock.AddFunction("TooltipFormatter.formatter", this.Formatter);
      }
      if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
        hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
      if (this.PointFormat != this.PointFormat_DefaultValue)
        hashtable.Add((object) "pointFormat", (object) this.PointFormat);
      if (this.PointFormatter != this.PointFormatter_DefaultValue)
      {
        hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
        Highstock.AddFunction("TooltipPointFormatter.pointFormatter", this.PointFormatter);
      }
      if (this.Positioner != this.Positioner_DefaultValue)
      {
        hashtable.Add((object) "positioner", (object) this.Positioner);
        Highstock.AddFunction("TooltipPositioner.positioner", this.Positioner);
      }
      if (this.Shadow != this.Shadow_DefaultValue)
        hashtable.Add((object) "shadow", (object) this.Shadow);
      if (this.Shape != this.Shape_DefaultValue)
        hashtable.Add((object) "shape", (object) this.Shape);
      nullable4 = this.Shared;
      nullable3 = this.Shared_DefaultValue;
      if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "shared", (object) this.Shared);
      nullable2 = this.Snap;
      nullable1 = this.Snap_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "snap", (object) this.Snap);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      nullable3 = this.UseHTML;
      nullable4 = this.UseHTML_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault() ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "useHTML", (object) this.UseHTML);
      nullable1 = this.ValueDecimals;
      nullable2 = this.ValueDecimals_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "valueDecimals", (object) this.ValueDecimals);
      if (this.ValuePrefix != this.ValuePrefix_DefaultValue)
        hashtable.Add((object) "valuePrefix", (object) this.ValuePrefix);
      if (this.ValueSuffix != this.ValueSuffix_DefaultValue)
        hashtable.Add((object) "valueSuffix", (object) this.ValueSuffix);
      if (this.XDateFormat != this.XDateFormat_DefaultValue)
        hashtable.Add((object) "xDateFormat", (object) this.XDateFormat);
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
