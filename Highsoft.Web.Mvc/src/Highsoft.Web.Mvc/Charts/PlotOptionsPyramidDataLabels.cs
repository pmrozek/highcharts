// Type: Highsoft.Web.Mvc.Charts.PlotOptionsPyramidDataLabels


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsPyramidDataLabels : BaseObject
    {
        public PlotOptionsPyramidDataLabels()
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
            this.Overflow = this.Overflow_DefaultValue = PlotOptionsPyramidDataLabelsOverflow.Justify;
            nullable1 = new double?(5.0);
            this.Padding_DefaultValue = nullable1;
            this.Padding = nullable1;
            nullable1 = new double?(0.0);
            this.Rotation_DefaultValue = nullable1;
            this.Rotation = nullable1;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            this.Shape = this.Shape_DefaultValue = "square";
            nullable3 = new bool?(true);
            this.SoftConnector_DefaultValue = nullable3;
            this.SoftConnector = nullable3;
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
            this.VerticalAlign = this.VerticalAlign_DefaultValue = PlotOptionsPyramidDataLabelsVerticalAlign.Null;
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

        public PlotOptionsPyramidDataLabelsOverflow Overflow { get; set; }

        private PlotOptionsPyramidDataLabelsOverflow Overflow_DefaultValue { get; set; }

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

        public PlotOptionsPyramidDataLabelsVerticalAlign VerticalAlign { get; set; }

        private PlotOptionsPyramidDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
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
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.ConnectorColor != this.ConnectorColor_DefaultValue)
                hashtable.Add((object) "connectorColor", (object) this.ConnectorColor);
            nullable1 = this.ConnectorPadding;
            nullable2 = this.ConnectorPadding_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "connectorPadding", (object) this.ConnectorPadding);
            nullable2 = this.ConnectorWidth;
            nullable1 = this.ConnectorWidth_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "connectorWidth", (object) this.ConnectorWidth);
            bool? nullable3 = this.Crop;
            bool? nullable4 = this.Crop_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "crop", (object) this.Crop);
            nullable4 = this.Defer;
            nullable3 = this.Defer_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "defer", (object) this.Defer);
            nullable1 = this.Distance;
            nullable2 = this.Distance_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "distance", (object) this.Distance);
            nullable3 = this.Enabled;
            nullable4 = this.Enabled_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highcharts.AddFunction("PlotOptionsPyramidDataLabelsFormatter.formatter", this.Formatter);
            }
            nullable4 = this.Inside;
            nullable3 = this.Inside_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "inside", (object) this.Inside);
            if (this.Overflow != this.Overflow_DefaultValue)
                hashtable.Add((object) "overflow", (object) Highcharts.FirstCharacterToLower(this.Overflow.ToString()));
            nullable2 = this.Padding;
            nullable1 = this.Padding_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "padding", (object) this.Padding);
            nullable1 = this.Rotation;
            nullable2 = this.Rotation_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Shadow.IsDirty())
                hashtable.Add((object) "shadow", (object) this.Shadow.ToHashtable());
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            nullable3 = this.SoftConnector;
            nullable4 = this.SoftConnector_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "softConnector", (object) this.SoftConnector);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable4 = this.UseHTML;
            nullable3 = this.UseHTML_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable2 = this.X;
            nullable1 = this.X_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable1 = this.Y;
            nullable2 = this.Y_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
            nullable2 = this.ZIndex;
            nullable1 = this.ZIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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