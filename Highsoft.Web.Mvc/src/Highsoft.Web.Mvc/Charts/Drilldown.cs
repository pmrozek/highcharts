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
            this.ActiveAxisLabelStyle = this.ActiveAxisLabelStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "cursor",
                    (object) "pointer"
                },
                {
                    (object) "color",
                    (object) "#003399"
                },
                {
                    (object) "fontWeight",
                    (object) "bold"
                },
                {
                    (object) "textDecoration",
                    (object) "underline"
                }
            };
            this.ActiveDataLabelStyle = this.ActiveDataLabelStyle_DefaultValue = new Hashtable()
            {
                {
                    (object) "cursor",
                    (object) "pointer"
                },
                {
                    (object) "color",
                    (object) "#003399"
                },
                {
                    (object) "fontWeight",
                    (object) "bold"
                },
                {
                    (object) "textDecoration",
                    (object) "underline"
                }
            };
            bool? nullable = new bool?(true);
            this.AllowPointDrilldown_DefaultValue = nullable;
            this.AllowPointDrilldown = nullable;
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
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
            if (allowPointDrilldown.GetValueOrDefault() != drilldownDefaultValue.GetValueOrDefault() ||
                allowPointDrilldown.HasValue != drilldownDefaultValue.HasValue)
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