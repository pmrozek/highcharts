// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreaDataLabels


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsAreaDataLabels : BaseObject
    {
        public PlotOptionsAreaDataLabels()
        {
            this.Align = this.Align_DefaultValue = PlotOptionsAreaDataLabelsAlign.Center;
            bool? nullable1 = new bool?(false);
            this.AllowOverlap_DefaultValue = nullable1;
            this.AllowOverlap = nullable1;
            this.BorderColor = this.BorderColor_DefaultValue = "undefined";
            double? nullable2 = new double?(0.0);
            this.BorderRadius_DefaultValue = nullable2;
            this.BorderRadius = nullable2;
            nullable2 = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable2;
            this.BorderWidth = nullable2;
            this.ClassName = this.ClassName_DefaultValue = (string) null;
            this.Color = this.Color_DefaultValue = (string) null;
            nullable1 = new bool?(true);
            this.Crop_DefaultValue = nullable1;
            this.Crop = nullable1;
            nullable1 = new bool?(true);
            this.Defer_DefaultValue = nullable1;
            this.Defer = nullable1;
            nullable1 = new bool?(false);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Format = this.Format_DefaultValue = "{y}";
            this.Formatter = this.Formatter_DefaultValue = "";
            bool? nullable3 = new bool?();
            this.Inside_DefaultValue = nullable3;
            this.Inside = nullable3;
            this.Overflow = this.Overflow_DefaultValue = PlotOptionsAreaDataLabelsOverflow.Justify;
            nullable2 = new double?(5.0);
            this.Padding_DefaultValue = nullable2;
            this.Padding = nullable2;
            nullable2 = new double?(0.0);
            this.Rotation_DefaultValue = nullable2;
            this.Rotation = nullable2;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            this.Shape = this.Shape_DefaultValue = "square";
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "contrast"
                },
                {
                    (object) "fontSize",
                    (object) "11px"
                },
                {
                    (object) "fontWeight",
                    (object) "bold"
                },
                {
                    (object) "textOutline",
                    (object) "1px 1px contrast"
                }
            };
            nullable3 = new bool?(false);
            this.UseHTML_DefaultValue = nullable3;
            this.UseHTML = nullable3;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = PlotOptionsAreaDataLabelsVerticalAlign.Null;
            nullable2 = new double?(0.0);
            this.X_DefaultValue = nullable2;
            this.X = nullable2;
            nullable2 = new double?(-6.0);
            this.Y_DefaultValue = nullable2;
            this.Y = nullable2;
            nullable2 = new double?(6.0);
            this.ZIndex_DefaultValue = nullable2;
            this.ZIndex = nullable2;
        }

        public PlotOptionsAreaDataLabelsAlign Align { get; set; }

        private PlotOptionsAreaDataLabelsAlign Align_DefaultValue { get; set; }

        public bool? AllowOverlap { get; set; }

        private bool? AllowOverlap_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderRadius { get; set; }

        private double? BorderRadius_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public bool? Crop { get; set; }

        private bool? Crop_DefaultValue { get; set; }

        public bool? Defer { get; set; }

        private bool? Defer_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Format { get; set; }

        private string Format_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public bool? Inside { get; set; }

        private bool? Inside_DefaultValue { get; set; }

        public PlotOptionsAreaDataLabelsOverflow Overflow { get; set; }

        private PlotOptionsAreaDataLabelsOverflow Overflow_DefaultValue { get; set; }

        public double? Padding { get; set; }

        private double? Padding_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public string Shape { get; set; }

        private string Shape_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public PlotOptionsAreaDataLabelsVerticalAlign VerticalAlign { get; set; }

        private PlotOptionsAreaDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            bool? nullable1 = this.AllowOverlap;
            bool? nullable2 = this.AllowOverlap_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allowOverlap", (object) this.AllowOverlap);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? nullable3 = this.BorderRadius;
            double? nullable4 = this.BorderRadius_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable4 = this.BorderWidth;
            nullable3 = this.BorderWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable2 = this.Crop;
            nullable1 = this.Crop_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "crop", (object) this.Crop);
            nullable1 = this.Defer;
            nullable2 = this.Defer_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "defer", (object) this.Defer);
            nullable2 = this.Enabled;
            nullable1 = this.Enabled_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highstock.AddFunction("PlotOptionsAreaDataLabelsFormatter.formatter", this.Formatter);
            }
            nullable1 = this.Inside;
            nullable2 = this.Inside_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "inside", (object) this.Inside);
            if (this.Overflow != this.Overflow_DefaultValue)
                hashtable.Add((object) "overflow", (object) Highstock.FirstCharacterToLower(this.Overflow.ToString()));
            nullable3 = this.Padding;
            nullable4 = this.Padding_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "padding", (object) this.Padding);
            nullable4 = this.Rotation;
            nullable3 = this.Rotation_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Shadow.IsDirty())
                hashtable.Add((object) "shadow", (object) this.Shadow.ToHashtable());
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highstock.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable3 = this.X;
            nullable4 = this.X_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable4 = this.Y;
            nullable3 = this.Y_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
            nullable3 = this.ZIndex;
            nullable4 = this.ZIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
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