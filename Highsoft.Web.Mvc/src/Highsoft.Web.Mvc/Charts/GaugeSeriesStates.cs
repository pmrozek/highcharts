
// Type: Highsoft.Web.Mvc.Charts.GaugeSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class GaugeSeriesStates : BaseObject
  {
    public GaugeSeriesStatesHover Hover { get; set; }

    private GaugeSeriesStatesHover Hover_DefaultValue { get; set; }

    public GaugeSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new GaugeSeriesStatesHover();
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
