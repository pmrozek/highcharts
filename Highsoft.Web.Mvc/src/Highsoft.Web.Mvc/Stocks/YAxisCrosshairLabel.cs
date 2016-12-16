// Type: Highsoft.Web.Mvc.Stocks.YAxisCrosshairLabel


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class YAxisCrosshairLabel : BaseObject
    {
        public string Align { get; set; }

        private string Align_DefaultValue { get; set; }

        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderRadius { get; set; }

        private double? BorderRadius_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string Format { get; set; }

        private string Format_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public double? Padding { get; set; }

        private double? Padding_DefaultValue { get; set; }

        public string Shape { get; set; }

        private string Shape_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public YAxisCrosshairLabel()
        {
            this.Align = this.Align_DefaultValue = "";
            this.BackgroundColor = this.BackgroundColor_DefaultValue = (string) null;
            this.BorderColor = this.BorderColor_DefaultValue = "";
            double? nullable = new double?(3.0);
            this.BorderRadius_DefaultValue = nullable;
            this.BorderRadius = nullable;
            nullable = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable;
            this.BorderWidth = nullable;
            this.Format = this.Format_DefaultValue = "";
            this.Formatter = this.Formatter_DefaultValue = "";
            nullable = new double?(8.0);
            this.Padding_DefaultValue = nullable;
            this.Padding = nullable;
            this.Shape = this.Shape_DefaultValue = "callout";
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "white");
            hashtable1.Add((object) "fontWeight", (object) "normal");
            hashtable1.Add((object) "fontSize", (object) "11px");
            hashtable1.Add((object) "textAlign", (object) "center");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) this.Align);
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? nullable1 = this.BorderRadius;
            double? nullable2 = this.BorderRadius_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable2 = this.BorderWidth;
            nullable1 = this.BorderWidth_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highstock.AddFunction("YAxisCrosshairLabelFormatter.formatter", this.Formatter);
            }
            nullable1 = this.Padding;
            nullable2 = this.Padding_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "padding", (object) this.Padding);
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
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