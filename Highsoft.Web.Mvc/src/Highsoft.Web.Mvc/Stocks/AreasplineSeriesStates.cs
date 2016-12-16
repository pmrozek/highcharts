// Type: Highsoft.Web.Mvc.Stocks.AreasplineSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class AreasplineSeriesStates : BaseObject
    {
        public AreasplineSeriesStatesHover Hover { get; set; }

        private AreasplineSeriesStatesHover Hover_DefaultValue { get; set; }

        public AreasplineSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new AreasplineSeriesStatesHover();
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