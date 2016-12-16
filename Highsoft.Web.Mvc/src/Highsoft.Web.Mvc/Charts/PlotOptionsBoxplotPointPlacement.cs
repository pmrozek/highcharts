// Type: Highsoft.Web.Mvc.Charts.PlotOptionsBoxplotPointPlacement


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsBoxplotPointPlacement : BaseObject
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