// Type: Highsoft.Web.Mvc.Charts.NoData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class NoData : BaseObject
    {
        public Hashtable Attr { get; set; }

        private Hashtable Attr_DefaultValue { get; set; }

        public Hashtable Position { get; set; }

        private Hashtable Position_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public NoData()
        {
            this.Attr = this.Attr_DefaultValue = (Hashtable) null;
            this.Position = this.Position_DefaultValue = new Hashtable();
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "fontSize", (object) "12px");
            hashtable1.Add((object) "fontWeight", (object) "bold");
            hashtable1.Add((object) "color", (object) "#666666");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            bool? nullable = new bool?(false);
            this.UseHTML_DefaultValue = nullable;
            this.UseHTML = nullable;
        }

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
            if ((useHtml.GetValueOrDefault() == htmlDefaultValue.GetValueOrDefault()
                    ? (useHtml.HasValue != htmlDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
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