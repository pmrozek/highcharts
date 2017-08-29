// Type: Highsoft.Web.Mvc.Stocks.FlagsSeriesTooltip


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class FlagsSeriesTooltip : BaseObject
    {
        public FlagsSeriesTooltip()
        {
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            bool? nullable1 = new bool?(false);
            this.FollowPointer_DefaultValue = nullable1;
            this.FollowPointer = nullable1;
            nullable1 = new bool?(true);
            this.FollowTouchMove_DefaultValue = nullable1;
            this.FollowTouchMove = nullable1;
            this.HeaderFormat = this.HeaderFormat_DefaultValue = "";
            double? nullable2 = new double?(8.0);
            this.Padding_DefaultValue = nullable2;
            this.Padding = nullable2;
            this.PointFormat = this.PointFormat_DefaultValue =
                "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
            this.PointFormatter = this.PointFormatter_DefaultValue = "";
            this.Shape = this.Shape_DefaultValue = "callout";
            nullable1 = new bool?(false);
            this.Split_DefaultValue = nullable1;
            this.Split = nullable1;
            this.XDateFormat = this.XDateFormat_DefaultValue = "";
        }

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

        public string XDateFormat { get; set; }

        private string XDateFormat_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            bool? nullable1 = this.FollowPointer;
            bool? nullable2 = this.FollowPointer_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "followPointer", (object) this.FollowPointer);
            nullable2 = this.FollowTouchMove;
            nullable1 = this.FollowTouchMove_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "followTouchMove", (object) this.FollowTouchMove);
            if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
                hashtable.Add((object) "headerFormat", (object) this.HeaderFormat);
            double? padding = this.Padding;
            double? paddingDefaultValue = this.Padding_DefaultValue;
            if (padding.GetValueOrDefault() != paddingDefaultValue.GetValueOrDefault() ||
                padding.HasValue != paddingDefaultValue.HasValue)
                hashtable.Add((object) "padding", (object) this.Padding);
            if (this.PointFormat != this.PointFormat_DefaultValue)
                hashtable.Add((object) "pointFormat", (object) this.PointFormat);
            if (this.PointFormatter != this.PointFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointFormatter", (object) this.PointFormatter);
                Highstock.AddFunction("FlagsSeriesTooltipPointFormatter.pointFormatter", this.PointFormatter);
            }
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) this.Shape);
            nullable1 = this.Split;
            nullable2 = this.Split_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "split", (object) this.Split);
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