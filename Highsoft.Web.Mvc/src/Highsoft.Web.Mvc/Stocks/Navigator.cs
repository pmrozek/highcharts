// Type: Highsoft.Web.Mvc.Stocks.Navigator


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Navigator : BaseObject
    {
        public Navigator()
        {
            bool? nullable1 = new bool?(true);
            this.AdaptToUpdatedData_DefaultValue = nullable1;
            this.AdaptToUpdatedData = nullable1;
            nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Handles = this.Handles_DefaultValue = new NavigatorHandles();
            double? nullable2 = new double?(40.0);
            this.Height_DefaultValue = nullable2;
            this.Height = nullable2;
            double? nullable3 = new double?();
            this.Margin_DefaultValue = nullable3;
            this.Margin = nullable3;
            this.MaskFill = this.MaskFill_DefaultValue = "rgba(102,133,194,0.3)";
            nullable1 = new bool?(true);
            this.MaskInside_DefaultValue = nullable1;
            this.MaskInside = nullable1;
            nullable1 = new bool?(false);
            this.Opposite_DefaultValue = nullable1;
            this.Opposite = nullable1;
            this.OutlineColor = this.OutlineColor_DefaultValue = "#cccccc";
            nullable3 = new double?(2.0);
            this.OutlineWidth_DefaultValue = nullable3;
            this.OutlineWidth = nullable3;
            this.Series = this.Series_DefaultValue = (Series) null;
            this.XAxis = this.XAxis_DefaultValue = new XAxis();
            this.YAxis = this.YAxis_DefaultValue = new YAxis();
        }

        public bool? AdaptToUpdatedData { get; set; }

        private bool? AdaptToUpdatedData_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public NavigatorHandles Handles { get; set; }

        private NavigatorHandles Handles_DefaultValue { get; set; }

        public double? Height { get; set; }

        private double? Height_DefaultValue { get; set; }

        public double? Margin { get; set; }

        private double? Margin_DefaultValue { get; set; }

        public string MaskFill { get; set; }

        private string MaskFill_DefaultValue { get; set; }

        public bool? MaskInside { get; set; }

        private bool? MaskInside_DefaultValue { get; set; }

        public bool? Opposite { get; set; }

        private bool? Opposite_DefaultValue { get; set; }

        public string OutlineColor { get; set; }

        private string OutlineColor_DefaultValue { get; set; }

        public double? OutlineWidth { get; set; }

        private double? OutlineWidth_DefaultValue { get; set; }

        public Series Series { get; set; }

        private Series Series_DefaultValue { get; set; }

        public XAxis XAxis { get; set; }

        private XAxis XAxis_DefaultValue { get; set; }

        public YAxis YAxis { get; set; }

        private YAxis YAxis_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AdaptToUpdatedData;
            bool? nullable2 = this.AdaptToUpdatedData_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "adaptToUpdatedData", (object) this.AdaptToUpdatedData);
            nullable2 = this.Enabled;
            nullable1 = this.Enabled_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Handles.IsDirty())
                hashtable.Add((object) "handles", (object) this.Handles.ToHashtable());
            double? nullable3 = this.Height;
            double? nullable4 = this.Height_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "height", (object) this.Height);
            nullable4 = this.Margin;
            nullable3 = this.Margin_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            if (this.MaskFill != this.MaskFill_DefaultValue)
                hashtable.Add((object) "maskFill", (object) this.MaskFill);
            nullable1 = this.MaskInside;
            nullable2 = this.MaskInside_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "maskInside", (object) this.MaskInside);
            nullable2 = this.Opposite;
            nullable1 = this.Opposite_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "opposite", (object) this.Opposite);
            if (this.OutlineColor != this.OutlineColor_DefaultValue)
                hashtable.Add((object) "outlineColor", (object) this.OutlineColor);
            nullable3 = this.OutlineWidth;
            nullable4 = this.OutlineWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "outlineWidth", (object) this.OutlineWidth);
            if (this.Series != this.Series_DefaultValue)
                hashtable.Add((object) "series", (object) this.Series.ToHashtable());
            if (this.XAxis.IsDirty())
                hashtable.Add((object) "xAxis", (object) this.XAxis.ToHashtable());
            if (this.YAxis.IsDirty())
                hashtable.Add((object) "yAxis", (object) this.YAxis.ToHashtable());
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