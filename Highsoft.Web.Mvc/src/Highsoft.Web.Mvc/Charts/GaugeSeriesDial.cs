// Type: Highsoft.Web.Mvc.Charts.GaugeSeriesDial


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class GaugeSeriesDial : BaseObject
    {
        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BaseLength { get; set; }

        private string BaseLength_DefaultValue { get; set; }

        public double? BaseWidth { get; set; }

        private double? BaseWidth_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string Radius { get; set; }

        private string Radius_DefaultValue { get; set; }

        public string RearLength { get; set; }

        private string RearLength_DefaultValue { get; set; }

        public double? TopWidth { get; set; }

        private double? TopWidth_DefaultValue { get; set; }

        public GaugeSeriesDial()
        {
            this.BackgroundColor = this.BackgroundColor_DefaultValue = "#000000";
            this.BaseLength = this.BaseLength_DefaultValue = "70%";
            double? nullable = new double?(3.0);
            this.BaseWidth_DefaultValue = nullable;
            this.BaseWidth = nullable;
            this.BorderColor = this.BorderColor_DefaultValue = "#cccccc";
            nullable = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable;
            this.BorderWidth = nullable;
            this.Radius = this.Radius_DefaultValue = "80%";
            this.RearLength = this.RearLength_DefaultValue = "10%";
            nullable = new double?(1.0);
            this.TopWidth_DefaultValue = nullable;
            this.TopWidth = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BaseLength != this.BaseLength_DefaultValue)
                hashtable.Add((object) "baseLength", (object) this.BaseLength);
            double? nullable1 = this.BaseWidth;
            double? nullable2 = this.BaseWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "baseWidth", (object) this.BaseWidth);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            nullable2 = this.BorderWidth;
            nullable1 = this.BorderWidth_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.Radius != this.Radius_DefaultValue)
                hashtable.Add((object) "radius", (object) this.Radius);
            if (this.RearLength != this.RearLength_DefaultValue)
                hashtable.Add((object) "rearLength", (object) this.RearLength);
            nullable1 = this.TopWidth;
            nullable2 = this.TopWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "topWidth", (object) this.TopWidth);
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