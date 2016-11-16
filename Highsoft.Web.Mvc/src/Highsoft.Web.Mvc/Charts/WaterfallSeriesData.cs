
// Type: Highsoft.Web.Mvc.Charts.WaterfallSeriesData




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class WaterfallSeriesData : BaseObject
  {
    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public object DataLabels { get; set; }

    private object DataLabels_DefaultValue { get; set; }

    public string Drilldown { get; set; }

    private string Drilldown_DefaultValue { get; set; }

    public WaterfallSeriesDataEvents Events { get; set; }

    private WaterfallSeriesDataEvents Events_DefaultValue { get; set; }

    public string Id { get; set; }

    private string Id_DefaultValue { get; set; }

    public bool? IsIntermediateSum { get; set; }

    private bool? IsIntermediateSum_DefaultValue { get; set; }

    public bool? IsSum { get; set; }

    private bool? IsSum_DefaultValue { get; set; }

    public string Name { get; set; }

    private string Name_DefaultValue { get; set; }

    public bool? Selected { get; set; }

    private bool? Selected_DefaultValue { get; set; }

    public double? X { get; set; }

    private double? X_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public WaterfallSeriesData()
    {
      this.Color = this.Color_DefaultValue = "undefined";
      this.DataLabels = this.DataLabels_DefaultValue = (object) null;
      this.Drilldown = this.Drilldown_DefaultValue = "";
      this.Events = this.Events_DefaultValue = new WaterfallSeriesDataEvents();
      this.Id = this.Id_DefaultValue = (string) null;
      bool? nullable1 = new bool?(false);
      this.IsIntermediateSum_DefaultValue = nullable1;
      this.IsIntermediateSum = nullable1;
      nullable1 = new bool?(false);
      this.IsSum_DefaultValue = nullable1;
      this.IsSum = nullable1;
      this.Name = this.Name_DefaultValue = (string) null;
      nullable1 = new bool?(false);
      this.Selected_DefaultValue = nullable1;
      this.Selected = nullable1;
      double? nullable2 = new double?(double.MinValue);
      this.X_DefaultValue = nullable2;
      this.X = nullable2;
      nullable2 = new double?(double.MinValue);
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
      if (this.Drilldown != this.Drilldown_DefaultValue)
        hashtable.Add((object) "drilldown", (object) this.Drilldown);
      if (this.Events.IsDirty())
        hashtable.Add((object) "events", (object) this.Events.ToHashtable());
      if (this.Id != this.Id_DefaultValue)
        hashtable.Add((object) "id", (object) this.Id);
      bool? isIntermediateSum = this.IsIntermediateSum;
      bool? nullable1 = this.IsIntermediateSum_DefaultValue;
      if ((isIntermediateSum.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (isIntermediateSum.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "isIntermediateSum", (object) this.IsIntermediateSum);
      nullable1 = this.IsSum;
      bool? nullable2 = this.IsSum_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "isSum", (object) this.IsSum);
      if (this.Name != this.Name_DefaultValue)
        hashtable.Add((object) "name", (object) this.Name);
      nullable2 = this.Selected;
      nullable1 = this.Selected_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
      double? x = this.X;
      double? nullable3 = this.X_DefaultValue;
      if ((x.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (x.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "x", (object) this.X);
      nullable3 = this.Y;
      double? yDefaultValue = this.Y_DefaultValue;
      if ((nullable3.GetValueOrDefault() == yDefaultValue.GetValueOrDefault() ? (nullable3.HasValue != yDefaultValue.HasValue ? 1 : 0) : 1) != 0)
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
