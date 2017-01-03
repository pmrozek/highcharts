// Type: Highsoft.Web.Mvc.Stocks.Credits


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Credits : BaseObject
    {
        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Href { get; set; }

        private string Href_DefaultValue { get; set; }

        public Hashtable Position { get; set; }

        private Hashtable Position_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public Credits()
        {
            bool? nullable = new bool?(true);
            this.Enabled_DefaultValue = nullable;
            this.Enabled = nullable;
            this.Href = this.Href_DefaultValue = "'http://www.highcharts.com'";
            this.Position = this.Position_DefaultValue = new Hashtable();
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "cursor", (object) "pointer");
            hashtable1.Add((object) "color", (object) "#999999");
            hashtable1.Add((object) "fontSize", (object) "10px");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            this.Text = this.Text_DefaultValue = "Highcharts.com";
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault()
                    ? (enabled.HasValue != enabledDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Href != this.Href_DefaultValue)
                hashtable.Add((object) "href", (object) this.Href);
            if (this.Position.Count > 0)
                hashtable.Add((object) "position", (object) this.Position);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
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