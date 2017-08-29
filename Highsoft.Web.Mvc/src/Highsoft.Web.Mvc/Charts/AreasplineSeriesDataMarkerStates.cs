// Type: Highsoft.Web.Mvc.Charts.AreasplineSeriesDataMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class AreasplineSeriesDataMarkerStates : BaseObject
    {
        public AreasplineSeriesDataMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new AreasplineSeriesDataMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new AreasplineSeriesDataMarkerStatesSelect();
        }

        public AreasplineSeriesDataMarkerStatesHover Hover { get; set; }

        private AreasplineSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

        public AreasplineSeriesDataMarkerStatesSelect Select { get; set; }

        private AreasplineSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

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