// Type: Highsoft.Web.Mvc.Charts.Loading


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Loading : BaseObject
    {
        public double? HideDuration { get; set; }

        private double? HideDuration_DefaultValue { get; set; }

        public Hashtable LabelStyle { get; set; }

        private Hashtable LabelStyle_DefaultValue { get; set; }

        public double? ShowDuration { get; set; }

        private double? ShowDuration_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public Loading()
        {
            double? nullable = new double?(100.0);
            this.HideDuration_DefaultValue = nullable;
            this.HideDuration = nullable;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "fontWeight", (object) "bold");
            hashtable1.Add((object) "position", (object) "relative");
            hashtable1.Add((object) "top", (object) "45%");
            Hashtable hashtable2 = hashtable1;
            this.LabelStyle_DefaultValue = hashtable1;
            this.LabelStyle = hashtable2;
            nullable = new double?(100.0);
            this.ShowDuration_DefaultValue = nullable;
            this.ShowDuration = nullable;
            Hashtable hashtable3 = new Hashtable();
            hashtable3.Add((object) "position", (object) "absolute");
            hashtable3.Add((object) "backgroundColor", (object) "#ffffff");
            hashtable3.Add((object) "opacity", (object) 0.5);
            hashtable3.Add((object) "textAlign", (object) "center");
            Hashtable hashtable4 = hashtable3;
            this.Style_DefaultValue = hashtable3;
            this.Style = hashtable4;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            double? hideDuration = this.HideDuration;
            double? durationDefaultValue1 = this.HideDuration_DefaultValue;
            if ((hideDuration.GetValueOrDefault() == durationDefaultValue1.GetValueOrDefault()
                    ? (hideDuration.HasValue != durationDefaultValue1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "hideDuration", (object) this.HideDuration);
            if (this.LabelStyle != this.LabelStyle_DefaultValue)
                hashtable.Add((object) "labelStyle", (object) this.LabelStyle);
            double? showDuration = this.ShowDuration;
            double? durationDefaultValue2 = this.ShowDuration_DefaultValue;
            if ((showDuration.GetValueOrDefault() == durationDefaultValue2.GetValueOrDefault()
                    ? (showDuration.HasValue != durationDefaultValue2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "showDuration", (object) this.ShowDuration);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
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