﻿
// Type: Highsoft.Web.Mvc.Charts.YAxisLabels




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class YAxisLabels : BaseObject
  {
    public string Align { get; set; }

    private string Align_DefaultValue { get; set; }

    public List<double> AutoRotation { get; set; }

    private List<double> AutoRotation_DefaultValue { get; set; }

    public double? AutoRotationLimit { get; set; }

    private double? AutoRotationLimit_DefaultValue { get; set; }

    public double? Distance { get; set; }

    private double? Distance_DefaultValue { get; set; }

    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public string Format { get; set; }

    private string Format_DefaultValue { get; set; }

    public string Formatter { get; set; }

    private string Formatter_DefaultValue { get; set; }

    public double? Padding { get; set; }

    private double? Padding_DefaultValue { get; set; }

    public double? Rotation { get; set; }

    private double? Rotation_DefaultValue { get; set; }

    public double? StaggerLines { get; set; }

    private double? StaggerLines_DefaultValue { get; set; }

    public double? Step { get; set; }

    private double? Step_DefaultValue { get; set; }

    public Hashtable Style { get; set; }

    private Hashtable Style_DefaultValue { get; set; }

    public bool? UseHTML { get; set; }

    private bool? UseHTML_DefaultValue { get; set; }

    public double? X { get; set; }

    private double? X_DefaultValue { get; set; }

    public double? Y { get; set; }

    private double? Y_DefaultValue { get; set; }

    public double? ZIndex { get; set; }

    private double? ZIndex_DefaultValue { get; set; }

    public YAxisLabels()
    {
      this.Align = this.Align_DefaultValue = "right";
      List<double> doubleList1 = new List<double>();
      doubleList1.Add(-45.0);
      List<double> doubleList2 = doubleList1;
      this.AutoRotation_DefaultValue = doubleList1;
      this.AutoRotation = doubleList2;
      double? nullable1 = new double?(80.0);
      this.AutoRotationLimit_DefaultValue = nullable1;
      this.AutoRotationLimit = nullable1;
      nullable1 = new double?(15.0);
      this.Distance_DefaultValue = nullable1;
      this.Distance = nullable1;
      bool? nullable2 = new bool?(true);
      this.Enabled_DefaultValue = nullable2;
      this.Enabled = nullable2;
      this.Format = this.Format_DefaultValue = "{value}";
      this.Formatter = this.Formatter_DefaultValue = "";
      nullable1 = new double?(5.0);
      this.Padding_DefaultValue = nullable1;
      this.Padding = nullable1;
      nullable1 = new double?(0.0);
      this.Rotation_DefaultValue = nullable1;
      this.Rotation = nullable1;
      double? nullable3 = new double?();
      this.StaggerLines_DefaultValue = nullable3;
      this.StaggerLines = nullable3;
      double? nullable4 = new double?();
      this.Step_DefaultValue = nullable4;
      this.Step = nullable4;
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "color", (object) "#6D869F");
      hashtable1.Add((object) "fontWeight", (object) "bold");
      Hashtable hashtable2 = hashtable1;
      this.Style_DefaultValue = hashtable1;
      this.Style = hashtable2;
      nullable2 = new bool?(false);
      this.UseHTML_DefaultValue = nullable2;
      this.UseHTML = nullable2;
      double? nullable5 = new double?();
      this.X_DefaultValue = nullable5;
      this.X = nullable5;
      nullable5 = new double?(3.0);
      this.Y_DefaultValue = nullable5;
      this.Y = nullable5;
      nullable5 = new double?(7.0);
      this.ZIndex_DefaultValue = nullable5;
      this.ZIndex = nullable5;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Align != this.Align_DefaultValue)
        hashtable.Add((object) "align", (object) this.Align);
      if (this.AutoRotation != this.AutoRotation_DefaultValue)
        hashtable.Add((object) "autoRotation", (object) this.AutoRotation);
      double? autoRotationLimit = this.AutoRotationLimit;
      double? nullable1 = this.AutoRotationLimit_DefaultValue;
      if ((autoRotationLimit.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (autoRotationLimit.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "autoRotationLimit", (object) this.AutoRotationLimit);
      nullable1 = this.Distance;
      double? nullable2 = this.Distance_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "distance", (object) this.Distance);
      bool? enabled = this.Enabled;
      bool? nullable3 = this.Enabled_DefaultValue;
      if ((enabled.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (enabled.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      if (this.Format != this.Format_DefaultValue)
        hashtable.Add((object) "format", (object) this.Format);
      if (this.Formatter != this.Formatter_DefaultValue)
      {
        hashtable.Add((object) "formatter", (object) this.Formatter);
        Highcharts.AddFunction("YAxisLabelsFormatter.formatter", this.Formatter);
      }
      nullable2 = this.Padding;
      nullable1 = this.Padding_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "padding", (object) this.Padding);
      nullable1 = this.Rotation;
      nullable2 = this.Rotation_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "rotation", (object) this.Rotation);
      nullable2 = this.StaggerLines;
      nullable1 = this.StaggerLines_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "staggerLines", (object) this.StaggerLines);
      nullable1 = this.Step;
      nullable2 = this.Step_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "step", (object) this.Step);
      if (this.Style != this.Style_DefaultValue)
        hashtable.Add((object) "style", (object) this.Style);
      nullable3 = this.UseHTML;
      bool? htmlDefaultValue = this.UseHTML_DefaultValue;
      if ((nullable3.GetValueOrDefault() == htmlDefaultValue.GetValueOrDefault() ? (nullable3.HasValue != htmlDefaultValue.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "useHTML", (object) this.UseHTML);
      nullable2 = this.X;
      nullable1 = this.X_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "x", (object) this.X);
      nullable1 = this.Y;
      nullable2 = this.Y_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "y", (object) this.Y);
      nullable2 = this.ZIndex;
      nullable1 = this.ZIndex_DefaultValue;
      if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
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