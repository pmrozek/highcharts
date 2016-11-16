﻿
// Type: Highsoft.Web.Mvc.Stocks.OhlcSeriesData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class OhlcSeriesData : BaseObject
  {
    public double? Close { get; set; }

    private double? Close_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public object DataLabels { get; set; }

    private object DataLabels_DefaultValue { get; set; }

    public OhlcSeriesDataEvents Events { get; set; }

    private OhlcSeriesDataEvents Events_DefaultValue { get; set; }

    public double? High { get; set; }

    private double? High_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public double? Low { get; set; }

    private double? Low_DefaultValue { get; set; }

    public string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public double? Open { get; set; }

    private double? Open_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public double? X { get; set; }

    private double? X_DefaultValue { get; set; }

    public OhlcSeriesData()
    {
      double? nullable1 = new double?();
      this.Close_DefaultValue = nullable1;
      this.Close = nullable1;
      this.Color = this.Color_DefaultValue = "undefined";
      this.DataLabels = this.DataLabels_DefaultValue = (object) null;
      this.Events = this.Events_DefaultValue = new OhlcSeriesDataEvents();
      double? nullable2 = new double?();
      this.High_DefaultValue = nullable2;
      this.High = nullable2;
      this.Id = this.Id_DefaultValue = "null";
      double? nullable3 = new double?();
      this.Low_DefaultValue = nullable3;
      this.Low = nullable3;
      this.Name = this.Name_DefaultValue = (string) null;
      double? nullable4 = new double?();
      this.Open_DefaultValue = nullable4;
      this.Open = nullable4;
      bool? nullable5 = new bool?(false);
      this.Selected_DefaultValue = nullable5;
      this.Selected = nullable5;
      nullable4 = new double?(double.MinValue);
      this.X_DefaultValue = nullable4;
      this.X = nullable4;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      double? close = this.Close;
      double? closeDefaultValue = this.Close_DefaultValue;
      if ((close.GetValueOrDefault() == closeDefaultValue.GetValueOrDefault() ? (close.HasValue != closeDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "close", (object) this.Close);
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.DataLabels != this.DataLabels_DefaultValue)
        hashtable.Add((object) "dataLabels", this.DataLabels);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      double? high = this.High;
      double? nullable1 = this.High_DefaultValue;
      if ((high.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (high.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "high", (object) this.High);
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      nullable1 = this.Low;
      double? nullable2 = this.Low_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "low", (object) this.Low);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      nullable2 = this.Open;
      nullable1 = this.Open_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "open", (object) this.Open);
      bool? selected = this.Selected;
      bool? selectedDefaultValue = this.Selected_DefaultValue;
      if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? (selected.HasValue != selectedDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      nullable1 = this.X;
      nullable2 = this.X_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "x", (object) this.X);
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
