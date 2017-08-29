// Type: Highsoft.Web.Mvc.Charts.TreemapSeriesStatesHover


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class TreemapSeriesStatesHover : BaseObject
    {
        public TreemapSeriesStatesHover()
        {
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            this.BorderColor = this.BorderColor_DefaultValue = "";
            double? nullable1 = new double?(0.1);
            this.Brightness_DefaultValue = nullable1;
            this.Brightness = nullable1;
            this.Color = this.Color_DefaultValue = "undefined";
            bool? nullable2 = new bool?(true);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            nullable1 = new double?(0.75);
            this.Opacity_DefaultValue = nullable1;
            this.Opacity = nullable1;
        }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? Brightness { get; set; }

        private double? Brightness_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public double? Opacity { get; set; }

        private double? Opacity_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? nullable1 = this.Brightness;
            double? nullable2 = this.Brightness_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "brightness", (object) this.Brightness);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if (enabled.GetValueOrDefault() != enabledDefaultValue.GetValueOrDefault() ||
                enabled.HasValue != enabledDefaultValue.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable2 = this.Opacity;
            nullable1 = this.Opacity_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "opacity", (object) this.Opacity);
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