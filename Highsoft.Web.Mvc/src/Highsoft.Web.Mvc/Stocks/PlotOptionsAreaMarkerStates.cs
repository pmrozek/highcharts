// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsAreaMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsAreaMarkerStates : BaseObject
    {
        public PlotOptionsAreaMarkerStatesHover Hover { get; set; }

        private PlotOptionsAreaMarkerStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsAreaMarkerStatesSelect Select { get; set; }

        private PlotOptionsAreaMarkerStatesSelect Select_DefaultValue { get; set; }

        public PlotOptionsAreaMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsAreaMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new PlotOptionsAreaMarkerStatesSelect();
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