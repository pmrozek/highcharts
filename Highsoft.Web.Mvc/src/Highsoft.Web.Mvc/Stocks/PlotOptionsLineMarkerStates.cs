
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsLineMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsLineMarkerStates : BaseObject
  {
    public PlotOptionsLineMarkerStatesHover Hover { get; set; }

    private PlotOptionsLineMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsLineMarkerStatesSelect Select { get; set; }

    private PlotOptionsLineMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsLineMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsLineMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsLineMarkerStatesSelect();
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
