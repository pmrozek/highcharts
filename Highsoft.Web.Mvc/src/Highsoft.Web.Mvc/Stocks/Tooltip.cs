// Type: Highsoft.Web.Mvc.Stocks.Tooltip


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Tooltip : BaseObject
    {
        public Tooltip()
        {
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            this.BackgroundColor = this.BackgroundColor_DefaultValue = "rgba(247,247,247,0.85)";
            this.BorderColor = this.BorderColor_DefaultValue = "null";
            double? nullable1 = new double?(3.0);
            this.BorderRadius_DefaultValue = nullable1;
            this.BorderRadius = nullable1;
            nullable1 = new double?(1.0);
            this.BorderWidth_DefaultValue = nullable1;
            this.BorderWidth = nullable1;
            double? nullable2 = new double?();
            this.ChangeDecimals_DefaultValue = nullable2;
            this.ChangeDecimals = nullable2;
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            bool? nullable3 = new bool?(true);
            this.Enabled_DefaultValue = nullable3;
            this.Enabled = nullable3;
            nullable3 = new bool?(false);
            this.FollowPointer_DefaultValue = nullable3;
            this.FollowPointer = nullable3;
            nullable3 = new bool?(true);
            this.FollowTouchMove_DefaultValue = nullable3;
            this.FollowTouchMove = nullable3;
            this.Formatter = this.Formatter_DefaultValue = "";
            this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
            nullable2 = new double?(8.0);
            this.Padding_DefaultValue = nullable2;
            this.Padding = nullable2;
            this.PointFormat = this.PointFormat_DefaultValue =
                "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
            this.PointFormatter = this.PointFormatter_DefaultValue = "";
            this.Positioner = this.Positioner_DefaultValue = "";
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            this.Shape = this.Shape_DefaultValue = "callout";
            nullable3 = new bool?(true);
            this.Shared_DefaultValue = nullable3;
            this.Shared = nullable3;
            nullable2 = new double?(0.0);
            this.Snap_DefaultValue = nullable2;
            this.Snap = nullable2;
            nullable3 = new bool?(false);
            this.Split_DefaultValue = nullable3;
            this.Split = nullable3;
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#333333"
                },
                {
                    (object) "cursor",
                    (object) "default"
                },
                {
                    (object) "fontSize",
                    (object) "12px"
                },
                {
                    (object) "pointerEvents",
                    (object) "none"
                },
                {
                    (object) "whiteSpace",
                    (object) "nowrap"
                }
            };
            nullable3 = new bool?(false);
            this.UseHTML_DefaultValue = nullable3;
            this.UseHTML = nullable3;
            double? nullable4 = new double?();
            this.ValueDecimals_DefaultValue = nullable4;
            this.ValueDecimals = nullable4;
            this.ValuePrefix = this.ValuePrefix_DefaultValue = (string) null;
            this.ValueSuffix = this.ValueSuffix_DefaultValue = (string) null;
            this.XDateFormat = this.XDateFormat_DefaultValue = "";
        }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderRadius { get; set; }

        private double? BorderRadius_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public double? ChangeDecimals { get; set; }

        private double? ChangeDecimals_DefaultValue { get; set; }

        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? FollowPointer { get; set; }

        private bool? FollowPointer_DefaultValue { get; set; }

        public bool? FollowTouchMove { get; set; }

        private bool? FollowTouchMove_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public string HeaderFormat { get; set; }

        private string HeaderFormat_DefaultValue { get; set; }

        public double? Padding { get; set; }

        private double? Padding_DefaultValue { get; set; }

        public string PointFormat { get; set; }

        private string PointFormat_DefaultValue { get; set; }

        public string PointFormatter { get; set; }

        private string PointFormatter_DefaultValue { get; set; }

        public string Positioner { get; set; }

        private string Positioner_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public string Shape { get; set; }

        private string Shape_DefaultValue { get; set; }

        public bool? Shared { get; set; }

        private bool? Shared_DefaultValue { get; set; }

        public double? Snap { get; set; }

        private double? Snap_DefaultValue { get; set; }

        public bool? Split { get; set; }

        private bool? Split_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public double? ValueDecimals { get; set; }

        private double? ValueDecimals_DefaultValue { get; set; }

        public string ValuePrefix { get; set; }

        private string ValuePrefix_DefaultValue { get; set; }

        public string ValueSuffix { get; set; }

        private string ValueSuffix_DefaultValue { get; set; }

        public string XDateFormat { get; set; }

        private string XDateFormat_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
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
            nullable1 = this.ChangeDecimals;
            nullable2 = this.ChangeDecimals_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "changeDecimals", (object) this.ChangeDecimals);
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            bool? nullable3 = this.Enabled;
            bool? nullable4 = this.Enabled_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable4 = this.FollowPointer;
            nullable3 = this.FollowPointer_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "followPointer", (object) this.FollowPointer);
            nullable3 = this.FollowTouchMove;
            nullable4 = this.FollowTouchMove_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highstock.AddFunction("TooltipFormatter.formatter", this.Formatter);
            }
            if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
                hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
            nullable2 = this.Padding;
            nullable1 = this.Padding_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "padding", (object) this.Padding);
            if (this.PointFormat != this.PointFormat_DefaultValue)
                hashtable.Add((object) "pointFormat", (object) this.PointFormat);
            if (this.PointFormatter != this.PointFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
                Highstock.AddFunction("TooltipPointFormatter.pointFormatter", this.PointFormatter);
            }
            if (this.Positioner != this.Positioner_DefaultValue)
            {
                hashtable.Add((object) "positioner", (object) this.Positioner);
                Highstock.AddFunction("TooltipPositioner.positioner", this.Positioner);
            }
            if (this.Shadow.IsDirty())
                hashtable.Add((object) "shadow", (object) this.Shadow.ToHashtable());
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            nullable4 = this.Shared;
            nullable3 = this.Shared_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "shared", (object) this.Shared);
            nullable1 = this.Snap;
            nullable2 = this.Snap_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "snap", (object) this.Snap);
            nullable3 = this.Split;
            nullable4 = this.Split_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "split", (object) this.Split);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable4 = this.UseHTML;
            nullable3 = this.UseHTML_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            nullable2 = this.ValueDecimals;
            nullable1 = this.ValueDecimals_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "valueDecimals", (object) this.ValueDecimals);
            if (this.ValuePrefix != this.ValuePrefix_DefaultValue)
                hashtable.Add((object) "valuePrefix", (object) this.ValuePrefix);
            if (this.ValueSuffix != this.ValueSuffix_DefaultValue)
                hashtable.Add((object) "valueSuffix", (object) this.ValueSuffix);
            if (this.XDateFormat != this.XDateFormat_DefaultValue)
                hashtable.Add((object) "xDateFormat", (object) this.XDateFormat);
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