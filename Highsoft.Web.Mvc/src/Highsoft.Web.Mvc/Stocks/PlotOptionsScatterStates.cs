// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsScatterStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsScatterStates : BaseObject
    {
        public PlotOptionsScatterStatesHover Hover { get; set; }

        private PlotOptionsScatterStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsScatterStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsScatterStatesHover();
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