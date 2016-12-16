// Type: Highsoft.Web.Mvc.Stocks.FlagsSeriesStates


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class FlagsSeriesStates : BaseObject
    {
        public FlagsSeriesStatesHover Hover { get; set; }

        private FlagsSeriesStatesHover Hover_DefaultValue { get; set; }

        public FlagsSeriesStates()
        {
            this.Hover = this.Hover_DefaultValue = new FlagsSeriesStatesHover();
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