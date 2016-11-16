﻿
// Type: Highsoft.Web.Mvc.Stocks.AreasplineSeriesDataMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class AreasplineSeriesDataMarkerStates : BaseObject
  {
    public AreasplineSeriesDataMarkerStatesHover Hover { get; set; }

    private AreasplineSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

    public AreasplineSeriesDataMarkerStatesSelect Select { get; set; }

    private AreasplineSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

    public AreasplineSeriesDataMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new AreasplineSeriesDataMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new AreasplineSeriesDataMarkerStatesSelect();
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
