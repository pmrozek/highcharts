// Type: Highsoft.Web.Mvc.Charts.ChartOptions3dFrameBottom


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ChartOptions3dFrameBottom : BaseObject
    {
        public ChartOptions3dFrameBottom()
        {
            this.Color = this.Color_DefaultValue = "transparent";
            double? nullable = new double?(1.0);
            this.Size_DefaultValue = nullable;
            this.Size = nullable;
        }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? Size { get; set; }

        private double? Size_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            double? size = this.Size;
            double? sizeDefaultValue = this.Size_DefaultValue;
            if (size.GetValueOrDefault() != sizeDefaultValue.GetValueOrDefault() ||
                size.HasValue != sizeDefaultValue.HasValue)
                hashtable.Add((object) "size", (object) this.Size);
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