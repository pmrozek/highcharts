// Type: Highsoft.Web.Mvc.Stocks.OhlcSeriesMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class OhlcSeriesMarkerStates : BaseObject
    {
        public OhlcSeriesMarkerStatesHover Hover { get; set; }

        private OhlcSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

        public OhlcSeriesMarkerStatesSelect Select { get; set; }

        private OhlcSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

        public OhlcSeriesMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new OhlcSeriesMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new OhlcSeriesMarkerStatesSelect();
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