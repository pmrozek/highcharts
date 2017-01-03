// Type: Highsoft.Web.Mvc.Charts.PointPlacement


using System.Collections;

namespace Highsoft.Web.Mvc.Charts
{
    public class PointPlacement : BaseObject
    {
        public double? Value { get; set; }

        public PointPlacementEnum PointPlacementEnum { get; set; }

        public PointPlacement()
        {
            this.Value = new double?();
            this.PointPlacementEnum = PointPlacementEnum.Null;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Value.HasValue)
                hashtable.Add((object) "pointPlacement", (object) this.Value);
            else if (this.PointPlacementEnum != PointPlacementEnum.Null)
                hashtable.Add((object) "pointPlacement", (object) this.PointPlacementEnum.ToString().ToLower());
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.PointPlacementEnum != PointPlacementEnum.Null)
                return this.PointPlacementEnum.ToString().ToLower();
            return "";
        }

        internal double? ToJSONDouble()
        {
            if (this.Value.HasValue)
                return this.Value;
            return new double?(0.0);
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}