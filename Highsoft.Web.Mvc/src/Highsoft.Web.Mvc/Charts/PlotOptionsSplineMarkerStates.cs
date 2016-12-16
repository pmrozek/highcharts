// Type: Highsoft.Web.Mvc.Charts.PlotOptionsSplineMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsSplineMarkerStates : BaseObject
    {
        public PlotOptionsSplineMarkerStatesHover Hover { get; set; }

        private PlotOptionsSplineMarkerStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsSplineMarkerStatesSelect Select { get; set; }

        private PlotOptionsSplineMarkerStatesSelect Select_DefaultValue { get; set; }

        public PlotOptionsSplineMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsSplineMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new PlotOptionsSplineMarkerStatesSelect();
        }

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