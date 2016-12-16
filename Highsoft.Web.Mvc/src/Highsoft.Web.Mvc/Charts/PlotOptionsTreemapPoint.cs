// Type: Highsoft.Web.Mvc.Charts.PlotOptionsTreemapPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsTreemapPoint : BaseObject
    {
        public PlotOptionsTreemapPointEvents Events { get; set; }

        private PlotOptionsTreemapPointEvents Events_DefaultValue { get; set; }

        public PlotOptionsTreemapPoint()
        {
            this.Events = this.Events_DefaultValue = new PlotOptionsTreemapPointEvents();
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