// Type: Highsoft.Web.Mvc.Stocks.RangeSelectorButton


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class RangeSelectorButton : BaseObject
    {
        public double? Count { get; set; }

        private double? Count_DefaultValue { get; set; }

        public object DataGrouping { get; set; }

        private object DataGrouping_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public RangeSelectorButtonsType Type { get; set; }

        private RangeSelectorButtonsType Type_DefaultValue { get; set; }

        public RangeSelectorButton()
        {
            double? nullable = new double?(1.0);
            this.Count_DefaultValue = nullable;
            this.Count = nullable;
            this.DataGrouping = this.DataGrouping_DefaultValue = (object) null;
            this.Text = this.Text_DefaultValue = "";
            this.Type = this.Type_DefaultValue = RangeSelectorButtonsType.Null;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            double? count = this.Count;
            double? countDefaultValue = this.Count_DefaultValue;
            if ((count.GetValueOrDefault() == countDefaultValue.GetValueOrDefault()
                    ? (count.HasValue != countDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "count", (object) this.Count);
            if (this.DataGrouping != this.DataGrouping_DefaultValue)
                hashtable.Add((object) "dataGrouping", this.DataGrouping);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highstock.FirstCharacterToLower(this.Type.ToString()));
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