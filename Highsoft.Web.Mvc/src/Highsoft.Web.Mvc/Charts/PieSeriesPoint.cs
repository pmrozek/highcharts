// Type: Highsoft.Web.Mvc.Charts.PieSeriesPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PieSeriesPoint : BaseObject
    {
        public PieSeriesPointEvents Events { get; set; }

        private PieSeriesPointEvents Events_DefaultValue { get; set; }

        public PieSeriesPoint()
        {
            this.Events = this.Events_DefaultValue = new PieSeriesPointEvents();
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