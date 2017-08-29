// Type: Highsoft.Web.Mvc.Stocks.NoData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class NoData : BaseObject
    {
        public NoData()
        {
            this.Attr = this.Attr_DefaultValue = (Hashtable) null;
            this.Position = this.Position_DefaultValue = new Hashtable();
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "fontSize",
                    (object) "12px"
                },
                {
                    (object) "fontWeight",
                    (object) "bold"
                },
                {
                    (object) "color",
                    (object) "#666666"
                }
            };
            bool? nullable = new bool?(false);
            this.UseHTML_DefaultValue = nullable;
            this.UseHTML = nullable;
        }

        public Hashtable Attr { get; set; }

        private Hashtable Attr_DefaultValue { get; set; }

        public Hashtable Position { get; set; }

        private Hashtable Position_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Attr != this.Attr_DefaultValue)
                hashtable.Add((object) "attr", (object) this.Attr);
            if (this.Position.Count > 0)
                hashtable.Add((object) "position", (object) this.Position);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            bool? useHtml = this.UseHTML;
            bool? htmlDefaultValue = this.UseHTML_DefaultValue;
            if (useHtml.GetValueOrDefault() != htmlDefaultValue.GetValueOrDefault() ||
                useHtml.HasValue != htmlDefaultValue.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
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