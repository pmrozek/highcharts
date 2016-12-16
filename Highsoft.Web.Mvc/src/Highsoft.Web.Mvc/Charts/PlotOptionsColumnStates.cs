// Type: Highsoft.Web.Mvc.Charts.PlotOptionsColumnStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsColumnStates : BaseObject
    {
        public PlotOptionsColumnStatesHover Hover { get; set; }

        private PlotOptionsColumnStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsColumnStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsColumnStatesHover();
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