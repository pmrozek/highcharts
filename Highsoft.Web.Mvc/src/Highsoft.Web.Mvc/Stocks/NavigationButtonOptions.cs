// Type: Highsoft.Web.Mvc.Stocks.NavigationButtonOptions


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class NavigationButtonOptions : BaseObject
    {
        public NavigationButtonOptions()
        {
            this.Align = this.Align_DefaultValue = NavigationButtonOptionsAlign.Right;
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            double? nullable2 = new double?(20.0);
            this.Height_DefaultValue = nullable2;
            this.Height = nullable2;
            this.SymbolFill = this.SymbolFill_DefaultValue = "#666666";
            nullable2 = new double?(14.0);
            this.SymbolSize_DefaultValue = nullable2;
            this.SymbolSize = nullable2;
            this.SymbolStroke = this.SymbolStroke_DefaultValue = "#666666";
            nullable2 = new double?(1.0);
            this.SymbolStrokeWidth_DefaultValue = nullable2;
            this.SymbolStrokeWidth = nullable2;
            nullable2 = new double?(12.5);
            this.SymbolX_DefaultValue = nullable2;
            this.SymbolX = nullable2;
            nullable2 = new double?(10.5);
            this.SymbolY_DefaultValue = nullable2;
            this.SymbolY = nullable2;
            this.Text = this.Text_DefaultValue = "null";
            this.Theme = this.Theme_DefaultValue = (object) "";
            this.VerticalAlign = this.VerticalAlign_DefaultValue = NavigationButtonOptionsVerticalAlign.Top;
            nullable2 = new double?(24.0);
            this.Width_DefaultValue = nullable2;
            this.Width = nullable2;
            nullable2 = new double?(0.0);
            this.Y_DefaultValue = nullable2;
            this.Y = nullable2;
        }

        public NavigationButtonOptionsAlign Align { get; set; }

        private NavigationButtonOptionsAlign Align_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public double? Height { get; set; }

        private double? Height_DefaultValue { get; set; }

        public string SymbolFill { get; set; }

        private string SymbolFill_DefaultValue { get; set; }

        public double? SymbolSize { get; set; }

        private double? SymbolSize_DefaultValue { get; set; }

        public string SymbolStroke { get; set; }

        private string SymbolStroke_DefaultValue { get; set; }

        public double? SymbolStrokeWidth { get; set; }

        private double? SymbolStrokeWidth_DefaultValue { get; set; }

        public double? SymbolX { get; set; }

        private double? SymbolX_DefaultValue { get; set; }

        public double? SymbolY { get; set; }

        private double? SymbolY_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public object Theme { get; set; }

        private object Theme_DefaultValue { get; set; }

        public NavigationButtonOptionsVerticalAlign VerticalAlign { get; set; }

        private NavigationButtonOptionsVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? Width { get; set; }

        private double? Width_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if (enabled.GetValueOrDefault() != enabledDefaultValue.GetValueOrDefault() ||
                enabled.HasValue != enabledDefaultValue.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            double? nullable1 = this.Height;
            double? nullable2 = this.Height_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "height", (object) this.Height);
            if (this.SymbolFill != this.SymbolFill_DefaultValue)
                hashtable.Add((object) "symbolFill", (object) this.SymbolFill);
            nullable2 = this.SymbolSize;
            nullable1 = this.SymbolSize_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "symbolSize", (object) this.SymbolSize);
            if (this.SymbolStroke != this.SymbolStroke_DefaultValue)
                hashtable.Add((object) "symbolStroke", (object) this.SymbolStroke);
            nullable1 = this.SymbolStrokeWidth;
            nullable2 = this.SymbolStrokeWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "symbolStrokeWidth", (object) this.SymbolStrokeWidth);
            nullable2 = this.SymbolX;
            nullable1 = this.SymbolX_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "symbolX", (object) this.SymbolX);
            nullable1 = this.SymbolY;
            nullable2 = this.SymbolY_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "symbolY", (object) this.SymbolY);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            if (this.Theme != this.Theme_DefaultValue)
                hashtable.Add((object) "theme", this.Theme);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highstock.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable2 = this.Width;
            nullable1 = this.Width_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "width", (object) this.Width);
            nullable1 = this.Y;
            nullable2 = this.Y_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
            return hashtable;
        }

        internal override string ToJSON()
        {
            Hashtable hashtable = this.ToHashtable();


            if (hashtable.Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}