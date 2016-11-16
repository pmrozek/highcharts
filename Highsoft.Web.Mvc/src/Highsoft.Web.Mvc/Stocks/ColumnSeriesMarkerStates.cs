
// Type: Highsoft.Web.Mvc.Stocks.ColumnSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class ColumnSeriesMarkerStates : BaseObject
  {
    public ColumnSeriesMarkerStatesHover Hover { get; set; }

    private ColumnSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public ColumnSeriesMarkerStatesSelect Select { get; set; }

    private ColumnSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public ColumnSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new ColumnSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new ColumnSeriesMarkerStatesSelect();
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
