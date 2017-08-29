// Type: Highsoft.Web.Mvc.Stocks.Global


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Global : BaseObject
    {
        public Global()
        {
            this.VMLRadialGradientURL = this.VMLRadialGradientURL_DefaultValue =
                "http://code.highcharts.com/highstock/{version}/gfx/vml-radial-gradient.png";
            this.GetTimezoneOffset = this.GetTimezoneOffset_DefaultValue = "";
            this.Timezone = this.Timezone_DefaultValue = "undefined";
            double? nullable1 = new double?(0.0);
            this.TimezoneOffset_DefaultValue = nullable1;
            this.TimezoneOffset = nullable1;
            bool? nullable2 = new bool?(true);
            this.UseUTC_DefaultValue = nullable2;
            this.UseUTC = nullable2;
        }

        public string VMLRadialGradientURL { get; set; }

        private string VMLRadialGradientURL_DefaultValue { get; set; }

        public string GetTimezoneOffset { get; set; }

        private string GetTimezoneOffset_DefaultValue { get; set; }

        public string Timezone { get; set; }

        private string Timezone_DefaultValue { get; set; }

        public double? TimezoneOffset { get; set; }

        private double? TimezoneOffset_DefaultValue { get; set; }

        public bool? UseUTC { get; set; }

        private bool? UseUTC_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.VMLRadialGradientURL != this.VMLRadialGradientURL_DefaultValue)
                hashtable.Add((object) "vMLRadialGradientURL", (object) this.VMLRadialGradientURL);
            if (this.GetTimezoneOffset != this.GetTimezoneOffset_DefaultValue)
            {
                hashtable.Add((object) "getTimezoneOffset", (object) this.GetTimezoneOffset);
                Highstock.AddFunction("GlobalGetTimezoneOffset.getTimezoneOffset", this.GetTimezoneOffset);
            }
            if (this.Timezone != this.Timezone_DefaultValue)
                hashtable.Add((object) "timezone", (object) this.Timezone);
            double? timezoneOffset = this.TimezoneOffset;
            double? offsetDefaultValue = this.TimezoneOffset_DefaultValue;
            if (timezoneOffset.GetValueOrDefault() != offsetDefaultValue.GetValueOrDefault() ||
                timezoneOffset.HasValue != offsetDefaultValue.HasValue)
                hashtable.Add((object) "timezoneOffset", (object) this.TimezoneOffset);
            bool? useUtc = this.UseUTC;
            bool? useUtcDefaultValue = this.UseUTC_DefaultValue;
            if (useUtc.GetValueOrDefault() != useUtcDefaultValue.GetValueOrDefault() ||
                useUtc.HasValue != useUtcDefaultValue.HasValue)
                hashtable.Add((object) "useUTC", (object) this.UseUTC);
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