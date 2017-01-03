// Type: Highsoft.Web.Mvc.Stocks.Accessibility


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Accessibility : BaseObject
    {
        public bool? DescribeSingleSeries { get; set; }

        private bool? DescribeSingleSeries_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public AccessibilityKeyboardNavigation KeyboardNavigation { get; set; }

        private AccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }

        public string OnTableAnchorClick { get; set; }

        private string OnTableAnchorClick_DefaultValue { get; set; }

        public string PointDateFormat { get; set; }

        private string PointDateFormat_DefaultValue { get; set; }

        public string PointDateFormatter { get; set; }

        private string PointDateFormatter_DefaultValue { get; set; }

        public string PointDescriptionFormatter { get; set; }

        private string PointDescriptionFormatter_DefaultValue { get; set; }

        public long? PointDescriptionThreshold { get; set; }

        private long? PointDescriptionThreshold_DefaultValue { get; set; }

        public string ScreenReaderSectionFormatter { get; set; }

        private string ScreenReaderSectionFormatter_DefaultValue { get; set; }

        public string SeriesDescriptionFormatter { get; set; }

        private string SeriesDescriptionFormatter_DefaultValue { get; set; }

        public Accessibility()
        {
            bool? nullable1 = new bool?(false);
            this.DescribeSingleSeries_DefaultValue = nullable1;
            this.DescribeSingleSeries = nullable1;
            nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.KeyboardNavigation = this.KeyboardNavigation_DefaultValue = new AccessibilityKeyboardNavigation();
            this.OnTableAnchorClick = this.OnTableAnchorClick_DefaultValue = "";
            this.PointDateFormat = this.PointDateFormat_DefaultValue = (string) null;
            this.PointDateFormatter = this.PointDateFormatter_DefaultValue = "";
            this.PointDescriptionFormatter = this.PointDescriptionFormatter_DefaultValue = "";
            long? nullable2 = new long?(30L);
            this.PointDescriptionThreshold_DefaultValue = nullable2;
            this.PointDescriptionThreshold = nullable2;
            this.ScreenReaderSectionFormatter = this.ScreenReaderSectionFormatter_DefaultValue = "";
            this.SeriesDescriptionFormatter = this.SeriesDescriptionFormatter_DefaultValue = "";
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? describeSingleSeries = this.DescribeSingleSeries;
            bool? seriesDefaultValue = this.DescribeSingleSeries_DefaultValue;
            if ((describeSingleSeries.GetValueOrDefault() == seriesDefaultValue.GetValueOrDefault()
                    ? (describeSingleSeries.HasValue != seriesDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "describeSingleSeries", (object) this.DescribeSingleSeries);
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault()
                    ? (enabled.HasValue != enabledDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.KeyboardNavigation.IsDirty())
                hashtable.Add((object) "keyboardNavigation", (object) this.KeyboardNavigation.ToHashtable());
            if (this.OnTableAnchorClick != this.OnTableAnchorClick_DefaultValue)
            {
                hashtable.Add((object) "onTableAnchorClick", (object) this.OnTableAnchorClick);
                Highstock.AddFunction("AccessibilityOnTableAnchorClick.onTableAnchorClick", this.OnTableAnchorClick);
            }
            if (this.PointDateFormat != this.PointDateFormat_DefaultValue)
                hashtable.Add((object) "pointDateFormat", (object) this.PointDateFormat);
            if (this.PointDateFormatter != this.PointDateFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointDateFormatter", (object) this.PointDateFormatter);
                Highstock.AddFunction("AccessibilityPointDateFormatter.pointDateFormatter", this.PointDateFormatter);
            }
            if (this.PointDescriptionFormatter != this.PointDescriptionFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointDescriptionFormatter", (object) this.PointDescriptionFormatter);
                Highstock.AddFunction("AccessibilityPointDescriptionFormatter.pointDescriptionFormatter",
                    this.PointDescriptionFormatter);
            }
            long? descriptionThreshold = this.PointDescriptionThreshold;
            long? nullable = this.PointDescriptionThreshold_DefaultValue;
            if ((descriptionThreshold.GetValueOrDefault() == nullable.GetValueOrDefault()
                    ? (descriptionThreshold.HasValue != nullable.HasValue ? 1 : 0)
                    : 1) != 0)
            {
                nullable = this.PointDescriptionThreshold;
                if (nullable.HasValue)
                    hashtable.Add((object) "pointDescriptionThreshold", (object) this.PointDescriptionThreshold);
                else
                    hashtable.Add((object) "pointDescriptionThreshold", (object) false);
            }
            if (this.ScreenReaderSectionFormatter != this.ScreenReaderSectionFormatter_DefaultValue)
            {
                hashtable.Add((object) "screenReaderSectionFormatter", (object) this.ScreenReaderSectionFormatter);
                Highstock.AddFunction("AccessibilityScreenReaderSectionFormatter.screenReaderSectionFormatter",
                    this.ScreenReaderSectionFormatter);
            }
            if (this.SeriesDescriptionFormatter != this.SeriesDescriptionFormatter_DefaultValue)
            {
                hashtable.Add((object) "seriesDescriptionFormatter", (object) this.SeriesDescriptionFormatter);
                Highstock.AddFunction("AccessibilitySeriesDescriptionFormatter.seriesDescriptionFormatter",
                    this.SeriesDescriptionFormatter);
            }
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