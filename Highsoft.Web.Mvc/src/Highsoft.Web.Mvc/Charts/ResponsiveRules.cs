// Type: Highsoft.Web.Mvc.Charts.ResponsiveRules


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ResponsiveRules : BaseObject
    {
        public ResponsiveRules()
        {
            this.ChartOptions = this.ChartOptions_DefaultValue = (object) null;
            this.Condition = this.Condition_DefaultValue = new ResponsiveRulesCondition();
        }

        public object ChartOptions { get; set; }

        private object ChartOptions_DefaultValue { get; set; }

        public ResponsiveRulesCondition Condition { get; set; }

        private ResponsiveRulesCondition Condition_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ChartOptions != this.ChartOptions_DefaultValue)
                hashtable.Add((object) "chartOptions", this.ChartOptions);
            if (this.Condition.IsDirty())
                hashtable.Add((object) "condition", (object) this.Condition.ToHashtable());
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