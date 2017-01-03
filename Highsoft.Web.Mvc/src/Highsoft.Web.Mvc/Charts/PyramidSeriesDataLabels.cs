// Type: Highsoft.Web.Mvc.Charts.PyramidSeriesDataLabels


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PyramidSeriesDataLabels : BaseObject
    {
        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

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

        public string ConnectorColor { get; set; }

        private string ConnectorColor_DefaultValue { get; set; }

        public double? ConnectorPadding { get; set; }

        private double? ConnectorPadding_DefaultValue { get; set; }

        public double? ConnectorWidth { get; set; }

        private double? ConnectorWidth_DefaultValue { get; set; }

        public bool? Crop { get; set; }

        private bool? Crop_DefaultValue { get; set; }

        public bool? Defer { get; set; }

        private bool? Defer_DefaultValue { get; set; }

        public double? Distance { get; set; }

        private double? Distance_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Format { get; set; }

        private string Format_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public bool? Inside { get; set; }

        private bool? Inside_DefaultValue { get; set; }

        public PyramidSeriesDataLabelsOverflow Overflow { get; set; }

        private PyramidSeriesDataLabelsOverflow Overflow_DefaultValue { get; set; }

        public double? Padding { get; set; }

        private double? Padding_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public string Shape { get; set; }

        private string Shape_DefaultValue { get; set; }

        public bool? SoftConnector { get; set; }

        private bool? SoftConnector_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public PyramidSeriesDataLabelsVerticalAlign VerticalAlign { get; set; }

        private PyramidSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public PyramidSeriesDataLabels()
        {
            this.BackgroundColor = this.BackgroundColor_DefaultValue = (string) null;
            this.BorderColor = this.BorderColor_DefaultValue = (string) null;
            double? nullable1 = new double?(0.0);
            this.BorderRadius_DefaultValue = nullable1;
            this.BorderRadius = nullable1;
            nullable1 = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable1;
            this.BorderWidth = nullable1;
            this.ClassName = this.ClassName_DefaultValue = (string) null;
            this.Color = this.Color_DefaultValue = (string) null;
            this.ConnectorColor = this.ConnectorColor_DefaultValue = "{point.color}";
            nullable1 = new double?(5.0);
            this.ConnectorPadding_DefaultValue = nullable1;
            this.ConnectorPadding = nullable1;
            nullable1 = new double?(1.0);
            this.ConnectorWidth_DefaultValue = nullable1;
            this.ConnectorWidth = nullable1;
            bool? nullable2 = new bool?(true);
            this.Crop_DefaultValue = nullable2;
            this.Crop = nullable2;
            nullable2 = new bool?(true);
            this.Defer_DefaultValue = nullable2;
            this.Defer = nullable2;
            nullable1 = new double?(30.0);
            this.Distance_DefaultValue = nullable1;
            this.Distance = nullable1;
            nullable2 = new bool?(true);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            this.Format = this.Format_DefaultValue = "{y}";
            this.Formatter = this.Formatter_DefaultValue = "";
            bool? nullable3 = new bool?();
            this.Inside_DefaultValue = nullable3;
            this.Inside = nullable3;
            this.Overflow = this.Overflow_DefaultValue = PyramidSeriesDataLabelsOverflow.Justify;
            nullable1 = new double?(5.0);
            this.Padding_DefaultValue = nullable1;
            this.Padding = nullable1;
            nullable1 = new double?(0.0);
            this.Rotation_DefaultValue = nullable1;
            this.Rotation = nullable1;
            Shadow shadow1 = new Shadow();
            shadow1.Enabled = false;
            Shadow shadow2 = shadow1;
            this.Shadow_DefaultValue = shadow1;
            this.Shadow = shadow2;
            this.Shape = this.Shape_DefaultValue = "square";
            nullable3 = new bool?(true);
            this.SoftConnector_DefaultValue = nullable3;
            this.SoftConnector = nullable3;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "contrast");
            hashtable1.Add((object) "fontSize", (object) "11px");
            hashtable1.Add((object) "fontWeight", (object) "bold");
            hashtable1.Add((object) "textShadow",
                (object) "1px 1px contrast},{ -1px -1px contrast},{ -1px 1px contrast},{ 1px -1px contrast");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            nullable3 = new bool?(false);
            this.UseHTML_DefaultValue = nullable3;
            this.UseHTML = nullable3;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = PyramidSeriesDataLabelsVerticalAlign.Null;
            nullable1 = new double?(0.0);
            this.X_DefaultValue = nullable1;
            this.X = nullable1;
            nullable1 = new double?(-6.0);
            this.Y_DefaultValue = nullable1;
            this.Y = nullable1;
            nullable1 = new double?(6.0);
            this.ZIndex_DefaultValue = nullable1;
            this.ZIndex = nullable1;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? borderRadius = this.BorderRadius;
            double? nullable1 = this.BorderRadius_DefaultValue;
            if ((borderRadius.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (borderRadius.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable1 = this.BorderWidth;
            double? nullable2 = this.BorderWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.ConnectorColor != this.ConnectorColor_DefaultValue)
                hashtable.Add((object) "connectorColor", (object) this.ConnectorColor);
            nullable2 = this.ConnectorPadding;
            nullable1 = this.ConnectorPadding_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "connectorPadding", (object) this.ConnectorPadding);
            nullable1 = this.ConnectorWidth;
            nullable2 = this.ConnectorWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "connectorWidth", (object) this.ConnectorWidth);
            bool? crop = this.Crop;
            bool? nullable3 = this.Crop_DefaultValue;
            if ((crop.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (crop.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "crop", (object) this.Crop);
            nullable3 = this.Defer;
            bool? nullable4 = this.Defer_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "defer", (object) this.Defer);
            nullable2 = this.Distance;
            nullable1 = this.Distance_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "distance", (object) this.Distance);
            nullable4 = this.Enabled;
            nullable3 = this.Enabled_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highcharts.AddFunction("PyramidSeriesDataLabelsFormatter.formatter", this.Formatter);
            }
            nullable3 = this.Inside;
            nullable4 = this.Inside_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "inside", (object) this.Inside);
            if (this.Overflow != this.Overflow_DefaultValue)
                hashtable.Add((object) "overflow", (object) Highcharts.FirstCharacterToLower(this.Overflow.ToString()));
            nullable1 = this.Padding;
            nullable2 = this.Padding_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "padding", (object) this.Padding);
            nullable2 = this.Rotation;
            nullable1 = this.Rotation_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            nullable4 = this.SoftConnector;
            nullable3 = this.SoftConnector_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "softConnector", (object) this.SoftConnector);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable3 = this.UseHTML;
            nullable4 = this.UseHTML_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable1 = this.X;
            nullable2 = this.X_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "x", (object) this.X);
            nullable2 = this.Y;
            nullable1 = this.Y_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "y", (object) this.Y);
            nullable1 = this.ZIndex;
            nullable2 = this.ZIndex_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
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