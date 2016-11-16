
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsAreasplinerangePointEvents




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsAreasplinerangePointEvents : BaseObject
  {
    public string Click { get; set; }

    private string Click_DefaultValue { get; set; }

    public string MouseOut { get; set; }

    private string MouseOut_DefaultValue { get; set; }

    public string MouseOver { get; set; }

    private string MouseOver_DefaultValue { get; set; }

    public string Remove { get; set; }

    private string Remove_DefaultValue { get; set; }

    public string Select { get; set; }

    private string Select_DefaultValue { get; set; }

    public string Unselect { get; set; }

    private string Unselect_DefaultValue { get; set; }

    public string Update { get; set; }

    private string Update_DefaultValue { get; set; }

    public PlotOptionsAreasplinerangePointEvents()
    {
      this.Click = this.Click_DefaultValue = "";
      this.MouseOut = this.MouseOut_DefaultValue = "";
      this.MouseOver = this.MouseOver_DefaultValue = "";
      this.Remove = this.Remove_DefaultValue = "";
      this.Select = this.Select_DefaultValue = "";
      this.Unselect = this.Unselect_DefaultValue = "";
      this.Update = this.Update_DefaultValue = "";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Click != this.Click_DefaultValue)
      {
        hashtable.Add((object) "click", (object) this.Click);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsClick.click", this.Click);
      }
      if (this.MouseOut != this.MouseOut_DefaultValue)
      {
        hashtable.Add((object) "mouseOut", (object) this.MouseOut);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsMouseOut.mouseOut", this.MouseOut);
      }
      if (this.MouseOver != this.MouseOver_DefaultValue)
      {
        hashtable.Add((object) "mouseOver", (object) this.MouseOver);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsMouseOver.mouseOver", this.MouseOver);
      }
      if (this.Remove != this.Remove_DefaultValue)
      {
        hashtable.Add((object) "remove", (object) this.Remove);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsRemove.remove", this.Remove);
      }
      if (this.Select != this.Select_DefaultValue)
      {
        hashtable.Add((object) "select", (object) this.Select);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsSelect.select", this.Select);
      }
      if (this.Unselect != this.Unselect_DefaultValue)
      {
        hashtable.Add((object) "unselect", (object) this.Unselect);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsUnselect.unselect", this.Unselect);
      }
      if (this.Update != this.Update_DefaultValue)
      {
        hashtable.Add((object) "update", (object) this.Update);
        Highcharts.AddFunction("PlotOptionsAreasplinerangePointEventsUpdate.update", this.Update);
      }
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
