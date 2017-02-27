// Type: Highsoft.Web.Mvc.Stocks.XAxisCrosshair


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class XAxisCrosshair : BaseObject
    {
        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public XAxisCrosshairDashStyle DashStyle { get; set; }

        private XAxisCrosshairDashStyle DashStyle_DefaultValue { get; set; }

        public XAxisCrosshairLabel Label { get; set; }

        private XAxisCrosshairLabel Label_DefaultValue { get; set; }

        public bool? Snap { get; set; }

        private bool? Snap_DefaultValue { get; set; }

        public double? Width { get; set; }

        private double? Width_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public XAxisCrosshair()
        {
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = "#cccccc";
            this.DashStyle = this.DashStyle_DefaultValue = XAxisCrosshairDashStyle.Solid;
            this.Label = this.Label_DefaultValue = new XAxisCrosshairLabel();
            bool? nullable1 = new bool?(true);
            this.Snap_DefaultValue = nullable1;
            this.Snap = nullable1;
            double? nullable2 = new double?(1.0);
            this.Width_DefaultValue = nullable2;
            this.Width = nullable2;
            nullable2 = new double?(2.0);
            this.ZIndex_DefaultValue = nullable2;
            this.ZIndex = nullable2;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.DashStyle != this.DashStyle_DefaultValue)
                hashtable.Add((object) "dashStyle", (object) Highstock.FirstCharacterToLower(this.DashStyle.ToString()));
            if (this.Label.IsDirty())
                hashtable.Add((object) "label", (object) this.Label.ToHashtable());
            bool? snap = this.Snap;
            bool? snapDefaultValue = this.Snap_DefaultValue;
            if (snap.GetValueOrDefault() != snapDefaultValue.GetValueOrDefault() ||
                snap.HasValue != snapDefaultValue.HasValue)
                hashtable.Add((object) "snap", (object) this.Snap);
            double? nullable1 = this.Width;
            double? nullable2 = this.Width_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "width", (object) this.Width);
            nullable2 = this.ZIndex;
            nullable1 = this.ZIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
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