
// Type: Highsoft.Web.Mvc.Stocks.PolygonSeriesMarkerStatesSelect




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class PolygonSeriesMarkerStatesSelect : BaseObject
  {
    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public string FillColor { get; set; }

    private string FillColor_DefaultValue { get; set; }

    public string LineColor { get; set; }

    private string LineColor_DefaultValue { get; set; }

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public double? Radius { get; set; }

    private double? Radius_DefaultValue { get; set; }

    public PolygonSeriesMarkerStatesSelect()
    {
      bool? nullable1 = new bool?(true);
      this.Enabled_DefaultValue = nullable1;
      this.Enabled = nullable1;
      this.FillColor = this.FillColor_DefaultValue = "null";
      this.LineColor = this.LineColor_DefaultValue = "'#000000'";
      double? nullable2 = new double?(0.0);
      this.LineWidth_DefaultValue = nullable2;
      this.LineWidth = nullable2;
      double? nullable3 = new double?();
      this.Radius_DefaultValue = nullable3;
      this.Radius = nullable3;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      bool? enabled = this.Enabled;
      bool? enabledDefaultValue = this.Enabled_DefaultValue;
      if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? (enabled.HasValue != enabledDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      if (this.FillColor != this.FillColor_DefaultValue)
        hashtable.Add((object) "fillColor", (object) this.FillColor);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      double? lineWidth = this.LineWidth;
      double? nullable = this.LineWidth_DefaultValue;
      if ((lineWidth.GetValueOrDefault() == nullable.GetValueOrDefault() ? (lineWidth.HasValue != nullable.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
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
