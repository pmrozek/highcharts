
// Type: Highsoft.Web.Mvc.Stocks.YAxisLabels




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class YAxisLabels : BaseObject
  {
    public string Align { get; set; }

    private string Align_DefaultValue { get; set; }

    public List<double> AutoRotation { get; set; }

    private List<double> AutoRotation_DefaultValue { get; set; }

    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public string Format { get; set; }

    private string Format_DefaultValue { get; set; }

    public string Formatter { get; set; }

    private string Formatter_DefaultValue { get; set; }

    public double? Rotation { get; set; }

    private double? Rotation_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public bool? UseHTML { get; set; }

    private bool? UseHTML_DefaultValue { get; set; }

    public double? X { get; set; }

    private double? X_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public YAxisLabels()
    {
      this.Align = this.Align_DefaultValue = "'left'";
      List<double> doubleList1 = new List<double>();
      doubleList1.Add(-45.0);
      List<double> doubleList2 = doubleList1;
      this.AutoRotation_DefaultValue = doubleList1;
      this.AutoRotation = doubleList2;
      bool? nullable1 = new bool?(true);
      this.Enabled_DefaultValue = nullable1;
      this.Enabled = nullable1;
      this.Format = this.Format_DefaultValue = "{value}";
      this.Formatter = this.Formatter_DefaultValue = "";
      double? nullable2 = new double?(0.0);
      this.Rotation_DefaultValue = nullable2;
      this.Rotation = nullable2;
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "color", (object) "#6D869F");
      hashtable1.Add((object) "fontWeight", (object) "bold");
      Hashtable hashtable2 = hashtable1;
      this.Style_DefaultValue = hashtable1;
      this.Style = hashtable2;
      nullable1 = new bool?(false);
      this.UseHTML_DefaultValue = nullable1;
      this.UseHTML = nullable1;
      nullable2 = new double?(0.0);
      this.X_DefaultValue = nullable2;
      this.X = nullable2;
      nullable2 = new double?(-2.0);
      this.Y_DefaultValue = nullable2;
      this.Y = nullable2;
      nullable2 = new double?(7.0);
      this.ZIndex_DefaultValue = nullable2;
      this.ZIndex = nullable2;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Align != this.Align_DefaultValue)
        hashtable.Add((object) "align", (object) this.Align);
      if (this.AutoRotation != this.AutoRotation_DefaultValue)
        hashtable.Add((object) "autoRotation", (object) this.AutoRotation);
      bool? enabled = this.Enabled;
      bool? nullable1 = this.Enabled_DefaultValue;
      if ((enabled.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (enabled.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      if (this.Format != this.Format_DefaultValue)
        hashtable.Add((object) "format", (object) this.Format);
      if (this.Formatter != this.Formatter_DefaultValue)
      {
        hashtable.Add((object) "formatter", (object) this.Formatter);
        Highstock.AddFunction("YAxisLabelsFormatter.formatter", this.Formatter);
      }
      double? rotation = this.Rotation;
      double? nullable2 = this.Rotation_DefaultValue;
      if ((rotation.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (rotation.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "rotation", (object) this.Rotation);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      nullable1 = this.UseHTML;
      bool? htmlDefaultValue = this.UseHTML_DefaultValue;
      if ((nullable1.GetValueOrDefault() == htmlDefaultValue.GetValueOrDefault() ? (nullable1.HasValue != htmlDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "useHTML", (object) this.UseHTML);
      nullable2 = this.X;
      double? nullable3 = this.X_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "x", (object) this.X);
      nullable3 = this.Y;
      nullable2 = this.Y_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "y", (object) this.Y);
      nullable2 = this.ZIndex;
      nullable3 = this.ZIndex_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "zIndex", (object) this.ZIndex);
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
