// Type: Highsoft.Web.Mvc.Charts.PaneBackground


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PaneBackground : BaseObject
    {
        public PaneBackground()
        {
            this.BackgroundColor = this.BackgroundColor_DefaultValue = "";
            this.BorderColor = this.BorderColor_DefaultValue = "#cccccc";
            double? nullable = new double?(1.0);
            this.BorderWidth_DefaultValue = nullable;
            this.BorderWidth = nullable;
            this.ClassName = this.ClassName_DefaultValue = "highcharts-pane";
            this.InnerRadius = this.InnerRadius_DefaultValue = "0";
            this.OuterRadius = this.OuterRadius_DefaultValue = "105%";
            this.Shape = this.Shape_DefaultValue = PaneBackgroundShape.Solid;
        }

        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string InnerRadius { get; set; }

        private string InnerRadius_DefaultValue { get; set; }

        public string OuterRadius { get; set; }

        private string OuterRadius_DefaultValue { get; set; }

        public PaneBackgroundShape Shape { get; set; }

        private PaneBackgroundShape Shape_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? borderWidth = this.BorderWidth;
            double? widthDefaultValue = this.BorderWidth_DefaultValue;
            if (borderWidth.GetValueOrDefault() != widthDefaultValue.GetValueOrDefault() ||
                borderWidth.HasValue != widthDefaultValue.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.InnerRadius != this.InnerRadius_DefaultValue)
                hashtable.Add((object) "innerRadius", (object) this.InnerRadius);
            if (this.OuterRadius != this.OuterRadius_DefaultValue)
                hashtable.Add((object) "outerRadius", (object) this.OuterRadius);
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) Highcharts.FirstCharacterToLower(this.Shape.ToString()));
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