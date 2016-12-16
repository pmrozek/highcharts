// Type: Highsoft.Web.Mvc.Charts.SplineSeriesPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class SplineSeriesPoint : BaseObject
    {
        public SplineSeriesPointEvents Events { get; set; }

        private SplineSeriesPointEvents Events_DefaultValue { get; set; }

        public SplineSeriesPoint()
        {
            this.Events = this.Events_DefaultValue = new SplineSeriesPointEvents();
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