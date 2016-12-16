// Type: Highsoft.Web.Mvc.Charts.WaterfallSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class WaterfallSeriesStates : BaseObject
    {
        public WaterfallSeriesStatesHover Hover { get; set; }

        private WaterfallSeriesStatesHover Hover_DefaultValue { get; set; }

        public WaterfallSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new WaterfallSeriesStatesHover();
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