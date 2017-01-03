// Type: Highsoft.Web.Mvc.Charts.Drilldown


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Drilldown : BaseObject
    {
        public Hashtable ActiveAxisLabelStyle { get; set; }

        private Hashtable ActiveAxisLabelStyle_DefaultValue { get; set; }

        public Hashtable ActiveDataLabelStyle { get; set; }

        private Hashtable ActiveDataLabelStyle_DefaultValue { get; set; }

        public bool? AllowPointDrilldown { get; set; }

        private bool? AllowPointDrilldown_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public DrilldownDrillUpButton DrillUpButton { get; set; }

        private DrilldownDrillUpButton DrillUpButton_DefaultValue { get; set; }

        public List<Highsoft.Web.Mvc.Charts.Series> Series { get; set; }

        private List<Highsoft.Web.Mvc.Charts.Series> Series_DefaultValue { get; set; }

        public Drilldown()
        {
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "cursor", (object) "pointer");
            hashtable1.Add((object) "color", (object) "#003399");
            hashtable1.Add((object) "fontWeight", (object) "bold");
            hashtable1.Add((object) "textDecoration", (object) "underline");
            Hashtable hashtable2 = hashtable1;
            this.ActiveAxisLabelStyle_DefaultValue = hashtable1;
            this.ActiveAxisLabelStyle = hashtable2;
            Hashtable hashtable3 = new Hashtable();
            hashtable3.Add((object) "cursor", (object) "pointer");
            hashtable3.Add((object) "color", (object) "#003399");
            hashtable3.Add((object) "fontWeight", (object) "bold");
            hashtable3.Add((object) "textDecoration", (object) "underline");
            Hashtable hashtable4 = hashtable3;
            this.ActiveDataLabelStyle_DefaultValue = hashtable3;
            this.ActiveDataLabelStyle = hashtable4;
            bool? nullable = new bool?(true);
            this.AllowPointDrilldown_DefaultValue = nullable;
            this.AllowPointDrilldown = nullable;
            Animation animation1 = new Animation();
            animation1.Enabled = true;
            Animation animation2 = animation1;
            this.Animation_DefaultValue = animation1;
            this.Animation = animation2;
            this.DrillUpButton = this.DrillUpButton_DefaultValue = new DrilldownDrillUpButton();
            this.Series = this.Series_DefaultValue = (List<Highsoft.Web.Mvc.Charts.Series>) null;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ActiveAxisLabelStyle != this.ActiveAxisLabelStyle_DefaultValue)
                hashtable.Add((object) "activeAxisLabelStyle", (object) this.ActiveAxisLabelStyle);
            if (this.ActiveDataLabelStyle != this.ActiveDataLabelStyle_DefaultValue)
                hashtable.Add((object) "activeDataLabelStyle", (object) this.ActiveDataLabelStyle);
            bool? allowPointDrilldown = this.AllowPointDrilldown;
            bool? drilldownDefaultValue = this.AllowPointDrilldown_DefaultValue;
            if ((allowPointDrilldown.GetValueOrDefault() == drilldownDefaultValue.GetValueOrDefault()
                    ? (allowPointDrilldown.HasValue != drilldownDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "allowPointDrilldown", (object) this.AllowPointDrilldown);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            if (this.DrillUpButton.IsDirty())
                hashtable.Add((object) "drillUpButton", (object) this.DrillUpButton.ToHashtable());
            if (this.Series != this.Series_DefaultValue)
                hashtable.Add((object) "series", (object) this.Series);
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