// Type: Highsoft.Web.Mvc.Stocks.LineSeriesDataMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class LineSeriesDataMarkerStates : BaseObject
    {
        public LineSeriesDataMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new LineSeriesDataMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new LineSeriesDataMarkerStatesSelect();
        }

        public LineSeriesDataMarkerStatesHover Hover { get; set; }

        private LineSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

        public LineSeriesDataMarkerStatesSelect Select { get; set; }

        private LineSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

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