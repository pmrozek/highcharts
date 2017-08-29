// Type: Highsoft.Web.Mvc.Charts.Stop


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Stop : BaseObject, IObjectList
    {
        public Stop()
        {
            this.Position = 0.0;
            this.Color = "";
        }

        public double Position { get; set; }

        public string Color { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (!string.IsNullOrEmpty(this.Color))
                hashtable.Add((object) "color", (object) this.Color);
            if (this.Position != 0.0)
                hashtable.Add((object) "position", (object) this.Position);
            return hashtable;
        }

        internal override string ToJSON()
        {
            return JsonConvert.SerializeObject((object) this.ToHashtable());
        }

        public List<object> ToList()
        {
            if (string.IsNullOrWhiteSpace(this.Color))
                return new List<object>();
            return new List<object>()
            {
                (object) this.Position,
                (object) this.Color
            };
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}