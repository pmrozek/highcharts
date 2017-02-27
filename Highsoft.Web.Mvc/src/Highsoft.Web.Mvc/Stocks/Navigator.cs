// Type: Highsoft.Web.Mvc.Stocks.Navigator


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Navigator : BaseObject
    {
        public bool? AdaptToUpdatedData { get; set; }

        private bool? AdaptToUpdatedData_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public NavigatorHandles Handles { get; set; }

        private NavigatorHandles Handles_DefaultValue { get; set; }

        public double? Height { get; set; }

        private double? Height_DefaultValue { get; set; }

        public string[] Margin { get; set; }

        private string[] Margin_DefaultValue { get; set; }

        public string MaskFill { get; set; }

        private string MaskFill_DefaultValue { get; set; }

        public bool? MaskInside { get; set; }

        private bool? MaskInside_DefaultValue { get; set; }

        public string OutlineColor { get; set; }

        private string OutlineColor_DefaultValue { get; set; }

        public double? OutlineWidth { get; set; }

        private double? OutlineWidth_DefaultValue { get; set; }

        public Series Series { get; set; }

        private Series Series_DefaultValue { get; set; }

        public object XAxis { get; set; }

        private object XAxis_DefaultValue { get; set; }

        public object YAxis { get; set; }

        private object YAxis_DefaultValue { get; set; }

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
            this.Margin = this.Margin_DefaultValue = new string[0];
            this.MaskFill = this.MaskFill_DefaultValue = "rgba(102,133,194,0.3)";
            nullable1 = new bool?(true);
            this.MaskInside_DefaultValue = nullable1;
            this.MaskInside = nullable1;
            this.OutlineColor = this.OutlineColor_DefaultValue = "#cccccc";
            nullable2 = new double?(2.0);
            this.OutlineWidth_DefaultValue = nullable2;
            this.OutlineWidth = nullable2;
            this.Series = this.Series_DefaultValue = (Series) null;
            this.XAxis = this.XAxis_DefaultValue = (object) null;
            this.YAxis = this.YAxis_DefaultValue = (object) "";
        }

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
            if (this.Margin != this.Margin_DefaultValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            if (this.MaskFill != this.MaskFill_DefaultValue)
                hashtable.Add((object) "maskFill", (object) this.MaskFill);
            nullable1 = this.MaskInside;
            nullable2 = this.MaskInside_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "maskInside", (object) this.MaskInside);
            if (this.OutlineColor != this.OutlineColor_DefaultValue)
                hashtable.Add((object) "outlineColor", (object) this.OutlineColor);
            nullable4 = this.OutlineWidth;
            nullable3 = this.OutlineWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "outlineWidth", (object) this.OutlineWidth);
            if (this.Series != this.Series_DefaultValue)
                hashtable.Add((object) "series", (object) this.Series.ToHashtable());
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", this.YAxis);
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