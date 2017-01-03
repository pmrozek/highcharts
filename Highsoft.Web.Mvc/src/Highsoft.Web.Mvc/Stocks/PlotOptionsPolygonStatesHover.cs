// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsPolygonStatesHover


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsPolygonStatesHover : BaseObject
    {
        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public PlotOptionsPolygonStatesHoverHalo Halo { get; set; }

        private PlotOptionsPolygonStatesHoverHalo Halo_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public double? LineWidthPlus { get; set; }

        private double? LineWidthPlus_DefaultValue { get; set; }

        public PlotOptionsPolygonStatesHover()
        {
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Halo = this.Halo_DefaultValue = new PlotOptionsPolygonStatesHoverHalo();
            double? nullable2 = new double?(2.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            nullable2 = new double?(1.0);
            this.LineWidthPlus_DefaultValue = nullable2;
            this.LineWidthPlus = nullable2;
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
            if (this.Halo.IsDirty())
                hashtable.Add((object) "halo", (object) this.Halo.ToHashtable());
            double? lineWidth = this.LineWidth;
            double? nullable = this.LineWidth_DefaultValue;
            if ((lineWidth.GetValueOrDefault() == nullable.GetValueOrDefault()
                    ? (lineWidth.HasValue != nullable.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            nullable = this.LineWidthPlus;
            double? plusDefaultValue = this.LineWidthPlus_DefaultValue;
            if ((nullable.GetValueOrDefault() == plusDefaultValue.GetValueOrDefault()
                    ? (nullable.HasValue != plusDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "lineWidthPlus", (object) this.LineWidthPlus);
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