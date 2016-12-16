// Type: Highsoft.Web.Mvc.Charts.SolidgaugeSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class SolidgaugeSeriesStates : BaseObject
    {
        public SolidgaugeSeriesStatesHover Hover { get; set; }

        private SolidgaugeSeriesStatesHover Hover_DefaultValue { get; set; }

        public SolidgaugeSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new SolidgaugeSeriesStatesHover();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Hover.IsDirty())
                hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
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