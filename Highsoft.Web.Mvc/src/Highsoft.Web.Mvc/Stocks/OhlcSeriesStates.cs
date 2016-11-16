
// Type: Highsoft.Web.Mvc.Stocks.OhlcSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class OhlcSeriesStates : BaseObject
  {
    public OhlcSeriesStatesHover Hover { get; set; }

    private OhlcSeriesStatesHover Hover_DefaultValue { get; set; }

    public OhlcSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new OhlcSeriesStatesHover();
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
