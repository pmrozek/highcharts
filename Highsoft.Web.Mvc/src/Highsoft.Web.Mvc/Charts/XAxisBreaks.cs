// Type: Highsoft.Web.Mvc.Charts.XAxisBreaks


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class XAxisBreaks : BaseObject
    {
        public XAxisBreaks()
        {
            double? nullable1 = new double?(0.0);
            this.BreakSize_DefaultValue = nullable1;
            this.BreakSize = nullable1;
            double? nullable2 = new double?();
            this.From_DefaultValue = nullable2;
            this.From = nullable2;
            nullable2 = new double?(0.0);
            this.Repeat_DefaultValue = nullable2;
            this.Repeat = nullable2;
            double? nullable3 = new double?();
            this.To_DefaultValue = nullable3;
            this.To = nullable3;
        }

        public double? BreakSize { get; set; }

        private double? BreakSize_DefaultValue { get; set; }

        public double? From { get; set; }

        private double? From_DefaultValue { get; set; }

        public double? Repeat { get; set; }

        private double? Repeat_DefaultValue { get; set; }

        public double? To { get; set; }

        private double? To_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            double? nullable1 = this.BreakSize;
            double? nullable2 = this.BreakSize_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "breakSize", (object) this.BreakSize);
            nullable2 = this.From;
            nullable1 = this.From_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "from", (object) this.From);
            nullable1 = this.Repeat;
            nullable2 = this.Repeat_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "repeat", (object) this.Repeat);
            nullable2 = this.To;
            nullable1 = this.To_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "to", (object) this.To);
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