
// Type: Highsoft.Web.Mvc.Stocks.PolygonSeriesDataMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PolygonSeriesDataMarkerStates : BaseObject
  {
    public PolygonSeriesDataMarkerStatesHover Hover { get; set; }

    private PolygonSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

    public PolygonSeriesDataMarkerStatesSelect Select { get; set; }

    private PolygonSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

    public PolygonSeriesDataMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PolygonSeriesDataMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PolygonSeriesDataMarkerStatesSelect();
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
