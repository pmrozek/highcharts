
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsColumnrangeMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsColumnrangeMarkerStates : BaseObject
  {
    public PlotOptionsColumnrangeMarkerStatesHover Hover { get; set; }

    private PlotOptionsColumnrangeMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsColumnrangeMarkerStatesSelect Select { get; set; }

    private PlotOptionsColumnrangeMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsColumnrangeMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsColumnrangeMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsColumnrangeMarkerStatesSelect();
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
