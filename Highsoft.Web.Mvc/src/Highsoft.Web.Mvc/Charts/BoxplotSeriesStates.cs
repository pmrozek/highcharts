
// Type: Highsoft.Web.Mvc.Charts.BoxplotSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class BoxplotSeriesStates : BaseObject
  {
    public BoxplotSeriesStatesHover Hover { get; set; }

    private BoxplotSeriesStatesHover Hover_DefaultValue { get; set; }

    public BoxplotSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new BoxplotSeriesStatesHover();
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
