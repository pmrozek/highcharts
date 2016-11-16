
// Type: Highsoft.Web.Mvc.Charts.PyramidSeriesData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class PyramidSeriesData : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public object DataLabels { get; set; }

    private object DataLabels_DefaultValue { get; set; }

    public string Drilldown { get; set; }

    private string Drilldown_DefaultValue { get; set; }

    public PyramidSeriesDataEvents Events { get; set; }

    private PyramidSeriesDataEvents Events_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public double? LegendIndex { get; set; }

    private double? LegendIndex_DefaultValue { get; set; }

    public string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public PyramidSeriesData()
    {
      this.Color = this.Color_DefaultValue = "undefined";
      this.DataLabels = this.DataLabels_DefaultValue = (object) null;
      this.Drilldown = this.Drilldown_DefaultValue = "";
      this.Events = this.Events_DefaultValue = new PyramidSeriesDataEvents();
      this.Id = this.Id_DefaultValue = (string) null;
      double? nullable1 = new double?();
      this.LegendIndex_DefaultValue = nullable1;
      this.LegendIndex = nullable1;
      this.Name = this.Name_DefaultValue = (string) null;
      bool? nullable2 = new bool?(false);
      this.Selected_DefaultValue = nullable2;
      this.Selected = nullable2;
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
      double? nullable = this.LegendIndex_DefaultValue;
      if ((legendIndex.GetValueOrDefault() == nullable.GetValueOrDefault() ? (legendIndex.HasValue != nullable.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      bool? selected = this.Selected;
      bool? selectedDefaultValue = this.Selected_DefaultValue;
      if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? (selected.HasValue != selectedDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      nullable = this.Y;
      double? yDefaultValue = this.Y_DefaultValue;
      if ((nullable.GetValueOrDefault() == yDefaultValue.GetValueOrDefault() ? (nullable.HasValue != yDefaultValue.HasValue ? 1 : 0) : 1) != 0)
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
