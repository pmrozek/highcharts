// Type: Highsoft.Web.Mvc.Stocks.AreasplinerangeSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class AreasplinerangeSeriesStates : BaseObject
    {
        public AreasplinerangeSeriesStatesHover Hover { get; set; }

        private AreasplinerangeSeriesStatesHover Hover_DefaultValue { get; set; }

        public AreasplinerangeSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new AreasplinerangeSeriesStatesHover();
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