// Type: Highsoft.Web.Mvc.Stocks.CreditsPosition


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class CreditsPosition : BaseObject
    {
        public CreditsPositionAlign Align { get; set; }

        private CreditsPositionAlign Align_DefaultValue { get; set; }

        public CreditsPositionVerticalAlign VerticalAlign { get; set; }

        private CreditsPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public CreditsPosition()
        {
            this.Align = this.Align_DefaultValue = CreditsPositionAlign.Right;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = CreditsPositionVerticalAlign.Bottom;
            double? nullable = new double?(-10.0);
            this.X_DefaultValue = nullable;
            this.X = nullable;
            nullable = new double?(-5.0);
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
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable2 = this.Y;
            nullable1 = this.Y_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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