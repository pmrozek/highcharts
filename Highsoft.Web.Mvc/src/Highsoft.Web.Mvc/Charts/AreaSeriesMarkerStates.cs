
// Type: Highsoft.Web.Mvc.Charts.AreaSeriesMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class AreaSeriesMarkerStates : BaseObject
  {
    public AreaSeriesMarkerStatesHover Hover { get; set; }

    private AreaSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

    public AreaSeriesMarkerStatesSelect Select { get; set; }

    private AreaSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

    public AreaSeriesMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new AreaSeriesMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new AreaSeriesMarkerStatesSelect();
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
