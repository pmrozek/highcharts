// Type: Highsoft.Web.Mvc.Charts.Global


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Global : BaseObject
    {
        public string VMLRadialGradientURL { get; set; }

        private string VMLRadialGradientURL_DefaultValue { get; set; }

        public string GetTimezoneOffset { get; set; }

        private string GetTimezoneOffset_DefaultValue { get; set; }

        public double? TimezoneOffset { get; set; }

        private double? TimezoneOffset_DefaultValue { get; set; }

        public bool? UseUTC { get; set; }

        private bool? UseUTC_DefaultValue { get; set; }

        public Global()
        {
            this.VMLRadialGradientURL =
                this.VMLRadialGradientURL_DefaultValue =
                    "http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png";
            this.GetTimezoneOffset = this.GetTimezoneOffset_DefaultValue = "";
            double? nullable1 = new double?(0.0);
            this.TimezoneOffset_DefaultValue = nullable1;
            this.TimezoneOffset = nullable1;
            bool? nullable2 = new bool?(true);
            this.UseUTC_DefaultValue = nullable2;
            this.UseUTC = nullable2;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.VMLRadialGradientURL != this.VMLRadialGradientURL_DefaultValue)
                hashtable.Add((object) "vMLRadialGradientURL", (object) this.VMLRadialGradientURL);
            if (this.GetTimezoneOffset != this.GetTimezoneOffset_DefaultValue)
            {
                hashtable.Add((object) "getTimezoneOffset", (object) this.GetTimezoneOffset);
                Highcharts.AddFunction("GlobalGetTimezoneOffset.getTimezoneOffset", this.GetTimezoneOffset);
            }
            double? timezoneOffset = this.TimezoneOffset;
            double? offsetDefaultValue = this.TimezoneOffset_DefaultValue;
            if ((timezoneOffset.GetValueOrDefault() == offsetDefaultValue.GetValueOrDefault()
                    ? (timezoneOffset.HasValue != offsetDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "timezoneOffset", (object) this.TimezoneOffset);
            bool? useUtc = this.UseUTC;
            bool? useUtcDefaultValue = this.UseUTC_DefaultValue;
            if ((useUtc.GetValueOrDefault() == useUtcDefaultValue.GetValueOrDefault()
                    ? (useUtc.HasValue != useUtcDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "useUTC", (object) this.UseUTC);
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