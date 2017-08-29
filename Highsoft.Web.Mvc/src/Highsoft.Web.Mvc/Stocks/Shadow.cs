// Type: Highsoft.Web.Mvc.Stocks.Shadow


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Shadow : BaseObject
    {
        public Shadow()
        {
            this.Enabled = false;
            this.Color = "";
            this.OffsetX = 0;
            this.OffsetY = 0;
            this.Opacity = 0.0;
            this.Width = 0;
        }

        public bool Enabled { get; set; }

        public string Color { get; set; }

        public int OffsetX { get; set; }

        public int OffsetY { get; set; }

        public double Opacity { get; set; }

        public int Width { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (!string.IsNullOrEmpty(this.Color))
                hashtable.Add((object) "color", (object) this.Color);
            if ((uint) this.OffsetX > 0U)
                hashtable.Add((object) "offsetX", (object) this.OffsetX);
            if ((uint) this.OffsetY > 0U)
                hashtable.Add((object) "offsetY", (object) this.OffsetY);
            if (this.Opacity != 0.0)
                hashtable.Add((object) "opacity", (object) this.Opacity);
            if ((uint) this.Width > 0U)
                hashtable.Add((object) "width", (object) this.Width);
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.ToHashtable().Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return this.Enabled.ToString().ToLower();
        }

        internal override bool IsDirty()
        {
            return this.Enabled || this.ToHashtable().Count > 0;
        }
    }
}