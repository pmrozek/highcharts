
// Type: Highsoft.Web.Mvc.Charts.YAxisEvents




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class YAxisEvents : BaseObject
  {
    public string AfterBreaks { get; set; }

    private string AfterBreaks_DefaultValue { get; set; }

    public string AfterSetExtremes { get; set; }

    private string AfterSetExtremes_DefaultValue { get; set; }

    public string PointBreak { get; set; }

    private string PointBreak_DefaultValue { get; set; }

    public string SetExtremes { get; set; }

    private string SetExtremes_DefaultValue { get; set; }

    public YAxisEvents()
    {
      this.AfterBreaks = this.AfterBreaks_DefaultValue = "";
      this.AfterSetExtremes = this.AfterSetExtremes_DefaultValue = "";
      this.PointBreak = this.PointBreak_DefaultValue = "";
      this.SetExtremes = this.SetExtremes_DefaultValue = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.AfterBreaks != this.AfterBreaks_DefaultValue)
      {
        hashtable.Add((object) "afterBreaks", (object) this.AfterBreaks);
        Highcharts.AddFunction("YAxisEventsAfterBreaks.afterBreaks", this.AfterBreaks);
      }
      if (this.AfterSetExtremes != this.AfterSetExtremes_DefaultValue)
      {
        hashtable.Add((object) "afterSetExtremes", (object) this.AfterSetExtremes);
        Highcharts.AddFunction("YAxisEventsAfterSetExtremes.afterSetExtremes", this.AfterSetExtremes);
      }
      if (this.PointBreak != this.PointBreak_DefaultValue)
      {
        hashtable.Add((object) "pointBreak", (object) this.PointBreak);
        Highcharts.AddFunction("YAxisEventsPointBreak.pointBreak", this.PointBreak);
      }
      if (this.SetExtremes != this.SetExtremes_DefaultValue)
      {
        hashtable.Add((object) "setExtremes", (object) this.SetExtremes);
        Highcharts.AddFunction("YAxisEventsSetExtremes.setExtremes", this.SetExtremes);
      }
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
