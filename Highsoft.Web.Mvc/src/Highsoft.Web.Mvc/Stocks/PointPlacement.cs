// Type: Highsoft.Web.Mvc.Stocks.PointPlacement


using System.Collections;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PointPlacement : BaseObject
    {
        private double? _Value;
        private PointPlacementEnum _PointPlacementEnum;

        public PointPlacement()
        {
            this._Value = new double?();
            this._PointPlacementEnum = PointPlacementEnum.Null;
        }

        public double? Value
        {
            get { return this._Value; }
            set
            {
                this._Value = value;
                this._PointPlacementEnum = PointPlacementEnum.Null;
            }
        }

        public PointPlacementEnum PointPlacementEnum
        {
            get { return this._PointPlacementEnum; }
            set
            {
                this._PointPlacementEnum = value;
                this._Value = new double?();
            }
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
            if ((uint) this.PointPlacementEnum > 0U)
                return this.PointPlacementEnum.ToString().ToLower();
            return (string) null;
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}