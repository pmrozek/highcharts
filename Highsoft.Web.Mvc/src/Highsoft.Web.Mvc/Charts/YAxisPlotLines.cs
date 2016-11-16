
// Type: Highsoft.Web.Mvc.Charts.YAxisPlotLines




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class YAxisPlotLines : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public YAxisPlotLinesDashStyle DashStyle { get; set; }

    private YAxisPlotLinesDashStyle DashStyle_DefaultValue { get; set; }

    public object Events { get; set; }

    private object Events_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public YAxisPlotLinesLabel Label { get; set; }

    private YAxisPlotLinesLabel Label_DefaultValue { get; set; }

    public double? Value { get; set; }

    private double? Value_DefaultValue { get; set; }

    public double? Width { get; set; }

    private double? Width_DefaultValue { get; set; }

    public double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public YAxisPlotLines()
    {
      this.Color = this.Color_DefaultValue = (string) null;
      this.DashStyle = this.DashStyle_DefaultValue = YAxisPlotLinesDashStyle.Solid;
      this.Events = this.Events_DefaultValue = (object) null;
      this.Id = this.Id_DefaultValue = (string) null;
      this.Label = this.Label_DefaultValue = new YAxisPlotLinesLabel();
      double? nullable1 = new double?();
      this.Value_DefaultValue = nullable1;
      this.Value = nullable1;
      double? nullable2 = new double?();
      this.Width_DefaultValue = nullable2;
      this.Width = nullable2;
      double? nullable3 = new double?();
      this.ZIndex_DefaultValue = nullable3;
      this.ZIndex = nullable3;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.DashStyle != this.DashStyle_DefaultValue)
        hashtable.Add((object) "dashStyle", (object) Highcharts.FirstCharacterToLower(this.DashStyle.ToString()));
      if (this.Events != this.Events_DefaultValue)
        hashtable.Add((object) "events", this.Events);
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      if (this.Label.IsDirty())
        hashtable.Add((object) "label", (object) this.Label.ToHashtable());
      double? nullable1 = this.Value;
      double? nullable2 = this.Value_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "value", (object) this.Value);
      nullable2 = this.Width;
      double? nullable3 = this.Width_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "width", (object) this.Width);
      nullable3 = this.ZIndex;
      nullable2 = this.ZIndex_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
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
