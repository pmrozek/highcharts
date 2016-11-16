
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBarPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsBarPoint : BaseObject
  {
    public PlotOptionsBarPointEvents Events { get; set; }

    private PlotOptionsBarPointEvents Events_DefaultValue { get; set; }

    public PlotOptionsBarPoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsBarPointEvents();
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
