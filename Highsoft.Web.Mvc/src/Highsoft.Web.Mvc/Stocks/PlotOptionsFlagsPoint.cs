// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsFlagsPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsFlagsPoint : BaseObject
    {
        public PlotOptionsFlagsPoint()
        {
            this.Events = this.Events_DefaultValue = new PlotOptionsFlagsPointEvents();
        }

        public PlotOptionsFlagsPointEvents Events { get; set; }

        private PlotOptionsFlagsPointEvents Events_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
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