// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsOhlcMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsOhlcMarkerStates : BaseObject
    {
        public PlotOptionsOhlcMarkerStatesHover Hover { get; set; }

        private PlotOptionsOhlcMarkerStatesHover Hover_DefaultValue { get; set; }

        public PlotOptionsOhlcMarkerStatesSelect Select { get; set; }

        private PlotOptionsOhlcMarkerStatesSelect Select_DefaultValue { get; set; }

        public PlotOptionsOhlcMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new PlotOptionsOhlcMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new PlotOptionsOhlcMarkerStatesSelect();
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