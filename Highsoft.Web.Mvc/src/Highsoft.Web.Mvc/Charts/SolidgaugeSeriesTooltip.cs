// Type: Highsoft.Web.Mvc.Charts.SolidgaugeSeriesTooltip


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class SolidgaugeSeriesTooltip : BaseObject
    {
        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public bool? FollowPointer { get; set; }

        private bool? FollowPointer_DefaultValue { get; set; }

        public bool? FollowTouchMove { get; set; }

        private bool? FollowTouchMove_DefaultValue { get; set; }

        public string FooterFormat { get; set; }

        private string FooterFormat_DefaultValue { get; set; }

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

        public SolidgaugeSeriesTooltip()
        {
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            bool? nullable1 = new bool?(false);
            this.FollowPointer_DefaultValue = nullable1;
            this.FollowPointer = nullable1;
            nullable1 = new bool?(true);
            this.FollowTouchMove_DefaultValue = nullable1;
            this.FollowTouchMove = nullable1;
            this.FooterFormat = this.FooterFormat_DefaultValue = "false";
            this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
            double? nullable2 = new double?(500.0);
            this.HideDelay_DefaultValue = nullable2;
            this.HideDelay = nullable2;
            nullable2 = new double?(8.0);
            this.Padding_DefaultValue = nullable2;
            this.Padding = nullable2;
            this.PointFormat =
                this.PointFormat_DefaultValue =
                    "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
            this.PointFormatter = this.PointFormatter_DefaultValue = "";
            nullable1 = new bool?(false);
            this.Split_DefaultValue = nullable1;
            this.Split = nullable1;
            double? nullable3 = new double?();
            this.ValueDecimals_DefaultValue = nullable3;
            this.ValueDecimals = nullable3;
            this.ValuePrefix = this.ValuePrefix_DefaultValue = (string) null;
            this.ValueSuffix = this.ValueSuffix_DefaultValue = (string) null;
            this.XDateFormat = this.XDateFormat_DefaultValue = (string) null;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            bool? nullable1 = this.FollowPointer;
            bool? nullable2 = this.FollowPointer_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "followPointer", (object) this.FollowPointer);
            nullable2 = this.FollowTouchMove;
            nullable1 = this.FollowTouchMove_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
            if (this.FooterFormat != this.FooterFormat_DefaultValue)
                hashtable.Add((object) "footerFormat", (object) this.FooterFormat);
            if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
                hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
            double? nullable3 = this.HideDelay;
            double? nullable4 = this.HideDelay_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "hideDelay", (object) this.HideDelay);
            nullable4 = this.Padding;
            nullable3 = this.Padding_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "padding", (object) this.Padding);
            if (this.PointFormat != this.PointFormat_DefaultValue)
                hashtable.Add((object) "pointFormat", (object) this.PointFormat);
            if (this.PointFormatter != this.PointFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
                Highcharts.AddFunction("SolidgaugeSeriesTooltipPointFormatter.pointFormatter", this.PointFormatter);
            }
            nullable1 = this.Split;
            nullable2 = this.Split_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "split", (object) this.Split);
            nullable3 = this.ValueDecimals;
            nullable4 = this.ValueDecimals_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
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