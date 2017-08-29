// Type: Highsoft.Web.Mvc.Charts.PlotOptionsLineMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsLineMarkerStates : BaseObject
    {
        public PlotOptionsLineMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsLineMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new PlotOptionsLineMarkerStatesSelect();
        }

        public PlotOptionsLineMarkerStatesHover Hover { get; set; }

        private PlotOptionsLineMarkerStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsLineMarkerStatesSelect Select { get; set; }

        private PlotOptionsLineMarkerStatesSelect Select_DefaultValue { get; set; }

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