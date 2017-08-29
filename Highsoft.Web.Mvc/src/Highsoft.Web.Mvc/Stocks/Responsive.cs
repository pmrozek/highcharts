// Type: Highsoft.Web.Mvc.Stocks.Responsive


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Responsive : BaseObject
    {
        public Responsive()
        {
            this.Rules = this.Rules_DefaultValue = new ResponsiveRules();
        }

        public ResponsiveRules Rules { get; set; }

        private ResponsiveRules Rules_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Rules.IsDirty())
                hashtable.Add((object) "rules", (object) this.Rules.ToHashtable());
            return hashtable;
        }

        internal override string ToJSON()
        {
            Hashtable hashtable = this.ToHashtable();


            if (hashtable.Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}