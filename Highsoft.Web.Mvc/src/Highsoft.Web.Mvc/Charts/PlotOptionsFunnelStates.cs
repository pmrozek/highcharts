// Type: Highsoft.Web.Mvc.Charts.PlotOptionsFunnelStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsFunnelStates : BaseObject
    {
        public PlotOptionsFunnelStatesHover Hover { get; set; }

        private PlotOptionsFunnelStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsFunnelStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsFunnelStatesHover();
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