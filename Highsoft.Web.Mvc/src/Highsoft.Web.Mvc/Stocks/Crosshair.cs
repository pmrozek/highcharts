// Type: Highsoft.Web.Mvc.Stocks.Crosshair


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Crosshair : BaseObject
    {
        public Crosshair()
        {
            this.XAxis = false;
            this.YAxis = false;
        }

        public bool XAxis { get; set; }

        public bool YAxis { get; set; }

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