
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsOhlcTooltip




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsOhlcTooltip : BaseObject
  {
    public double? ChangeDecimals { get; set; }

    private double? ChangeDecimals_DefaultValue { get; set; }

    public Hashtable DateTimeLabelFormats { get; set; }

    private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

    public bool? FollowPointer { get; set; }

    private bool? FollowPointer_DefaultValue { get; set; }

    public bool? FollowTouchMove { get; set; }

    private bool? FollowTouchMove_DefaultValue { get; set; }

    public string HeaderFormat { get; set; }

    private string HeaderFormat_DefaultValue { get; set; }

    public string PointFormat { get; set; }

    private string PointFormat_DefaultValue { get; set; }

    public string PointFormatter { get; set; }

    private string PointFormatter_DefaultValue { get; set; }

    public string Shape { get; set; }

    private string Shape_DefaultValue { get; set; }

    public double? ValueDecimals { get; set; }

    private double? ValueDecimals_DefaultValue { get; set; }

    public string ValuePrefix { get; set; }

    private string ValuePrefix_DefaultValue { get; set; }

    public string ValueSuffix { get; set; }

    private string ValueSuffix_DefaultValue { get; set; }

    public string XDateFormat { get; set; }

    private string XDateFormat_DefaultValue { get; set; }

    public PlotOptionsOhlcTooltip()
    {
      double? nullable1 = new double?();
      this.ChangeDecimals_DefaultValue = nullable1;
      this.ChangeDecimals = nullable1;
      this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
      bool? nullable2 = new bool?(false);
      this.FollowPointer_DefaultValue = nullable2;
      this.FollowPointer = nullable2;
      nullable2 = new bool?(true);
      this.FollowTouchMove_DefaultValue = nullable2;
      this.FollowTouchMove = nullable2;
      this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
      this.PointFormat = this.PointFormat_DefaultValue = "<span style='color:{point.color}'>●\x008F</span> {series.name}: <b>{point.y}</b><br/>";
      this.PointFormatter = this.PointFormatter_DefaultValue = "";
      this.Shape = this.Shape_DefaultValue = "callout";
      double? nullable3 = new double?();
      this.ValueDecimals_DefaultValue = nullable3;
      this.ValueDecimals = nullable3;
      this.ValuePrefix = this.ValuePrefix_DefaultValue = (string) null;
      this.ValueSuffix = this.ValueSuffix_DefaultValue = (string) null;
      this.XDateFormat = this.XDateFormat_DefaultValue = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      double? changeDecimals = this.ChangeDecimals;
      double? decimalsDefaultValue1 = this.ChangeDecimals_DefaultValue;
      if ((changeDecimals.GetValueOrDefault() == decimalsDefaultValue1.GetValueOrDefault() ? (changeDecimals.HasValue != decimalsDefaultValue1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "changeDecimals", (object) this.ChangeDecimals);
      if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
        hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
      bool? followPointer = this.FollowPointer;
      bool? nullable = this.FollowPointer_DefaultValue;
      if ((followPointer.GetValueOrDefault() == nullable.GetValueOrDefault() ? (followPointer.HasValue != nullable.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "followPointer", (object) this.FollowPointer);
      nullable = this.FollowTouchMove;
      bool? moveDefaultValue = this.FollowTouchMove_DefaultValue;
      if ((nullable.GetValueOrDefault() == moveDefaultValue.GetValueOrDefault() ? (nullable.HasValue != moveDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
      if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
        hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
      if (this.PointFormat != this.PointFormat_DefaultValue)
        hashtable.Add((object) "pointFormat", (object) this.PointFormat);
      if (this.PointFormatter != this.PointFormatter_DefaultValue)
      {
        hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
        Highstock.AddFunction("PlotOptionsOhlcTooltipPointFormatter.pointFormatter", this.PointFormatter);
      }
      if (this.Shape != this.Shape_DefaultValue)
        hashtable.Add((object) "shape", (object) this.Shape);
      double? valueDecimals = this.ValueDecimals;
      double? decimalsDefaultValue2 = this.ValueDecimals_DefaultValue;
      if ((valueDecimals.GetValueOrDefault() == decimalsDefaultValue2.GetValueOrDefault() ? (valueDecimals.HasValue != decimalsDefaultValue2.HasValue ? 1 : 0) : 1) != 0)
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
