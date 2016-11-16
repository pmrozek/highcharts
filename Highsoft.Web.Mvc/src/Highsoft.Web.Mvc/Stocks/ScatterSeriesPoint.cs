
// Type: Highsoft.Web.Mvc.Stocks.ScatterSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class ScatterSeriesPoint : BaseObject
  {
    public ScatterSeriesPointEvents Events { get; set; }

    private ScatterSeriesPointEvents Events_DefaultValue { get; set; }

    public ScatterSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new ScatterSeriesPointEvents();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
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
