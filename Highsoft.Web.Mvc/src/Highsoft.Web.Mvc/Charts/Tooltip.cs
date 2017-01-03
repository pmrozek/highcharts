// Type: Highsoft.Web.Mvc.Charts.Tooltip


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Tooltip : BaseObject
    {
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

        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? FollowPointer { get; set; }

        private bool? FollowPointer_DefaultValue { get; set; }

        public bool? FollowTouchMove { get; set; }

        private bool? FollowTouchMove_DefaultValue { get; set; }

        public string FooterFormat { get; set; }

        private string FooterFormat_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public string HeaderFormat { get; set; }

        private string HeaderFormat_DefaultValue { get; set; }

        public double? HideDelay { get; set; }

        private double? HideDelay_DefaultValue { get; set; }

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

        public Tooltip()
        {
            Animation animation1 = new Animation();
            animation1.Enabled = true;
            Animation animation2 = animation1;
            this.Animation_DefaultValue = animation1;
            this.Animation = animation2;
            this.BackgroundColor = this.BackgroundColor_DefaultValue = "rgba(247,247,247,0.85)";
            this.BorderColor = this.BorderColor_DefaultValue = "null";
            double? nullable1 = new double?(3.0);
            this.BorderRadius_DefaultValue = nullable1;
            this.BorderRadius = nullable1;
            nullable1 = new double?(1.0);
            this.BorderWidth_DefaultValue = nullable1;
            this.BorderWidth = nullable1;
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            bool? nullable2 = new bool?(true);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            nullable2 = new bool?(false);
            this.FollowPointer_DefaultValue = nullable2;
            this.FollowPointer = nullable2;
            nullable2 = new bool?(true);
            this.FollowTouchMove_DefaultValue = nullable2;
            this.FollowTouchMove = nullable2;
            this.FooterFormat = this.FooterFormat_DefaultValue = "false";
            this.Formatter = this.Formatter_DefaultValue = "";
            this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
            nullable1 = new double?(500.0);
            this.HideDelay_DefaultValue = nullable1;
            this.HideDelay = nullable1;
            nullable1 = new double?(8.0);
            this.Padding_DefaultValue = nullable1;
            this.Padding = nullable1;
            this.PointFormat =
                this.PointFormat_DefaultValue =
                    "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
            this.PointFormatter = this.PointFormatter_DefaultValue = "";
            this.Positioner = this.Positioner_DefaultValue = "";
            Shadow shadow1 = new Shadow();
            shadow1.Enabled = false;
            Shadow shadow2 = shadow1;
            this.Shadow_DefaultValue = shadow1;
            this.Shadow = shadow2;
            this.Shape = this.Shape_DefaultValue = "callout";
            nullable2 = new bool?(false);
            this.Shared_DefaultValue = nullable2;
            this.Shared = nullable2;
            double? nullable3 = new double?();
            this.Snap_DefaultValue = nullable3;
            this.Snap = nullable3;
            nullable2 = new bool?(false);
            this.Split_DefaultValue = nullable2;
            this.Split = nullable2;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "#333333");
            hashtable1.Add((object) "cursor", (object) "default");
            hashtable1.Add((object) "fontSize", (object) "12px");
            hashtable1.Add((object) "pointerEvents", (object) "none");
            hashtable1.Add((object) "whiteSpace", (object) "nowrap");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            nullable2 = new bool?(false);
            this.UseHTML_DefaultValue = nullable2;
            this.UseHTML = nullable2;
            double? nullable4 = new double?();
            this.ValueDecimals_DefaultValue = nullable4;
            this.ValueDecimals = nullable4;
            this.ValuePrefix = this.ValuePrefix_DefaultValue = (string) null;
            this.ValueSuffix = this.ValueSuffix_DefaultValue = (string) null;
            this.XDateFormat = this.XDateFormat_DefaultValue = (string) null;
        }

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
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable2 = this.BorderWidth;
            nullable1 = this.BorderWidth_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            bool? nullable3 = this.Enabled;
            bool? nullable4 = this.Enabled_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable4 = this.FollowPointer;
            nullable3 = this.FollowPointer_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "followPointer", (object) this.FollowPointer);
            nullable3 = this.FollowTouchMove;
            nullable4 = this.FollowTouchMove_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
            if (this.FooterFormat != this.FooterFormat_DefaultValue)
                hashtable.Add((object) "footerFormat", (object) this.FooterFormat);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highcharts.AddFunction("TooltipFormatter.formatter", this.Formatter);
            }
            if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
                hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
            nullable1 = this.HideDelay;
            nullable2 = this.HideDelay_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "hideDelay", (object) this.HideDelay);
            nullable2 = this.Padding;
            nullable1 = this.Padding_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "padding", (object) this.Padding);
            if (this.PointFormat != this.PointFormat_DefaultValue)
                hashtable.Add((object) "pointFormat", (object) this.PointFormat);
            if (this.PointFormatter != this.PointFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
                Highcharts.AddFunction("TooltipPointFormatter.pointFormatter", this.PointFormatter);
            }
            if (this.Positioner != this.Positioner_DefaultValue)
            {
                hashtable.Add((object) "positioner", (object) this.Positioner);
                Highcharts.AddFunction("TooltipPositioner.positioner", this.Positioner);
            }
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            nullable4 = this.Shared;
            nullable3 = this.Shared_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "shared", (object) this.Shared);
            nullable1 = this.Snap;
            nullable2 = this.Snap_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "snap", (object) this.Snap);
            nullable3 = this.Split;
            nullable4 = this.Split_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "split", (object) this.Split);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable4 = this.UseHTML;
            nullable3 = this.UseHTML_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            nullable2 = this.ValueDecimals;
            nullable1 = this.ValueDecimals_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
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