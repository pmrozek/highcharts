// Type: Highsoft.Web.Mvc.Charts.PlotOptionsPiePoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsPiePoint : BaseObject
    {
        public PlotOptionsPiePointEvents Events { get; set; }

        private PlotOptionsPiePointEvents Events_DefaultValue { get; set; }

        public PlotOptionsPiePoint()
        {
            this.Events = this.Events_DefaultValue = new PlotOptionsPiePointEvents();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
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