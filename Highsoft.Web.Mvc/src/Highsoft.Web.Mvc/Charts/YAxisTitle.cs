
// Type: Highsoft.Web.Mvc.Charts.YAxisTitle




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class YAxisTitle : BaseObject
  {
    public YAxisTitleAlign Align { get; set; }

    private YAxisTitleAlign Align_DefaultValue { get; set; }

    public string[] Margin { get; set; }

    private string[] Margin_DefaultValue { get; set; }

    public double? Offset { get; set; }

    private double? Offset_DefaultValue { get; set; }

    public double? Rotation { get; set; }

    private double? Rotation_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public string Text { get; set; }

    private string Text_DefaultValue { get; set; }

    public YAxisTitle()
    {
      this.Align = this.Align_DefaultValue = YAxisTitleAlign.Middle;
      this.Margin = this.Margin_DefaultValue = new string[0];
      double? nullable = new double?();
      this.Offset_DefaultValue = nullable;
      this.Offset = nullable;
      nullable = new double?(270.0);
      this.Rotation_DefaultValue = nullable;
      this.Rotation = nullable;
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "color", (object) "#707070");
      hashtable1.Add((object) "fontWeight", (object) "bold");
      Hashtable hashtable2 = hashtable1;
      this.Style_DefaultValue = hashtable1;
      this.Style = hashtable2;
      this.Text = this.Text_DefaultValue = "Values";
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Align != this.Align_DefaultValue)
        hashtable.Add((object) "align", (object) Highcharts.FirstCharacterToLower(this.Align.ToString()));
      if (this.Margin != this.Margin_DefaultValue)
        hashtable.Add((object) "margin", (object) this.Margin);
      double? nullable1 = this.Offset;
      double? nullable2 = this.Offset_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "offset", (object) this.Offset);
      nullable2 = this.Rotation;
      nullable1 = this.Rotation_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "rotation", (object) this.Rotation);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      if (this.Text != this.Text_DefaultValue)
        hashtable.Add((object) "text", (object) this.Text);
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
