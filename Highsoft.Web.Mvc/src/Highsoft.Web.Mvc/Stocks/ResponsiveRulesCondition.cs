// Type: Highsoft.Web.Mvc.Stocks.ResponsiveRulesCondition


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class ResponsiveRulesCondition : BaseObject
    {
        public string Callback { get; set; }

        private string Callback_DefaultValue { get; set; }

        public double? MaxHeight { get; set; }

        private double? MaxHeight_DefaultValue { get; set; }

        public double? MaxWidth { get; set; }

        private double? MaxWidth_DefaultValue { get; set; }

        public double? MinHeight { get; set; }

        private double? MinHeight_DefaultValue { get; set; }

        public double? MinWidth { get; set; }

        private double? MinWidth_DefaultValue { get; set; }

        public ResponsiveRulesCondition()
        {
            this.Callback = this.Callback_DefaultValue = "";
            double? nullable1 = new double?();
            this.MaxHeight_DefaultValue = nullable1;
            this.MaxHeight = nullable1;
            double? nullable2 = new double?();
            this.MaxWidth_DefaultValue = nullable2;
            this.MaxWidth = nullable2;
            nullable2 = new double?(0.0);
            this.MinHeight_DefaultValue = nullable2;
            this.MinHeight = nullable2;
            nullable2 = new double?(0.0);
            this.MinWidth_DefaultValue = nullable2;
            this.MinWidth = nullable2;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Callback != this.Callback_DefaultValue)
            {
                hashtable.Add((object) "callback", (object) this.Callback);
                Highstock.AddFunction("ResponsiveRulesConditionCallback.callback", this.Callback);
            }
            double? maxHeight = this.MaxHeight;
            double? nullable1 = this.MaxHeight_DefaultValue;
            if ((maxHeight.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (maxHeight.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "maxHeight", (object) this.MaxHeight);
            nullable1 = this.MaxWidth;
            double? nullable2 = this.MaxWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "maxWidth", (object) this.MaxWidth);
            nullable2 = this.MinHeight;
            nullable1 = this.MinHeight_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "minHeight", (object) this.MinHeight);
            nullable1 = this.MinWidth;
            nullable2 = this.MinWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "minWidth", (object) this.MinWidth);
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