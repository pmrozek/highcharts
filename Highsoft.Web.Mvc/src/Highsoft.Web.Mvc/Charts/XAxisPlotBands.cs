
// Type: Highsoft.Web.Mvc.Charts.XAxisPlotBands




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class XAxisPlotBands : BaseObject
  {
    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public object Events { get; set; }

    private object Events_DefaultValue { get; set; }

    public double? From { get; set; }

    private double? From_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public XAxisPlotBandsLabel Label { get; set; }

    private XAxisPlotBandsLabel Label_DefaultValue { get; set; }

    public double? To { get; set; }

    private double? To_DefaultValue { get; set; }

    public double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public XAxisPlotBands()
    {
      this.BorderColor = this.BorderColor_DefaultValue = "null";
      double? nullable1 = new double?(0.0);
      this.BorderWidth_DefaultValue = nullable1;
      this.BorderWidth = nullable1;
      this.Color = this.Color_DefaultValue = (string) null;
      this.Events = this.Events_DefaultValue = (object) null;
      double? nullable2 = new double?();
      this.From_DefaultValue = nullable2;
      this.From = nullable2;
      this.Id = this.Id_DefaultValue = (string) null;
      this.Label = this.Label_DefaultValue = new XAxisPlotBandsLabel();
      double? nullable3 = new double?();
      this.To_DefaultValue = nullable3;
      this.To = nullable3;
      double? nullable4 = new double?();
      this.ZIndex_DefaultValue = nullable4;
      this.ZIndex = nullable4;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      double? borderWidth = this.BorderWidth;
      double? nullable1 = this.BorderWidth_DefaultValue;
      if ((borderWidth.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (borderWidth.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.Events != this.Events_DefaultValue)
        hashtable.Add((object) "events", this.Events);
      nullable1 = this.From;
      double? nullable2 = this.From_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "from", (object) this.From);
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      if (this.Label.IsDirty())
        hashtable.Add((object) "label", (object) this.Label.ToHashtable());
      nullable2 = this.To;
      nullable1 = this.To_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "to", (object) this.To);
      nullable1 = this.ZIndex;
      nullable2 = this.ZIndex_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "zIndex", (object) this.ZIndex);
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
