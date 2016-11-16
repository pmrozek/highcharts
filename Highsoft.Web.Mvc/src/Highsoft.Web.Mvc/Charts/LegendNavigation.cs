﻿
// Type: Highsoft.Web.Mvc.Charts.LegendNavigation




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class LegendNavigation : BaseObject
  {
    public string ActiveColor { get; set; }

    private string ActiveColor_DefaultValue { get; set; }

    public Animation Animation { get; set; }

    private Animation Animation_DefaultValue { get; set; }

    public double? ArrowSize { get; set; }

    private double? ArrowSize_DefaultValue { get; set; }

    public string InactiveColor { get; set; }

    private string InactiveColor_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public LegendNavigation()
    {
      this.ActiveColor = this.ActiveColor_DefaultValue = "#3E576F";
      Animation animation1 = new Animation();
      animation1.Enabled = true;
      Animation animation2 = animation1;
      this.Animation_DefaultValue = animation1;
      this.Animation = animation2;
      double? nullable = new double?(12.0);
      this.ArrowSize_DefaultValue = nullable;
      this.ArrowSize = nullable;
      this.InactiveColor = this.InactiveColor_DefaultValue = "#CCC";
      this.Style = this.Style_DefaultValue = new Hashtable();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.ActiveColor != this.ActiveColor_DefaultValue)
        hashtable.Add((object) "activeColor", (object) this.ActiveColor);
      if (this.Animation.IsDirty())
        hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
      double? arrowSize = this.ArrowSize;
      double? sizeDefaultValue = this.ArrowSize_DefaultValue;
      if ((arrowSize.GetValueOrDefault() == sizeDefaultValue.GetValueOrDefault() ? (arrowSize.HasValue != sizeDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "arrowSize", (object) this.ArrowSize);
      if (this.InactiveColor != this.InactiveColor_DefaultValue)
        hashtable.Add((object) "inactiveColor", (object) this.InactiveColor);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
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