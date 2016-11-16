
// Type: Highsoft.Web.Mvc.Charts.TreemapSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class TreemapSeriesStates : BaseObject
  {
    public TreemapSeriesStatesHover Hover { get; set; }

    private TreemapSeriesStatesHover Hover_DefaultValue { get; set; }

    public TreemapSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new TreemapSeriesStatesHover();
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
