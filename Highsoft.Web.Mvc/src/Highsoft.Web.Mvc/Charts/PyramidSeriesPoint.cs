
// Type: Highsoft.Web.Mvc.Charts.PyramidSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PyramidSeriesPoint : BaseObject
  {
    public PyramidSeriesPointEvents Events { get; set; }

    private PyramidSeriesPointEvents Events_DefaultValue { get; set; }

    public PyramidSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new PyramidSeriesPointEvents();
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
