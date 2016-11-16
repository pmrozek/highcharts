﻿
// Type: Highsoft.Web.Mvc.Stocks.ScatterSeriesZones




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class ScatterSeriesZones : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public string DashStyle { get; set; }

    private string DashStyle_DefaultValue { get; set; }

    public string FillColor { get; set; }

    private string FillColor_DefaultValue { get; set; }

    public double? Value { get; set; }

    private double? Value_DefaultValue { get; set; }

    public ScatterSeriesZones()
    {
      this.Color = this.Color_DefaultValue = (string) null;
      this.DashStyle = this.DashStyle_DefaultValue = (string) null;
      this.FillColor = this.FillColor_DefaultValue = (string) null;
      double? nullable = new double?();
      this.Value_DefaultValue = nullable;
      this.Value = nullable;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.DashStyle != this.DashStyle_DefaultValue)
        hashtable.Add((object) "dashStyle", (object) this.DashStyle);
      if (this.FillColor != this.FillColor_DefaultValue)
        hashtable.Add((object) "fillColor", (object) this.FillColor);
      double? nullable = this.Value;
      double? valueDefaultValue = this.Value_DefaultValue;
      if ((nullable.GetValueOrDefault() == valueDefaultValue.GetValueOrDefault() ? (nullable.HasValue != valueDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "value", (object) this.Value);
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