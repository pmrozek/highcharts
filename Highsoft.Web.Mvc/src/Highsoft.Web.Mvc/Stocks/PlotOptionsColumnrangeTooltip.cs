// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsColumnrangeTooltip


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsColumnrangeTooltip : BaseObject
    {
        public double? ChangeDecimals { get; set; }

        private double? ChangeDecimals_DefaultValue { get; set; }

        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public bool? FollowPointer { get; set; }

        private bool? FollowPointer_DefaultValue { get; set; }

        public bool? FollowTouchMove { get; set; }

        private bool? FollowTouchMove_DefaultValue { get; set; }

        public string HeaderFormat { get; set; }

        private string HeaderFormat_DefaultValue { get; set; }

        public double? Padding { get; set; }

        private double? Padding_DefaultValue { get; set; }

        public string PointFormat { get; set; }

        private string PointFormat_DefaultValue { get; set; }

        public string PointFormatter { get; set; }

        private string PointFormatter_DefaultValue { get; set; }

        public string Shape { get; set; }

        private string Shape_DefaultValue { get; set; }

        public bool? Split { get; set; }

        private bool? Split_DefaultValue { get; set; }

        public double? ValueDecimals { get; set; }

        private double? ValueDecimals_DefaultValue { get; set; }

        public string ValuePrefix { get; set; }

        private string ValuePrefix_DefaultValue { get; set; }

        public string ValueSuffix { get; set; }

        private string ValueSuffix_DefaultValue { get; set; }

        public string XDateFormat { get; set; }

        private string XDateFormat_DefaultValue { get; set; }

        public PlotOptionsColumnrangeTooltip()
        {
            double? nullable1 = new double?();
            this.ChangeDecimals_DefaultValue = nullable1;
            this.ChangeDecimals = nullable1;
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            bool? nullable2 = new bool?(false);
            this.FollowPointer_DefaultValue = nullable2;
            this.FollowPointer = nullable2;
            nullable2 = new bool?(true);
            this.FollowTouchMove_DefaultValue = nullable2;
            this.FollowTouchMove = nullable2;
            this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
            nullable1 = new double?(8.0);
            this.Padding_DefaultValue = nullable1;
            this.Padding = nullable1;
            this.PointFormat =
                this.PointFormat_DefaultValue =
                    "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
            this.PointFormatter = this.PointFormatter_DefaultValue = "";
            this.Shape = this.Shape_DefaultValue = "callout";
            nullable2 = new bool?(false);
            this.Split_DefaultValue = nullable2;
            this.Split = nullable2;
            double? nullable3 = new double?();
            this.ValueDecimals_DefaultValue = nullable3;
            this.ValueDecimals = nullable3;
            this.ValuePrefix = this.ValuePrefix_DefaultValue = (string) null;
            this.ValueSuffix = this.ValueSuffix_DefaultValue = (string) null;
            this.XDateFormat = this.XDateFormat_DefaultValue = "";
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            double? nullable1 = this.ChangeDecimals;
            double? nullable2 = this.ChangeDecimals_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "changeDecimals", (object) this.ChangeDecimals);
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            bool? nullable3 = this.FollowPointer;
            bool? nullable4 = this.FollowPointer_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "followPointer", (object) this.FollowPointer);
            nullable4 = this.FollowTouchMove;
            nullable3 = this.FollowTouchMove_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
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
                Highstock.AddFunction("PlotOptionsColumnrangeTooltipPointFormatter.pointFormatter", this.PointFormatter);
            }
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            nullable3 = this.Split;
            nullable4 = this.Split_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "split", (object) this.Split);
            nullable1 = this.ValueDecimals;
            nullable2 = this.ValueDecimals_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
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