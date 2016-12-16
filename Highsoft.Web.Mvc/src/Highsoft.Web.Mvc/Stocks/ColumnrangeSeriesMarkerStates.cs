// Type: Highsoft.Web.Mvc.Stocks.ColumnrangeSeriesMarkerStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class ColumnrangeSeriesMarkerStates : BaseObject
    {
        public ColumnrangeSeriesMarkerStatesHover Hover { get; set; }

        private ColumnrangeSeriesMarkerStatesHover Hover_DefaultValue { get; set; }

        public ColumnrangeSeriesMarkerStatesSelect Select { get; set; }

        private ColumnrangeSeriesMarkerStatesSelect Select_DefaultValue { get; set; }

        public ColumnrangeSeriesMarkerStates()
        {
            this.Hover = this.Hover_DefaultValue = new ColumnrangeSeriesMarkerStatesHover();
            this.Select = this.Select_DefaultValue = new ColumnrangeSeriesMarkerStatesSelect();
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