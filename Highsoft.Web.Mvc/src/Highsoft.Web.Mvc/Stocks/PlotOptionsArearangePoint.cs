
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsArearangePoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsArearangePoint : BaseObject
  {
    public PlotOptionsArearangePointEvents Events { get; set; }

    private PlotOptionsArearangePointEvents Events_DefaultValue { get; set; }

    public PlotOptionsArearangePoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsArearangePointEvents();
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
