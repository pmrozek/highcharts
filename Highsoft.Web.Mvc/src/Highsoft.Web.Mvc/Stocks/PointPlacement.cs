// Type: Highsoft.Web.Mvc.Stocks.PointPlacement


using System.Collections;

namespace Highsoft.Web.Mvc.Stocks
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
            else if ((uint) this.PointPlacementEnum > 0U)
                hashtable.Add((object) "pointPlacement", (object) this.PointPlacementEnum.ToString().ToLower());
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.Value.HasValue)
                return this.Value.ToString();
            if ((uint) this.PointPlacementEnum > 0U)
                return this.PointPlacementEnum.ToString().ToLower();
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}