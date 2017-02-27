// Type: Highsoft.Web.Mvc.Charts.GaugeSeriesPivot


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class GaugeSeriesPivot : BaseObject
    {
        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public double? Radius { get; set; }

        private double? Radius_DefaultValue { get; set; }

        public GaugeSeriesPivot()
        {
            this.BackgroundColor = this.BackgroundColor_DefaultValue = "#000000";
            this.BorderColor = this.BorderColor_DefaultValue = "#cccccc";
            double? nullable = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable;
            this.BorderWidth = nullable;
            nullable = new double?(5.0);
            this.Radius_DefaultValue = nullable;
            this.Radius = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? nullable1 = this.BorderWidth;
            double? nullable2 = this.BorderWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            nullable2 = this.Radius;
            nullable1 = this.Radius_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "radius", (object) this.Radius);
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