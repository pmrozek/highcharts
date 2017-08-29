// Type: Highsoft.Web.Mvc.Charts.PlotOptionsScatterMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsScatterMarkerStates : BaseObject
    {
        public PlotOptionsScatterMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsScatterMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new PlotOptionsScatterMarkerStatesSelect();
        }

        public PlotOptionsScatterMarkerStatesHover Hover { get; set; }

        private PlotOptionsScatterMarkerStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsScatterMarkerStatesSelect Select { get; set; }

        private PlotOptionsScatterMarkerStatesSelect Select_DefaultValue { get; set; }

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