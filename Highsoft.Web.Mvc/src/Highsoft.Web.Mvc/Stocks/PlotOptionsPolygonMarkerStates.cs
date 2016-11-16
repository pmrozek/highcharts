
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsPolygonMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsPolygonMarkerStates : BaseObject
  {
    public PlotOptionsPolygonMarkerStatesHover Hover { get; set; }

    private PlotOptionsPolygonMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsPolygonMarkerStatesSelect Select { get; set; }

    private PlotOptionsPolygonMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsPolygonMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsPolygonMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsPolygonMarkerStatesSelect();
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
