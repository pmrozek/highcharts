// Type: Highsoft.Web.Mvc.Stocks.Loading


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
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
            nullable = new double?(0.0);
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
            double? nullable1 = this.HideDuration;
            double? nullable2 = this.HideDuration_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "hideDuration", (object) this.HideDuration);
            if (this.LabelStyle != this.LabelStyle_DefaultValue)
                hashtable.Add((object) "labelStyle", (object) this.LabelStyle);
            nullable2 = this.ShowDuration;
            nullable1 = this.ShowDuration_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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