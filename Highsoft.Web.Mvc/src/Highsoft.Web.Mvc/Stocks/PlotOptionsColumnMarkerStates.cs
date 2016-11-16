
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsColumnMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsColumnMarkerStates : BaseObject
  {
    public PlotOptionsColumnMarkerStatesHover Hover { get; set; }

    private PlotOptionsColumnMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsColumnMarkerStatesSelect Select { get; set; }

    private PlotOptionsColumnMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsColumnMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsColumnMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsColumnMarkerStatesSelect();
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
