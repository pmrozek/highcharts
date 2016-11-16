
// Type: Highsoft.Web.Mvc.Stocks.RangeSelector




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class RangeSelector : BaseObject
  {
    public bool? AllButtonsEnabled { get; set; }

    private bool? AllButtonsEnabled_DefaultValue { get; set; }

    public double? ButtonSpacing { get; set; }

    private double? ButtonSpacing_DefaultValue { get; set; }

    public object ButtonTheme { get; set; }

    private object ButtonTheme_DefaultValue { get; set; }

    public List<object> Buttons { get; set; }

    private List<object> Buttons_DefaultValue { get; set; }

    public bool? Enabled { get; set; }

    private bool? Enabled_DefaultValue { get; set; }

    public string InputBoxBorderColor { get; set; }

    private string InputBoxBorderColor_DefaultValue { get; set; }

    public double? InputBoxHeight { get; set; }

    private double? InputBoxHeight_DefaultValue { get; set; }

    public double? InputBoxWidth { get; set; }

    private double? InputBoxWidth_DefaultValue { get; set; }

    public string InputDateFormat { get; set; }

    private string InputDateFormat_DefaultValue { get; set; }

    public string InputDateParser { get; set; }

    private string InputDateParser_DefaultValue { get; set; }

    public string InputEditDateFormat { get; set; }

    private string InputEditDateFormat_DefaultValue { get; set; }

    public bool? InputEnabled { get; set; }

    private bool? InputEnabled_DefaultValue { get; set; }

    public Hashtable InputPosition { get; set; }

    private Hashtable InputPosition_DefaultValue { get; set; }

    public Hashtable InputStyle { get; set; }

    private Hashtable InputStyle_DefaultValue { get; set; }

    public Hashtable LabelStyle { get; set; }

    private Hashtable LabelStyle_DefaultValue { get; set; }

    public double? Selected { get; set; }

    private double? Selected_DefaultValue { get; set; }

    public RangeSelector()
    {
      bool? nullable1 = new bool?(false);
      this.AllButtonsEnabled_DefaultValue = nullable1;
      this.AllButtonsEnabled = nullable1;
      double? nullable2 = new double?(0.0);
      this.ButtonSpacing_DefaultValue = nullable2;
      this.ButtonSpacing = nullable2;
      this.ButtonTheme = this.ButtonTheme_DefaultValue = (object) "";
      this.Buttons = this.Buttons_DefaultValue = (List<object>) null;
      nullable1 = new bool?(true);
      this.Enabled_DefaultValue = nullable1;
      this.Enabled = nullable1;
      this.InputBoxBorderColor = this.InputBoxBorderColor_DefaultValue = "silver";
      nullable2 = new double?(17.0);
      this.InputBoxHeight_DefaultValue = nullable2;
      this.InputBoxHeight = nullable2;
      nullable2 = new double?(90.0);
      this.InputBoxWidth_DefaultValue = nullable2;
      this.InputBoxWidth = nullable2;
      this.InputDateFormat = this.InputDateFormat_DefaultValue = "%b %e %Y,";
      this.InputDateParser = this.InputDateParser_DefaultValue = "";
      this.InputEditDateFormat = this.InputEditDateFormat_DefaultValue = "%Y-%m-%d";
      bool? nullable3 = new bool?();
      this.InputEnabled_DefaultValue = nullable3;
      this.InputEnabled = nullable3;
      Hashtable hashtable1 = new Hashtable();
      hashtable1.Add((object) "align", (object) "right");
      Hashtable hashtable2 = hashtable1;
      this.InputPosition_DefaultValue = hashtable1;
      this.InputPosition = hashtable2;
      this.InputStyle = this.InputStyle_DefaultValue = new Hashtable();
      this.LabelStyle = this.LabelStyle_DefaultValue = new Hashtable();
      double? nullable4 = new double?();
      this.Selected_DefaultValue = nullable4;
      this.Selected = nullable4;
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      bool? allButtonsEnabled = this.AllButtonsEnabled;
      bool? enabledDefaultValue1 = this.AllButtonsEnabled_DefaultValue;
      if ((allButtonsEnabled.GetValueOrDefault() == enabledDefaultValue1.GetValueOrDefault() ? (allButtonsEnabled.HasValue != enabledDefaultValue1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "allButtonsEnabled", (object) this.AllButtonsEnabled);
      double? buttonSpacing = this.ButtonSpacing;
      double? nullable1 = this.ButtonSpacing_DefaultValue;
      if ((buttonSpacing.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (buttonSpacing.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "buttonSpacing", (object) this.ButtonSpacing);
      if (this.ButtonTheme != this.ButtonTheme_DefaultValue)
        hashtable.Add((object) "buttonTheme", this.ButtonTheme);
      if (this.Buttons != this.Buttons_DefaultValue)
        hashtable.Add((object) "buttons", (object) this.Buttons);
      bool? enabled = this.Enabled;
      bool? nullable2 = this.Enabled_DefaultValue;
      if ((enabled.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (enabled.HasValue != nullable2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "enabled", (object) this.Enabled);
      if (this.InputBoxBorderColor != this.InputBoxBorderColor_DefaultValue)
        hashtable.Add((object) "inputBoxBorderColor", (object) this.InputBoxBorderColor);
      nullable1 = this.InputBoxHeight;
      double? nullable3 = this.InputBoxHeight_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "inputBoxHeight", (object) this.InputBoxHeight);
      nullable3 = this.InputBoxWidth;
      nullable1 = this.InputBoxWidth_DefaultValue;
      if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault() ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "inputBoxWidth", (object) this.InputBoxWidth);
      if (this.InputDateFormat != this.InputDateFormat_DefaultValue)
        hashtable.Add((object) "inputDateFormat", (object) this.InputDateFormat);
      if (this.InputDateParser != this.InputDateParser_DefaultValue)
      {
        hashtable.Add((object) "inputDateParser", (object) this.InputDateParser);
        Highstock.AddFunction("RangeSelectorInputDateParser.inputDateParser", this.InputDateParser);
      }
      if (this.InputEditDateFormat != this.InputEditDateFormat_DefaultValue)
        hashtable.Add((object) "inputEditDateFormat", (object) this.InputEditDateFormat);
      nullable2 = this.InputEnabled;
      bool? enabledDefaultValue2 = this.InputEnabled_DefaultValue;
      if ((nullable2.GetValueOrDefault() == enabledDefaultValue2.GetValueOrDefault() ? (nullable2.HasValue != enabledDefaultValue2.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "inputEnabled", (object) this.InputEnabled);
      if (this.InputPosition != this.InputPosition_DefaultValue)
        hashtable.Add((object) "inputPosition", (object) this.InputPosition);
      if (this.InputStyle != this.InputStyle_DefaultValue)
        hashtable.Add((object) "inputStyle", (object) this.InputStyle);
      if (this.LabelStyle != this.LabelStyle_DefaultValue)
        hashtable.Add((object) "labelStyle", (object) this.LabelStyle);
      nullable1 = this.Selected;
      nullable3 = this.Selected_DefaultValue;
      if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault() ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0) : 1) != 0)
        hashtable.Add((object) "selected", (object) this.Selected);
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
