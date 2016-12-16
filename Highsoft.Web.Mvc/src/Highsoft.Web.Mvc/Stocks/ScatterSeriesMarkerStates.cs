// Type: Highsoft.Web.Mvc.Stocks.ScatterSeriesMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class ScatterSeriesMarkerStates : BaseObject
    {
        public ScatterSeriesMarkerStatesHover Hover { get; set; }

        private ScatterSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

        public ScatterSeriesMarkerStatesSelect Select { get; set; }

        private ScatterSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

        public ScatterSeriesMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new ScatterSeriesMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new ScatterSeriesMarkerStatesSelect();
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