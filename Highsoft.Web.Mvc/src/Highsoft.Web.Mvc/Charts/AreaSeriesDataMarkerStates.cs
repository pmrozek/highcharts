// Type: Highsoft.Web.Mvc.Charts.AreaSeriesDataMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class AreaSeriesDataMarkerStates : BaseObject
    {
        public AreaSeriesDataMarkerStatesHover Hover { get; set; }

        private AreaSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

        public AreaSeriesDataMarkerStatesSelect Select { get; set; }

        private AreaSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

        public AreaSeriesDataMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new AreaSeriesDataMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new AreaSeriesDataMarkerStatesSelect();
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