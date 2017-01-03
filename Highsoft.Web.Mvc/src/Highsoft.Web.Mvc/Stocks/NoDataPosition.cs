// Type: Highsoft.Web.Mvc.Stocks.NoDataPosition


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class NoDataPosition : BaseObject
    {
        public NoDataPositionAlign Align { get; set; }

        private NoDataPositionAlign Align_DefaultValue { get; set; }

        public NoDataPositionVerticalAlign VerticalAlign { get; set; }

        private NoDataPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public NoDataPosition()
        {
            this.Align = this.Align_DefaultValue = NoDataPositionAlign.Center;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = NoDataPositionVerticalAlign.Middle;
            double? nullable = new double?(0.0);
            this.X_DefaultValue = nullable;
            this.X = nullable;
            nullable = new double?(0.0);
            this.Y_DefaultValue = nullable;
            this.Y = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highstock.FirstCharacterToLower(this.VerticalAlign.ToString()));
            double? nullable1 = this.X;
            double? nullable2 = this.X_DefaultValue;
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