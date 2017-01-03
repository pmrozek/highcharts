// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsScatterMarkerStatesHover


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsScatterMarkerStatesHover : BaseObject
    {
        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string FillColor { get; set; }

        private string FillColor_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public double? LineWidthPlus { get; set; }

        private double? LineWidthPlus_DefaultValue { get; set; }

        public double? Radius { get; set; }

        private double? Radius_DefaultValue { get; set; }

        public double? RadiusPlus { get; set; }

        private double? RadiusPlus_DefaultValue { get; set; }

        public PlotOptionsScatterMarkerStatesHover()
        {
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.FillColor = this.FillColor_DefaultValue = "null";
            this.LineColor = this.LineColor_DefaultValue = "#ffffff";
            double? nullable2 = new double?(0.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            nullable2 = new double?(1.0);
            this.LineWidthPlus_DefaultValue = nullable2;
            this.LineWidthPlus = nullable2;
            double? nullable3 = new double?();
            this.Radius_DefaultValue = nullable3;
            this.Radius = nullable3;
            nullable3 = new double?(2.0);
            this.RadiusPlus_DefaultValue = nullable3;
            this.RadiusPlus = nullable3;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault()
                    ? (enabled.HasValue != enabledDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.FillColor != this.FillColor_DefaultValue)
                hashtable.Add((object) "fillColor", (object) this.FillColor);
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            double? lineWidth = this.LineWidth;
            double? nullable1 = this.LineWidth_DefaultValue;
            if ((lineWidth.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (lineWidth.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            nullable1 = this.LineWidthPlus;
            double? nullable2 = this.LineWidthPlus_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "lineWidthPlus", (object) this.LineWidthPlus);
            nullable2 = this.Radius;
            nullable1 = this.Radius_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "radius", (object) this.Radius);
            nullable1 = this.RadiusPlus;
            nullable2 = this.RadiusPlus_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "radiusPlus", (object) this.RadiusPlus);
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