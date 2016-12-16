// Type: Highsoft.Web.Mvc.Stocks.PolygonSeriesMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PolygonSeriesMarkerStates : BaseObject
    {
        public PolygonSeriesMarkerStatesHover Hover { get; set; }

        private PolygonSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

        public PolygonSeriesMarkerStatesSelect Select { get; set; }

        private PolygonSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

        public PolygonSeriesMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new PolygonSeriesMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new PolygonSeriesMarkerStatesSelect();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Hover.IsDirty())
                hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
            if (this.Select.IsDirty())
                hashtable.Add((object) "select", (object) this.Select.ToHashtable());
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