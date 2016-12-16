// Type: Highsoft.Web.Mvc.Charts.TreemapSeriesPoint


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class TreemapSeriesPoint : BaseObject
    {
        public TreemapSeriesPointEvents Events { get; set; }

        private TreemapSeriesPointEvents Events_DefaultValue { get; set; }

        public TreemapSeriesPoint()
        {
            this.Events = this.Events_DefaultValue = new TreemapSeriesPointEvents();
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