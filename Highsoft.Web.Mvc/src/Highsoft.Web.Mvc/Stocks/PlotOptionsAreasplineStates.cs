
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreasplineStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsAreasplineStates : BaseObject
  {
    public PlotOptionsAreasplineStatesHover Hover { get; set; }

    private PlotOptionsAreasplineStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsAreasplineStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsAreasplineStatesHover();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Hover.IsDirty())
        hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
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
