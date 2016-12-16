// Type: Highsoft.Web.Mvc.Charts.AreaSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class AreaSeriesStates : BaseObject
    {
        public AreaSeriesStatesHover Hover { get; set; }

        private AreaSeriesStatesHover Hover_DefaultValue { get; set; }

        public AreaSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new AreaSeriesStatesHover();
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