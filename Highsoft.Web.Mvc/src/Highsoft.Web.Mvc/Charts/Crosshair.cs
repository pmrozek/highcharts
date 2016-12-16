// Type: Highsoft.Web.Mvc.Charts.Crosshair


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Crosshair : BaseObject
    {
        public bool XAxis { get; set; }

        public bool YAxis { get; set; }

        public Crosshair()
        {
            this.XAxis = false;
            this.YAxis = false;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.XAxis)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
            return hashtable;
        }

        internal override string ToJSON()
        {
            return JsonConvert.SerializeObject((object) this.ToHashtable());
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}