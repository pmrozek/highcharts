
// Type: Highsoft.Web.Mvc.Charts.BarSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class BarSeriesStates : BaseObject
  {
    public BarSeriesStatesHover Hover { get; set; }

    private BarSeriesStatesHover Hover_DefaultValue { get; set; }

    public BarSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new BarSeriesStatesHover();
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
