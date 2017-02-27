// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreaDataGrouping


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsAreaDataGrouping : BaseObject
    {
        public string Approximation { get; set; }

        private string Approximation_DefaultValue { get; set; }

        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? Forced { get; set; }

        private bool? Forced_DefaultValue { get; set; }

        public double? GroupPixelWidth { get; set; }

        private double? GroupPixelWidth_DefaultValue { get; set; }

        public bool? Smoothed { get; set; }

        private bool? Smoothed_DefaultValue { get; set; }

        public PlotOptionsAreaDataGrouping()
        {
            this.Approximation = this.Approximation_DefaultValue = "";
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            nullable1 = new bool?(false);
            this.Forced_DefaultValue = nullable1;
            this.Forced = nullable1;
            double? nullable2 = new double?(2.0);
            this.GroupPixelWidth_DefaultValue = nullable2;
            this.GroupPixelWidth = nullable2;
            nullable1 = new bool?(false);
            this.Smoothed_DefaultValue = nullable1;
            this.Smoothed = nullable1;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Approximation != this.Approximation_DefaultValue)
            {
                hashtable.Add((object) "approximation", (object) this.Approximation);
                Highstock.AddFunction("PlotOptionsAreaDataGroupingApproximation.approximation", this.Approximation);
            }
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            bool? nullable1 = this.Enabled;
            bool? nullable2 = this.Enabled_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable2 = this.Forced;
            nullable1 = this.Forced_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "forced", (object) this.Forced);
            double? groupPixelWidth = this.GroupPixelWidth;
            double? widthDefaultValue = this.GroupPixelWidth_DefaultValue;
            if (groupPixelWidth.GetValueOrDefault() != widthDefaultValue.GetValueOrDefault() ||
                groupPixelWidth.HasValue != widthDefaultValue.HasValue)
                hashtable.Add((object) "groupPixelWidth", (object) this.GroupPixelWidth);
            nullable1 = this.Smoothed;
            nullable2 = this.Smoothed_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "smoothed", (object) this.Smoothed);
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