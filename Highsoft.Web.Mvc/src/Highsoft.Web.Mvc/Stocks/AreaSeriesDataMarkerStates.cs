// Type: Highsoft.Web.Mvc.Stocks.AreaSeriesDataMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class AreaSeriesDataMarkerStates : BaseObject
    {
        public AreaSeriesDataMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new AreaSeriesDataMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new AreaSeriesDataMarkerStatesSelect();
        }

        public AreaSeriesDataMarkerStatesHover Hover { get; set; }

        private AreaSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

        public AreaSeriesDataMarkerStatesSelect Select { get; set; }

        private AreaSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

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
            Hashtable hashtable = this.ToHashtable();


            if (hashtable.Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}