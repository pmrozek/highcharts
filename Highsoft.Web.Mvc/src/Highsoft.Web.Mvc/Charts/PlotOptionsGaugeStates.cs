// Type: Highsoft.Web.Mvc.Charts.PlotOptionsGaugeStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsGaugeStates : BaseObject
    {
        public PlotOptionsGaugeStatesHover Hover { get; set; }

        private PlotOptionsGaugeStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsGaugeStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsGaugeStatesHover();
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