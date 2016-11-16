
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsOhlcStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsOhlcStates : BaseObject
  {
    public PlotOptionsOhlcStatesHover Hover { get; set; }

    private PlotOptionsOhlcStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsOhlcStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsOhlcStatesHover();
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
