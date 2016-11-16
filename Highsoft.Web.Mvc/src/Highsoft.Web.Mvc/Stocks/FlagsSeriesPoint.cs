
// Type: Highsoft.Web.Mvc.Stocks.FlagsSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class FlagsSeriesPoint : BaseObject
  {
    public FlagsSeriesPointEvents Events { get; set; }

    private FlagsSeriesPointEvents Events_DefaultValue { get; set; }

    public FlagsSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new FlagsSeriesPointEvents();
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
