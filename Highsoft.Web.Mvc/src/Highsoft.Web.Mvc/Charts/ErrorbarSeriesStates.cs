
// Type: Highsoft.Web.Mvc.Charts.ErrorbarSeriesStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class ErrorbarSeriesStates : BaseObject
  {
    public ErrorbarSeriesStatesHover Hover { get; set; }

    private ErrorbarSeriesStatesHover Hover_DefaultValue { get; set; }

    public ErrorbarSeriesStates()
    {
      this.Hover = this.Hover_DefaultValue = new ErrorbarSeriesStatesHover();
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
