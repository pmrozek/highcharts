
// Type: Highsoft.Web.Mvc.Charts.WaterfallSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class WaterfallSeriesPoint : BaseObject
  {
    public WaterfallSeriesPointEvents Events { get; set; }

    private WaterfallSeriesPointEvents Events_DefaultValue { get; set; }

    public WaterfallSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new WaterfallSeriesPointEvents();
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
