﻿
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsAreasplineMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsAreasplineMarkerStates : BaseObject
  {
    public PlotOptionsAreasplineMarkerStatesHover Hover { get; set; }

    private PlotOptionsAreasplineMarkerStatesHover Hover_DefaultValue { get; set; }

    public PlotOptionsAreasplineMarkerStatesSelect Select { get; set; }

    private PlotOptionsAreasplineMarkerStatesSelect Select_DefaultValue { get; set; }

    public PlotOptionsAreasplineMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new PlotOptionsAreasplineMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new PlotOptionsAreasplineMarkerStatesSelect();
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
