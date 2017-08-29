// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsSeriesMarkerStatesSelect


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsSeriesMarkerStatesSelect : BaseObject
    {
        public PlotOptionsSeriesMarkerStatesSelect()
        {
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.FillColor = this.FillColor_DefaultValue = (object) null;
            this.LineColor = this.LineColor_DefaultValue = "#000000";
            double? nullable2 = new double?(0.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            double? nullable3 = new double?();
            this.Radius_DefaultValue = nullable3;
            this.Radius = nullable3;
        }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public object FillColor { get; set; }

        private object FillColor_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public double? Radius { get; set; }

        private double? Radius_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if (enabled.GetValueOrDefault() != enabledDefaultValue.GetValueOrDefault() ||
                enabled.HasValue != enabledDefaultValue.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.FillColor != this.FillColor_DefaultValue)
                hashtable.Add((object) "fillColor", this.FillColor);
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            double? nullable1 = this.LineWidth;
            double? nullable2 = this.LineWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            nullable2 = this.Radius;
            nullable1 = this.Radius_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "radius", (object) this.Radius);
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