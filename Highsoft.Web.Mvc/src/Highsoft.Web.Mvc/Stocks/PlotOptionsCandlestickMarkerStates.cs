
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsCandlestickMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsCandlestickMarkerStates : BaseObject
  {
    public PlotOptionsCandlestickMarkerStatesHover Hover { get; set; }

    private PlotOptionsCandlestickMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsCandlestickMarkerStatesSelect Select { get; set; }

    private PlotOptionsCandlestickMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsCandlestickMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsCandlestickMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsCandlestickMarkerStatesSelect();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Hover.IsDirty())
        hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
      if (this.Select.IsDirty())
        hashtable.Add((object) "select", (object) this.Select.ToHashtable());
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
