// Type: Highsoft.Web.Mvc.Stocks.ArearangeSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class ArearangeSeriesStates : BaseObject
    {
        public ArearangeSeriesStatesHover Hover { get; set; }

        private ArearangeSeriesStatesHover Hover_DefaultValue { get; set; }

        public ArearangeSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new ArearangeSeriesStatesHover();
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