// Type: Highsoft.Web.Mvc.Charts.PlotOptionsPieStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsPieStates : BaseObject
    {
        public PlotOptionsPieStatesHover Hover { get; set; }

        private PlotOptionsPieStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsPieStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsPieStatesHover();
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