
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsPyramidPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsPyramidPoint : BaseObject
  {
    public PlotOptionsPyramidPointEvents Events { get; set; }

    private PlotOptionsPyramidPointEvents Events_DefaultValue { get; set; }

    public PlotOptionsPyramidPoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsPyramidPointEvents();
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
