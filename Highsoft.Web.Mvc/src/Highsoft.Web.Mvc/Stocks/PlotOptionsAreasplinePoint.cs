
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreasplinePoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsAreasplinePoint : BaseObject
  {
    public PlotOptionsAreasplinePointEvents Events { get; set; }

    private PlotOptionsAreasplinePointEvents Events_DefaultValue { get; set; }

    public PlotOptionsAreasplinePoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsAreasplinePointEvents();
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
