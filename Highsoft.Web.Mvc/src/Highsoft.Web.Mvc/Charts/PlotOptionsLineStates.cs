// Type: Highsoft.Web.Mvc.Charts.PlotOptionsLineStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsLineStates : BaseObject
    {
        public PlotOptionsLineStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsLineStatesHover();
        }

        public PlotOptionsLineStatesHover Hover { get; set; }

        private PlotOptionsLineStatesHover Hover_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Hover.IsDirty())
                hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
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