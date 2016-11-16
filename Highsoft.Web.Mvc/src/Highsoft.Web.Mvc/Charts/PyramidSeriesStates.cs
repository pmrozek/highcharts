
// Type: Highsoft.Web.Mvc.Charts.PyramidSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PyramidSeriesStates : BaseObject
  {
    public PyramidSeriesStatesHover Hover { get; set; }

    private PyramidSeriesStatesHover Hover_DefaultValue { get; set; }

    public PyramidSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new PyramidSeriesStatesHover();
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
