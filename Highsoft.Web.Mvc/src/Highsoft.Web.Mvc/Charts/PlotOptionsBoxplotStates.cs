// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBoxplotStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsBoxplotStates : BaseObject
    {
        public PlotOptionsBoxplotStatesHover Hover { get; set; }

        private PlotOptionsBoxplotStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsBoxplotStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsBoxplotStatesHover();
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