
// Type: Highsoft.Web.Mvc.Charts.GaugeSeriesData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class GaugeSeriesData : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public object DataLabels { get; set; }

    private object DataLabels_DefaultValue { get; set; }

    public GaugeSeriesDataEvents Events { get; set; }

    private GaugeSeriesDataEvents Events_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public GaugeSeriesData()
    {
      this.Color = this.Color_DefaultValue = "undefined";
      this.DataLabels = this.DataLabels_DefaultValue = (object) null;
      this.Events = this.Events_DefaultValue = new GaugeSeriesDataEvents();
      this.Id = this.Id_DefaultValue = (string) null;
      this.Name = this.Name_DefaultValue = (string) null;
      bool? nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      double? nullable2 = new double?(double.MinValue);
      this.Y_DefaultValue = nullable2;
      this.Y = nullable2;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.DataLabels != this.DataLabels_DefaultValue)
        hashtable.Add((object) "dataLabels", this.DataLabels);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      bool? selected = this.Selected;
      bool? selectedDefaultValue = this.Selected_DefaultValue;
      if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? (selected.HasValue != selectedDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      double? y = this.Y;
      double? yDefaultValue = this.Y_DefaultValue;
      if ((y.GetValueOrDefault() == yDefaultValue.GetValueOrDefault() ? (y.HasValue != yDefaultValue.HasValue ? 1 : 0) : 1) != 0)
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
