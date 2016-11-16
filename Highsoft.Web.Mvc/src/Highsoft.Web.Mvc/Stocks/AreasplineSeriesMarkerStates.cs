
// Type: Highsoft.Web.Mvc.Stocks.AreasplineSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class AreasplineSeriesMarkerStates : BaseObject
  {
    public AreasplineSeriesMarkerStatesHover Hover { get; set; }

    private AreasplineSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public AreasplineSeriesMarkerStatesSelect Select { get; set; }

    private AreasplineSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public AreasplineSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new AreasplineSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new AreasplineSeriesMarkerStatesSelect();
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
