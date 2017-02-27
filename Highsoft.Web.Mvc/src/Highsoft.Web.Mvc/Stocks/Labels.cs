// Type: Highsoft.Web.Mvc.Stocks.Labels


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Labels : BaseObject
    {
        public LabelsItems Items { get; set; }

        private LabelsItems Items_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public Labels()
        {
            this.Items = this.Items_DefaultValue = new LabelsItems();
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#333333"
                }
            };
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Items.IsDirty())
                hashtable.Add((object) "items", (object) this.Items.ToHashtable());
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
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