
// Type: Highsoft.Web.Mvc.Charts.PieSeriesData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PieSeriesData : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public object DataLabels { get; set; }

    private object DataLabels_DefaultValue { get; set; }

    public string Drilldown { get; set; }

    private string Drilldown_DefaultValue { get; set; }

    public PieSeriesDataEvents Events { get; set; }

    private PieSeriesDataEvents Events_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public bool? Sliced { get; set; }

    private bool? Sliced_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public PieSeriesData()
    {
      this.Color = this.Color_DefaultValue = "undefined";
      this.DataLabels = this.DataLabels_DefaultValue = (object) null;
      this.Drilldown = this.Drilldown_DefaultValue = "";
      this.Events = this.Events_DefaultValue = new PieSeriesDataEvents();
      this.Id = this.Id_DefaultValue = (string) null;
      double? nullable1 = new double?();
      this.LegendIndex_DefaultValue = nullable1;
      this.LegendIndex = nullable1;
      this.Name = this.Name_DefaultValue = (string) null;
      bool? nullable2 = new bool?(false);
      this.Selected_DefaultValue = nullable2;
      this.Selected = nullable2;
      nullable2 = new bool?(false);
      this.Sliced_DefaultValue = nullable2;
      this.Sliced = nullable2;
      nullable1 = new double?(double.MinValue);
      this.Y_DefaultValue = nullable1;
      this.Y = nullable1;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.DataLabels != this.DataLabels_DefaultValue)
        hashtable.Add((object) "dataLabels", this.DataLabels);
      if (this.Drilldown != this.Drilldown_DefaultValue)
        hashtable.Add((object) "drilldown", (object) this.Drilldown);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      double? legendIndex = this.LegendIndex;
      double? nullable1 = this.LegendIndex_DefaultValue;
      if ((legendIndex.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (legendIndex.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      bool? selected = this.Selected;
      bool? nullable2 = this.Selected_DefaultValue;
      if ((selected.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (selected.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      nullable2 = this.Sliced;
      bool? slicedDefaultValue = this.Sliced_DefaultValue;
      if ((nullable2.GetValueOrDefault() == slicedDefaultValue.GetValueOrDefault() ? (nullable2.HasValue != slicedDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "sliced", (object) this.Sliced);
      nullable1 = this.Y;
      double? yDefaultValue = this.Y_DefaultValue;
      if ((nullable1.GetValueOrDefault() == yDefaultValue.GetValueOrDefault() ? (nullable1.HasValue != yDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "y", (object) this.Y);
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
