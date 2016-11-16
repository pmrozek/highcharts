
// Type: Highsoft.Web.Mvc.Charts.Pane




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class Pane : BaseObject
  {
    public List<Highsoft.Web.Mvc.Charts.Background> Background { get; set; }

    private List<Highsoft.Web.Mvc.Charts.Background> Background_DefaultValue { get; set; }

    public string[] Center { get; set; }

    private string[] Center_DefaultValue { get; set; }

    public double? EndAngle { get; set; }

    private double? EndAngle_DefaultValue { get; set; }

    public string Size { get; set; }

    private string Size_DefaultValue { get; set; }

    public double? StartAngle { get; set; }

    private double? StartAngle_DefaultValue { get; set; }

    public Pane()
    {
      this.Background = this.Background_DefaultValue = (List<Highsoft.Web.Mvc.Charts.Background>) null;
      this.Center = this.Center_DefaultValue = new string[2];
      double? nullable1 = new double?();
      this.EndAngle_DefaultValue = nullable1;
      this.EndAngle = nullable1;
      this.Size = this.Size_DefaultValue = "85%";
      double? nullable2 = new double?();
      this.StartAngle_DefaultValue = nullable2;
      this.StartAngle = nullable2;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Background != this.Background_DefaultValue)
        hashtable.Add((object) "background", (object) this.HashifyList((IEnumerable) this.Background));
      if (this.Center != this.Center_DefaultValue)
        hashtable.Add((object) "center", (object) this.Center);
      double? nullable1 = this.EndAngle;
      double? nullable2 = this.EndAngle_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "endAngle", (object) this.EndAngle);
      if (this.Size != this.Size_DefaultValue)
        hashtable.Add((object) "size", (object) this.Size);
      nullable2 = this.StartAngle;
      nullable1 = this.StartAngle_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "startAngle", (object) this.StartAngle);
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
