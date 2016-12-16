// Type: Highsoft.Web.Mvc.Stocks.LineSeriesPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class LineSeriesPoint : BaseObject
    {
        public LineSeriesPointEvents Events { get; set; }

        private LineSeriesPointEvents Events_DefaultValue { get; set; }

        public LineSeriesPoint()
        {
            this.Events = this.Events_DefaultValue = new LineSeriesPointEvents();
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