
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsErrorbarStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsErrorbarStates : BaseObject
  {
    public PlotOptionsErrorbarStatesHover Hover { get; set; }

    private PlotOptionsErrorbarStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsErrorbarStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsErrorbarStatesHover();
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
