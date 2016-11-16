
// Type: Highsoft.Web.Mvc.Charts.TreemapSeriesData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class TreemapSeriesData : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public double? ColorValue { get; set; }

    private double? ColorValue_DefaultValue { get; set; }

    public object DataLabels { get; set; }

    private object DataLabels_DefaultValue { get; set; }

    public string Drilldown { get; set; }

    private string Drilldown_DefaultValue { get; set; }

    public TreemapSeriesDataEvents Events { get; set; }

    private TreemapSeriesDataEvents Events_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public string Parent { get; set; }

    private string Parent_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public double? Value { get; set; }

    private double? Value_DefaultValue { get; set; }

    public TreemapSeriesData()
    {
      this.Color = this.Color_DefaultValue = (string) null;
      double? nullable1 = new double?();
      this.ColorValue_DefaultValue = nullable1;
      this.ColorValue = nullable1;
      this.DataLabels = this.DataLabels_DefaultValue = (object) null;
      this.Drilldown = this.Drilldown_DefaultValue = "";
      this.Events = this.Events_DefaultValue = new TreemapSeriesDataEvents();
      this.Id = this.Id_DefaultValue = (string) null;
      this.Name = this.Name_DefaultValue = (string) null;
      this.Parent = this.Parent_DefaultValue = "undefined";
      bool? nullable2 = new bool?(false);
      this.Selected_DefaultValue = nullable2;
      this.Selected = nullable2;
      double? nullable3 = new double?();
      this.Value_DefaultValue = nullable3;
      this.Value = nullable3;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      double? colorValue = this.ColorValue;
      double? valueDefaultValue1 = this.ColorValue_DefaultValue;
      if ((colorValue.GetValueOrDefault() == valueDefaultValue1.GetValueOrDefault() ? (colorValue.HasValue != valueDefaultValue1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "colorValue", (object) this.ColorValue);
      if (this.DataLabels != this.DataLabels_DefaultValue)
        hashtable.Add((object) "dataLabels", this.DataLabels);
      if (this.Drilldown != this.Drilldown_DefaultValue)
        hashtable.Add((object) "drilldown", (object) this.Drilldown);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      if (this.Parent != this.Parent_DefaultValue)
        hashtable.Add((object) "parent", (object) this.Parent);
      bool? selected = this.Selected;
      bool? selectedDefaultValue = this.Selected_DefaultValue;
      if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? (selected.HasValue != selectedDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      valueDefaultValue1 = this.Value;
      double? valueDefaultValue2 = this.Value_DefaultValue;
      if ((valueDefaultValue1.GetValueOrDefault() == valueDefaultValue2.GetValueOrDefault() ? (valueDefaultValue1.HasValue != valueDefaultValue2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "value", (object) this.Value);
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
