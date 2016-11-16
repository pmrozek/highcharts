
// Type: Highsoft.Web.Mvc.Charts.Exporting




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class Exporting : BaseObject
  {
    public ExportingButtons Buttons { get; set; }

    private ExportingButtons Buttons_DefaultValue { get; set; }

    public object ChartOptions { get; set; }

    private object ChartOptions_DefaultValue { get; set; }

    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public string Filename { get; set; }

    private string Filename_DefaultValue { get; set; }

    public object FormAttributes { get; set; }

    private object FormAttributes_DefaultValue { get; set; }

    public double? Scale { get; set; }

    private double? Scale_DefaultValue { get; set; }

    public double? SourceHeight { get; set; }

    private double? SourceHeight_DefaultValue { get; set; }

    public double? SourceWidth { get; set; }

    private double? SourceWidth_DefaultValue { get; set; }

    public ExportingType Type { get; set; }

    private ExportingType Type_DefaultValue { get; set; }

    public string Url { get; set; }

    private string Url_DefaultValue { get; set; }

    public double? Width { get; set; }

    private double? Width_DefaultValue { get; set; }

    public Exporting()
    {
      this.Buttons = this.Buttons_DefaultValue = new ExportingButtons();
      this.ChartOptions = this.ChartOptions_DefaultValue = (object) null;
      bool? nullable1 = new bool?(true);
      this.Enabled_DefaultValue = nullable1;
      this.Enabled = nullable1;
      this.Filename = this.Filename_DefaultValue = "chart";
      this.FormAttributes = this.FormAttributes_DefaultValue = (object) "";
      double? nullable2 = new double?(2.0);
      this.Scale_DefaultValue = nullable2;
      this.Scale = nullable2;
      double? nullable3 = new double?();
      this.SourceHeight_DefaultValue = nullable3;
      this.SourceHeight = nullable3;
      double? nullable4 = new double?();
      this.SourceWidth_DefaultValue = nullable4;
      this.SourceWidth = nullable4;
      this.Type = this.Type_DefaultValue = ExportingType.Imagepng;
      this.Url = this.Url_DefaultValue = "http://export.highcharts.com";
      double? nullable5 = new double?();
      this.Width_DefaultValue = nullable5;
      this.Width = nullable5;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Buttons.IsDirty())
        hashtable.Add((object) "buttons", (object) this.Buttons.ToHashtable());
      if (this.ChartOptions != this.ChartOptions_DefaultValue)
        hashtable.Add((object) "chartOptions", this.ChartOptions);
      bool? enabled = this.Enabled;
      bool? enabledDefaultValue = this.Enabled_DefaultValue;
      if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? (enabled.HasValue != enabledDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      if (this.Filename != this.Filename_DefaultValue)
        hashtable.Add((object) "filename", (object) this.Filename);
      if (this.FormAttributes != this.FormAttributes_DefaultValue)
        hashtable.Add((object) "formAttributes", this.FormAttributes);
      double? nullable1 = this.Scale;
      double? nullable2 = this.Scale_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "scale", (object) this.Scale);
      nullable2 = this.SourceHeight;
      nullable1 = this.SourceHeight_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "sourceHeight", (object) this.SourceHeight);
      nullable1 = this.SourceWidth;
      nullable2 = this.SourceWidth_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "sourceWidth", (object) this.SourceWidth);
      if (this.Type != this.Type_DefaultValue)
        hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
      if (this.Url != this.Url_DefaultValue)
        hashtable.Add((object) "url", (object) this.Url);
      nullable2 = this.Width;
      nullable1 = this.Width_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
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
