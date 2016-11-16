
// Type: Highsoft.Web.Mvc.Charts.Drilldown




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class Drilldown : BaseObject
  {
    public Hashtable ActiveAxisLabelStyle { get; set; }

    private Hashtable ActiveAxisLabelStyle_DefaultValue { get; set; }

    public Hashtable ActiveDataLabelStyle { get; set; }

    private Hashtable ActiveDataLabelStyle_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public DrilldownDrillUpButton DrillUpButton { get; set; }

    private DrilldownDrillUpButton DrillUpButton_DefaultValue { get; set; }

    public List<Highsoft.Web.Mvc.Charts.Series> Series { get; set; }

    private List<Highsoft.Web.Mvc.Charts.Series> Series_DefaultValue { get; set; }

    public Drilldown()
    {
      this.ActiveAxisLabelStyle = this.ActiveAxisLabelStyle_DefaultValue = (Hashtable) null;
      this.ActiveDataLabelStyle = this.ActiveDataLabelStyle_DefaultValue = (Hashtable) null;
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      this.DrillUpButton = this.DrillUpButton_DefaultValue = new DrilldownDrillUpButton();
      this.Series = this.Series_DefaultValue = (List<Highsoft.Web.Mvc.Charts.Series>) null;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.ActiveAxisLabelStyle != this.ActiveAxisLabelStyle_DefaultValue)
        hashtable.Add((object) "activeAxisLabelStyle", (object) this.ActiveAxisLabelStyle);
      if (this.ActiveDataLabelStyle != this.ActiveDataLabelStyle_DefaultValue)
        hashtable.Add((object) "activeDataLabelStyle", (object) this.ActiveDataLabelStyle);
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      if (this.DrillUpButton.IsDirty())
        hashtable.Add((object) "drillUpButton", (object) this.DrillUpButton.ToHashtable());
      if (this.Series != this.Series_DefaultValue)
        hashtable.Add((object) "series", (object) this.Series);
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
