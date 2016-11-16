
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsFunnelPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsFunnelPoint : BaseObject
  {
    public PlotOptionsFunnelPointEvents Events { get; set; }

    private PlotOptionsFunnelPointEvents Events_DefaultValue { get; set; }

    public PlotOptionsFunnelPoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsFunnelPointEvents();
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
