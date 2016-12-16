// Type: Highsoft.Web.Mvc.Charts.AreaSeriesPointPlacement


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class AreaSeriesPointPlacement : BaseObject
    {
        internal override Hashtable ToHashtable()
        {
            return new Hashtable();
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