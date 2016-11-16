﻿
// Type: Highsoft.Web.Mvc.Charts.TreemapSeriesLevels




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class TreemapSeriesLevels : BaseObject
  {
    public string BorderColor { get; set; }

    private string BorderColor_DefaultValue { get; set; }

    public string BorderDashStyle { get; set; }

    private string BorderDashStyle_DefaultValue { get; set; }

    public double? BorderWidth { get; set; }

    private double? BorderWidth_DefaultValue { get; set; }

    public string Color { get; set; }

    private string Color_DefaultValue { get; set; }

    public TreemapSeriesDataLabels DataLabels { get; set; }

    private TreemapSeriesDataLabels DataLabels_DefaultValue { get; set; }

    public TreemapSeriesLevelsLayoutAlgorithm LayoutAlgorithm { get; set; }

    private TreemapSeriesLevelsLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }

    public TreemapSeriesLevelsLayoutStartingDirection LayoutStartingDirection { get; set; }

    private TreemapSeriesLevelsLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }

    public double? Level { get; set; }

    private double? Level_DefaultValue { get; set; }

    public TreemapSeriesLevels()
    {
      this.BorderColor = this.BorderColor_DefaultValue = (string) null;
      this.BorderDashStyle = this.BorderDashStyle_DefaultValue = (string) null;
      double? nullable1 = new double?();
      this.BorderWidth_DefaultValue = nullable1;
      this.BorderWidth = nullable1;
      this.Color = this.Color_DefaultValue = (string) null;
      this.DataLabels = this.DataLabels_DefaultValue = new TreemapSeriesDataLabels();
      this.LayoutAlgorithm = this.LayoutAlgorithm_DefaultValue = TreemapSeriesLevelsLayoutAlgorithm.Null;
      this.LayoutStartingDirection = this.LayoutStartingDirection_DefaultValue = TreemapSeriesLevelsLayoutStartingDirection.Null;
      double? nullable2 = new double?();
      this.Level_DefaultValue = nullable2;
      this.Level = nullable2;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.BorderColor != this.BorderColor_DefaultValue)
        hashtable.Add((object) "borderColor", (object) this.BorderColor);
      if (this.BorderDashStyle != this.BorderDashStyle_DefaultValue)
        hashtable.Add((object) "borderDashStyle", (object) this.BorderDashStyle);
      double? borderWidth = this.BorderWidth;
      double? nullable = this.BorderWidth_DefaultValue;
      if ((borderWidth.GetValueOrDefault() == nullable.GetValueOrDefault() ? (borderWidth.HasValue != nullable.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
      if (this.Color != this.Color_DefaultValue)
        hashtable.Add((object) "color", (object) this.Color);
      if (this.DataLabels.IsDirty())
        hashtable.Add((object) "dataLabels", (object) this.DataLabels);
      if (this.LayoutAlgorithm != this.LayoutAlgorithm_DefaultValue)
        hashtable.Add((object) "layoutAlgorithm", (object) Highcharts.FirstCharacterToLower(this.LayoutAlgorithm.ToString()));
      if (this.LayoutStartingDirection != this.LayoutStartingDirection_DefaultValue)
        hashtable.Add((object) "layoutStartingDirection", (object) Highcharts.FirstCharacterToLower(this.LayoutStartingDirection.ToString()));
      nullable = this.Level;
      double? levelDefaultValue = this.Level_DefaultValue;
      if ((nullable.GetValueOrDefault() == levelDefaultValue.GetValueOrDefault() ? (nullable.HasValue != levelDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "level", (object) this.Level);
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
