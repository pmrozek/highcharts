// Type: Highsoft.Web.Mvc.Stocks.LegendNavigation


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class LegendNavigation : BaseObject
    {
        public LegendNavigation()
        {
            this.ActiveColor = this.ActiveColor_DefaultValue = "#003399";
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            double? nullable1 = new double?(12.0);
            this.ArrowSize_DefaultValue = nullable1;
            this.ArrowSize = nullable1;
            bool? nullable2 = new bool?(true);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            this.InactiveColor = this.InactiveColor_DefaultValue = "#cccccc";
            this.Style = this.Style_DefaultValue = new Hashtable();
        }

        public string ActiveColor { get; set; }

        private string ActiveColor_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? ArrowSize { get; set; }

        private double? ArrowSize_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string InactiveColor { get; set; }

        private string InactiveColor_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ActiveColor != this.ActiveColor_DefaultValue)
                hashtable.Add((object) "activeColor", (object) this.ActiveColor);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? arrowSize = this.ArrowSize;
            double? sizeDefaultValue = this.ArrowSize_DefaultValue;
            if (arrowSize.GetValueOrDefault() != sizeDefaultValue.GetValueOrDefault() ||
                arrowSize.HasValue != sizeDefaultValue.HasValue)
                hashtable.Add((object) "arrowSize", (object) this.ArrowSize);
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if (enabled.GetValueOrDefault() != enabledDefaultValue.GetValueOrDefault() ||
                enabled.HasValue != enabledDefaultValue.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.InactiveColor != this.InactiveColor_DefaultValue)
                hashtable.Add((object) "inactiveColor", (object) this.InactiveColor);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
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