// Type: Highsoft.Web.Mvc.Charts.Accessibility


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Accessibility : BaseObject
    {
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

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.DescribeSingleSeries;
            bool? nullable2 = this.DescribeSingleSeries_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "describeSingleSeries", (object) this.DescribeSingleSeries);
            nullable2 = this.Enabled;
            nullable1 = this.Enabled_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.KeyboardNavigation.IsDirty())
                hashtable.Add((object) "keyboardNavigation", (object) this.KeyboardNavigation.ToHashtable());
            if (this.OnTableAnchorClick != this.OnTableAnchorClick_DefaultValue)
            {
                hashtable.Add((object) "onTableAnchorClick", (object) this.OnTableAnchorClick);
                Highcharts.AddFunction("AccessibilityOnTableAnchorClick.onTableAnchorClick", this.OnTableAnchorClick);
            }
            if (this.PointDateFormat != this.PointDateFormat_DefaultValue)
                hashtable.Add((object) "pointDateFormat", (object) this.PointDateFormat);
            if (this.PointDateFormatter != this.PointDateFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointDateFormatter", (object) this.PointDateFormatter);
                Highcharts.AddFunction("AccessibilityPointDateFormatter.pointDateFormatter", this.PointDateFormatter);
            }
            if (this.PointDescriptionFormatter != this.PointDescriptionFormatter_DefaultValue)
            {
                hashtable.Add((object) "pointDescriptionFormatter", (object) this.PointDescriptionFormatter);
                Highcharts.AddFunction("AccessibilityPointDescriptionFormatter.pointDescriptionFormatter",
                    this.PointDescriptionFormatter);
            }
            long? descriptionThreshold = this.PointDescriptionThreshold;
            long? nullable3 = this.PointDescriptionThreshold_DefaultValue;
            if (descriptionThreshold.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                descriptionThreshold.HasValue != nullable3.HasValue)
            {
                nullable3 = this.PointDescriptionThreshold;
                if (nullable3.HasValue)
                    hashtable.Add((object) "pointDescriptionThreshold", (object) this.PointDescriptionThreshold);
                else
                    hashtable.Add((object) "pointDescriptionThreshold", (object) false);
            }
            if (this.ScreenReaderSectionFormatter != this.ScreenReaderSectionFormatter_DefaultValue)
            {
                hashtable.Add((object) "screenReaderSectionFormatter", (object) this.ScreenReaderSectionFormatter);
                Highcharts.AddFunction("AccessibilityScreenReaderSectionFormatter.screenReaderSectionFormatter",
                    this.ScreenReaderSectionFormatter);
            }
            if (this.SeriesDescriptionFormatter != this.SeriesDescriptionFormatter_DefaultValue)
            {
                hashtable.Add((object) "seriesDescriptionFormatter", (object) this.SeriesDescriptionFormatter);
                Highcharts.AddFunction("AccessibilitySeriesDescriptionFormatter.seriesDescriptionFormatter",
                    this.SeriesDescriptionFormatter);
            }
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