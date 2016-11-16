
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBubblePoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsBubblePoint : BaseObject
  {
    public PlotOptionsBubblePointEvents Events { get; set; }

    private PlotOptionsBubblePointEvents Events_DefaultValue { get; set; }

    public PlotOptionsBubblePoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsBubblePointEvents();
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
