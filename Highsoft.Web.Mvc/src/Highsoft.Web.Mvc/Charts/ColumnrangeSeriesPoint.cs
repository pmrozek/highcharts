
// Type: Highsoft.Web.Mvc.Charts.ColumnrangeSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class ColumnrangeSeriesPoint : BaseObject
  {
    public ColumnrangeSeriesPointEvents Events { get; set; }

    private ColumnrangeSeriesPointEvents Events_DefaultValue { get; set; }

    public ColumnrangeSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new ColumnrangeSeriesPointEvents();
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
