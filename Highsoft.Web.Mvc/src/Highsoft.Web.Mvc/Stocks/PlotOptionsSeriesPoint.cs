﻿
// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsSeriesPoint




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PlotOptionsSeriesPoint : BaseObject
  {
    public PlotOptionsSeriesPointEvents Events { get; set; }

    private PlotOptionsSeriesPointEvents Events_DefaultValue { get; set; }

    public PlotOptionsSeriesPoint()
    {
      this.Events = this.Events_DefaultValue = new PlotOptionsSeriesPointEvents();
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
