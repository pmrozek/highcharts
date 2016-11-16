﻿
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreaPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsAreaPoint : BaseObject
  {
    public PlotOptionsAreaPointEvents Events { get; set; }

    private PlotOptionsAreaPointEvents Events_DefaultValue { get; set; }

    public PlotOptionsAreaPoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsAreaPointEvents();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
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
