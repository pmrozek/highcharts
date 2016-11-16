
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBubbleMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsBubbleMarkerStates : BaseObject
  {
    public PlotOptionsBubbleMarkerStatesHover Hover { get; set; }

    private PlotOptionsBubbleMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsBubbleMarkerStatesSelect Select { get; set; }

    private PlotOptionsBubbleMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsBubbleMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsBubbleMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsBubbleMarkerStatesSelect();
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
