
// Type: Highsoft.Web.Mvc.Charts.PlotOptionsGaugePivot




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PlotOptionsGaugePivot : BaseObject
  {
    public string BackgroundColor { get; set; }

    private string BackgroundColor_DefaultValue { get; set; }

    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public double? Radius { get; set; }

    private double? Radius_DefaultValue { get; set; }

    public PlotOptionsGaugePivot()
    {
      this.BackgroundColor = this.BackgroundColor_DefaultValue = "black";
      this.BorderColor = this.BorderColor_DefaultValue = "silver";
      double? nullable = new double?(0.0);
      this.BorderWidth_DefaultValue = nullable;
      this.BorderWidth = nullable;
      nullable = new double?(5.0);
      this.Radius_DefaultValue = nullable;
      this.Radius = nullable;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
        hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? borderWidth = this.BorderWidth;
      double? nullable = this.BorderWidth_DefaultValue;
      if ((borderWidth.GetValueOrDefault() == nullable.GetValueOrDefault() ? (borderWidth.HasValue != nullable.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      nullable = this.Radius;
      double? radiusDefaultValue = this.Radius_DefaultValue;
      if ((nullable.GetValueOrDefault() == radiusDefaultValue.GetValueOrDefault() ? (nullable.HasValue != radiusDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "radius", (object) this.Radius);
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
