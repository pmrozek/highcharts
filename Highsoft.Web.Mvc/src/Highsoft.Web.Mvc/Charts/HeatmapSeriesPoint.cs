// Type: Highsoft.Web.Mvc.Charts.HeatmapSeriesPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class HeatmapSeriesPoint : BaseObject
    {
        public HeatmapSeriesPoint()
        {
            this.Events = this.Events_DefaultValue = new HeatmapSeriesPointEvents();
        }

        public HeatmapSeriesPointEvents Events { get; set; }

        private HeatmapSeriesPointEvents Events_DefaultValue { get; set; }

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