
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsCandlestickStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsCandlestickStates : BaseObject
  {
    public PlotOptionsCandlestickStatesHover Hover { get; set; }

    private PlotOptionsCandlestickStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsCandlestickStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsCandlestickStatesHover();
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
