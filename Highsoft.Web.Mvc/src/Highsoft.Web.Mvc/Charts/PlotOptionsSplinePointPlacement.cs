// Type: Highsoft.Web.Mvc.Charts.PlotOptionsSplinePointPlacement


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsSplinePointPlacement : BaseObject
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