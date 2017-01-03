// Type: Highsoft.Web.Mvc.Stocks.PolygonSeriesStatesHoverHalo


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PolygonSeriesStatesHoverHalo : BaseObject
    {
        public object Attributes { get; set; }

        private object Attributes_DefaultValue { get; set; }

        public double? Opacity { get; set; }

        private double? Opacity_DefaultValue { get; set; }

        public double? Size { get; set; }

        private double? Size_DefaultValue { get; set; }

        public PolygonSeriesStatesHoverHalo()
        {
            this.Attributes = this.Attributes_DefaultValue = (object) "";
            double? nullable = new double?(0.25);
            this.Opacity_DefaultValue = nullable;
            this.Opacity = nullable;
            nullable = new double?(10.0);
            this.Size_DefaultValue = nullable;
            this.Size = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Attributes != this.Attributes_DefaultValue)
                hashtable.Add((object) "attributes", this.Attributes);
            double? nullable1 = this.Opacity;
            double? nullable2 = this.Opacity_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "opacity", (object) this.Opacity);
            nullable2 = this.Size;
            nullable1 = this.Size_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "size", (object) this.Size);
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