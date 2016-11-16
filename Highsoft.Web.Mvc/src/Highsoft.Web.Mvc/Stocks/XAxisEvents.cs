
// Type: Highsoft.Web.Mvc.Stocks.XAxisEvents




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class XAxisEvents : BaseObject
  {
    public string AfterSetExtremes { get; set; }

    private string AfterSetExtremes_DefaultValue { get; set; }

    public string SetExtremes { get; set; }

    private string SetExtremes_DefaultValue { get; set; }

    public XAxisEvents()
    {
      this.AfterSetExtremes = this.AfterSetExtremes_DefaultValue = "";
      this.SetExtremes = this.SetExtremes_DefaultValue = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.AfterSetExtremes != this.AfterSetExtremes_DefaultValue)
      {
        hashtable.Add((object) "afterSetExtremes", (object) this.AfterSetExtremes);
        Highstock.AddFunction("XAxisEventsAfterSetExtremes.afterSetExtremes", this.AfterSetExtremes);
      }
      if (this.SetExtremes != this.SetExtremes_DefaultValue)
      {
        hashtable.Add((object) "setExtremes", (object) this.SetExtremes);
        Highstock.AddFunction("XAxisEventsSetExtremes.setExtremes", this.SetExtremes);
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
