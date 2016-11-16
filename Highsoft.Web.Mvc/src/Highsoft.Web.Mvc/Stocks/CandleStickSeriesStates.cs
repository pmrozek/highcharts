
// Type: Highsoft.Web.Mvc.Stocks.CandleStickSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class CandleStickSeriesStates : BaseObject
  {
    public CandleStickSeriesStatesHover Hover { get; set; }

    private CandleStickSeriesStatesHover Hover_DefaultValue { get; set; }

    public CandleStickSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new CandleStickSeriesStatesHover();
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
