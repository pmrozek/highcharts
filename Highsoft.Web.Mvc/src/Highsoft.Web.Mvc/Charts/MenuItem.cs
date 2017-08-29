// Type: Highsoft.Web.Mvc.Charts.MenuItem


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class MenuItem : BaseObject
    {
        public MenuItem()
        {
            this.Text = "";
            this.OnClick = "";
        }

        public string Text { get; set; }

        public string OnClick { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (!string.IsNullOrEmpty(this.Text))
                hashtable.Add((object) "text", (object) this.Text);
            if (!string.IsNullOrEmpty(this.OnClick))
                hashtable.Add((object) "borderColor", (object) this.OnClick);
            return hashtable;
        }

        internal override string ToJSON()
        {
            return JsonConvert.SerializeObject((object) this.ToHashtable());
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}