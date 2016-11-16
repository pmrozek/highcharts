
// Type: Highsoft.Web.Mvc.Charts.HeatmapSeriesStatesHoverMarker




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class HeatmapSeriesStatesHoverMarker : BaseObject
  {
    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public string FillColor { get; set; }

    private string FillColor_DefaultValue { get; set; }

    public double? Height { get; set; }

    private double? Height_DefaultValue { get; set; }

    public string LineColor { get; set; }

    private string LineColor_DefaultValue { get; set; }

    public double? LineWidth { get; set; }

    private double? LineWidth_DefaultValue { get; set; }

    public double? Radius { get; set; }

    private double? Radius_DefaultValue { get; set; }

    public string Symbol { get; set; }

    private string Symbol_DefaultValue { get; set; }

    public double? Width { get; set; }

    private double? Width_DefaultValue { get; set; }

    public HeatmapSeriesStatesHoverMarker()
    {
      bool? nullable1 = new bool?(true);
      this.Enabled_DefaultValue = nullable1;
      this.Enabled = nullable1;
      this.FillColor = this.FillColor_DefaultValue = (string) null;
      double? nullable2 = new double?();
      this.Height_DefaultValue = nullable2;
      this.Height = nullable2;
      this.LineColor = this.LineColor_DefaultValue = "#FFFFFF";
      nullable2 = new double?(0.0);
      this.LineWidth_DefaultValue = nullable2;
      this.LineWidth = nullable2;
      nullable2 = new double?(4.0);
      this.Radius_DefaultValue = nullable2;
      this.Radius = nullable2;
      this.Symbol = this.Symbol_DefaultValue = (string) null;
      double? nullable3 = new double?();
      this.Width_DefaultValue = nullable3;
      this.Width = nullable3;
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
      double? height = this.Height;
      double? nullable1 = this.Height_DefaultValue;
      if ((height.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (height.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "height", (object) this.Height);
      if (this.LineColor != this.LineColor_DefaultValue)
        hashtable.Add((object) "lineColor", (object) this.LineColor);
      nullable1 = this.LineWidth;
      double? nullable2 = this.LineWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "lineWidth", (object) this.LineWidth);
      nullable2 = this.Radius;
      nullable1 = this.Radius_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "radius", (object) this.Radius);
      if (this.Symbol != this.Symbol_DefaultValue)
        hashtable.Add((object) "symbol", (object) this.Symbol);
      nullable1 = this.Width;
      nullable2 = this.Width_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "width", (object) this.Width);
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
