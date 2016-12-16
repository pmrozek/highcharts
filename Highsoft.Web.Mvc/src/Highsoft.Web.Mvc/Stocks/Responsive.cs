// Type: Highsoft.Web.Mvc.Stocks.Responsive


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Responsive : BaseObject
    {
        public ResponsiveRules Rules { get; set; }

        private ResponsiveRules Rules_DefaultValue { get; set; }

        public Responsive()
        {
            this.Rules = this.Rules_DefaultValue = new ResponsiveRules();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Rules.IsDirty())
                hashtable.Add((object) "rules", (object) this.Rules.ToHashtable());
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