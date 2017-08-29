// Type: Highsoft.Web.Mvc.Stocks.Background


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Background : BaseObject
    {
        public Background()
        {
            this.BackgroundColor = "";
            this.InnerWidth = 0;
            this.OuterWidth = 0;
            this.BorderWidth = 0;
            this.BorderColor = "";
            this.InnerRadius = "";
            this.OuterRadius = "";
            this.Shape = "";
        }

        public string Shape { get; set; }

        public string InnerRadius { get; set; }

        public string OuterRadius { get; set; }

        public string BackgroundColor { get; set; }

        public int InnerWidth { get; set; }

        public int OuterWidth { get; set; }

        public int BorderWidth { get; set; }

        public string BorderColor { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (!string.IsNullOrEmpty(this.BackgroundColor))
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (!string.IsNullOrEmpty(this.BorderColor))
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            if (!string.IsNullOrEmpty(this.Shape))
                hashtable.Add((object) "shape", (object) this.Shape);
            if (!string.IsNullOrEmpty(this.InnerRadius))
                hashtable.Add((object) "innerRadius", (object) this.InnerRadius);
            if (!string.IsNullOrEmpty(this.OuterRadius))
                hashtable.Add((object) "outerRadius", (object) this.OuterRadius);
            if ((uint) this.InnerWidth > 0U)
                hashtable.Add((object) "innerWidth", (object) this.InnerWidth);
            if ((uint) this.OuterWidth > 0U)
                hashtable.Add((object) "outerWidth", (object) this.OuterWidth);
            if ((uint) this.BorderWidth > 0U)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
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