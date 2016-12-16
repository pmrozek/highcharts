// Type: Highsoft.Web.Mvc.Stocks.PolygonSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PolygonSeriesStates : BaseObject
    {
        public PolygonSeriesStatesHover Hover { get; set; }

        private PolygonSeriesStatesHover Hover_DefaultValue { get; set; }

        public PolygonSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new PolygonSeriesStatesHover();
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