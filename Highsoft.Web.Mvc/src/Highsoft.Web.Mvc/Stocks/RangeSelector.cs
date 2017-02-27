// Type: Highsoft.Web.Mvc.Stocks.RangeSelector


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class RangeSelector : BaseObject
    {
        public bool? AllButtonsEnabled { get; set; }

        private bool? AllButtonsEnabled_DefaultValue { get; set; }

        public object ButtonPosition { get; set; }

        private object ButtonPosition_DefaultValue { get; set; }

        public double? ButtonSpacing { get; set; }

        private double? ButtonSpacing_DefaultValue { get; set; }

        public object ButtonTheme { get; set; }

        private object ButtonTheme_DefaultValue { get; set; }

        public List<RangeSelectorButton> Buttons { get; set; }

        private List<RangeSelectorButton> Buttons_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public double? Height { get; set; }

        private double? Height_DefaultValue { get; set; }

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
            this.ButtonPosition = this.ButtonPosition_DefaultValue = (object) "";
            double? nullable2 = new double?(0.0);
            this.ButtonSpacing_DefaultValue = nullable2;
            this.ButtonSpacing = nullable2;
            this.ButtonTheme = this.ButtonTheme_DefaultValue = (object) null;
            this.Buttons = this.Buttons_DefaultValue = new List<RangeSelectorButton>();
            nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            nullable2 = new double?(35.0);
            this.Height_DefaultValue = nullable2;
            this.Height = nullable2;
            this.InputBoxBorderColor = this.InputBoxBorderColor_DefaultValue = "#cccccc";
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
            this.InputPosition = this.InputPosition_DefaultValue = new Hashtable()
            {
                {
                    (object) "align",
                    (object) "right"
                }
            };
            this.InputStyle = this.InputStyle_DefaultValue = new Hashtable();
            this.LabelStyle = this.LabelStyle_DefaultValue = new Hashtable();
            double? nullable4 = new double?();
            this.Selected_DefaultValue = nullable4;
            this.Selected = nullable4;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AllButtonsEnabled;
            bool? nullable2 = this.AllButtonsEnabled_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allButtonsEnabled", (object) this.AllButtonsEnabled);
            if (this.ButtonPosition != this.ButtonPosition_DefaultValue)
                hashtable.Add((object) "buttonPosition", this.ButtonPosition);
            double? nullable3 = this.ButtonSpacing;
            double? nullable4 = this.ButtonSpacing_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "buttonSpacing", (object) this.ButtonSpacing);
            if (this.ButtonTheme != this.ButtonTheme_DefaultValue)
                hashtable.Add((object) "buttonTheme", this.ButtonTheme);
            if (this.Buttons.Any<RangeSelectorButton>())
            {
                List<Hashtable> hashtableList = new List<Hashtable>();
                foreach (RangeSelectorButton button in this.Buttons)
                    hashtableList.Add(button.ToHashtable());
                hashtable.Add((object) "buttons", (object) hashtableList);
            }
            nullable2 = this.Enabled;
            nullable1 = this.Enabled_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable4 = this.Height;
            nullable3 = this.Height_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "height", (object) this.Height);
            if (this.InputBoxBorderColor != this.InputBoxBorderColor_DefaultValue)
                hashtable.Add((object) "inputBoxBorderColor", (object) this.InputBoxBorderColor);
            nullable3 = this.InputBoxHeight;
            nullable4 = this.InputBoxHeight_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "inputBoxHeight", (object) this.InputBoxHeight);
            nullable4 = this.InputBoxWidth;
            nullable3 = this.InputBoxWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
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
            nullable1 = this.InputEnabled;
            nullable2 = this.InputEnabled_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "inputEnabled", (object) this.InputEnabled);
            if (this.InputPosition != this.InputPosition_DefaultValue)
                hashtable.Add((object) "inputPosition", (object) this.InputPosition);
            if (this.InputStyle != this.InputStyle_DefaultValue)
                hashtable.Add((object) "inputStyle", (object) this.InputStyle);
            if (this.LabelStyle != this.LabelStyle_DefaultValue)
                hashtable.Add((object) "labelStyle", (object) this.LabelStyle);
            nullable3 = this.Selected;
            nullable4 = this.Selected_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
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