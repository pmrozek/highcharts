
// Type: Highsoft.Web.Mvc.Stocks.FlagsSeriesTooltip




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class FlagsSeriesTooltip : BaseObject
  {
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

    public string XDateFormat { get; set; }

    private string XDateFormat_DefaultValue { get; set; }

    public FlagsSeriesTooltip()
    {
      this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
      bool? nullable = new bool?(false);
      this.FollowPointer_DefaultValue = nullable;
      this.FollowPointer = nullable;
      nullable = new bool?(true);
      this.FollowTouchMove_DefaultValue = nullable;
      this.FollowTouchMove = nullable;
      this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
      this.PointFormat = this.PointFormat_DefaultValue = "<span style='color:{point.color}'>●\x008F</span> {series.name}: <b>{point.y}</b><br/>";
      this.PointFormatter = this.PointFormatter_DefaultValue = "";
      this.Shape = this.Shape_DefaultValue = "callout";
      this.XDateFormat = this.XDateFormat_DefaultValue = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
        hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
      bool? nullable1 = this.FollowPointer;
      bool? nullable2 = this.FollowPointer_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "followPointer", (object) this.FollowPointer);
      nullable2 = this.FollowTouchMove;
      nullable1 = this.FollowTouchMove_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
      if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
        hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
      if (this.PointFormat != this.PointFormat_DefaultValue)
        hashtable.Add((object) "pointFormat", (object) this.PointFormat);
      if (this.PointFormatter != this.PointFormatter_DefaultValue)
      {
        hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
        Highstock.AddFunction("FlagsSeriesTooltipPointFormatter.pointFormatter", this.PointFormatter);
      }
      if (this.Shape != this.Shape_DefaultValue)
        hashtable.Add((object) "shape", (object) this.Shape);
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
