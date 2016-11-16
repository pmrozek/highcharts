
// Type: Highsoft.Web.Mvc.Stocks.XAxisBreaks




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class XAxisBreaks : BaseObject
  {
    public double? BreakSize { get; set; }

    private double? BreakSize_DefaultValue { get; set; }

    public double? From { get; set; }

    private double? From_DefaultValue { get; set; }

    public double? Repeat { get; set; }

    private double? Repeat_DefaultValue { get; set; }

    public double? To { get; set; }

    private double? To_DefaultValue { get; set; }

    public XAxisBreaks()
    {
      double? nullable1 = new double?(0.0);
      this.BreakSize_DefaultValue = nullable1;
      this.BreakSize = nullable1;
      double? nullable2 = new double?();
      this.From_DefaultValue = nullable2;
      this.From = nullable2;
      nullable2 = new double?(0.0);
      this.Repeat_DefaultValue = nullable2;
      this.Repeat = nullable2;
      double? nullable3 = new double?();
      this.To_DefaultValue = nullable3;
      this.To = nullable3;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      double? breakSize = this.BreakSize;
      double? sizeDefaultValue = this.BreakSize_DefaultValue;
      if ((breakSize.GetValueOrDefault() == sizeDefaultValue.GetValueOrDefault() ? (breakSize.HasValue != sizeDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "breakSize", (object) this.BreakSize);
      double? from = this.From;
      double? nullable1 = this.From_DefaultValue;
      if ((from.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (from.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "from", (object) this.From);
      nullable1 = this.Repeat;
      double? nullable2 = this.Repeat_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "repeat", (object) this.Repeat);
      nullable2 = this.To;
      nullable1 = this.To_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "to", (object) this.To);
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
