
// Type: Highsoft.Web.Mvc.Charts.LineSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class LineSeriesMarkerStates : BaseObject
  {
    public LineSeriesMarkerStatesHover Hover { get; set; }

    private LineSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public LineSeriesMarkerStatesSelect Select { get; set; }

    private LineSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public LineSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new LineSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new LineSeriesMarkerStatesSelect();
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
