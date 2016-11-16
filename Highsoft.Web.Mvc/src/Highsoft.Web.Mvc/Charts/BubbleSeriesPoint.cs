
// Type: Highsoft.Web.Mvc.Charts.BubbleSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class BubbleSeriesPoint : BaseObject
  {
    public BubbleSeriesPointEvents Events { get; set; }

    private BubbleSeriesPointEvents Events_DefaultValue { get; set; }

    public BubbleSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new BubbleSeriesPointEvents();
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
