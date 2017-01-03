// Type: Highsoft.Web.Mvc.Stocks.YAxisScrollbar


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class YAxisScrollbar : BaseObject
    {
        public string BarBackgroundColor { get; set; }

        private string BarBackgroundColor_DefaultValue { get; set; }

        public string BarBorderColor { get; set; }

        private string BarBorderColor_DefaultValue { get; set; }

        public double? BarBorderRadius { get; set; }

        private double? BarBorderRadius_DefaultValue { get; set; }

        public double? BarBorderWidth { get; set; }

        private double? BarBorderWidth_DefaultValue { get; set; }

        public string ButtonArrowColor { get; set; }

        private string ButtonArrowColor_DefaultValue { get; set; }

        public string ButtonBackgroundColor { get; set; }

        private string ButtonBackgroundColor_DefaultValue { get; set; }

        public string ButtonBorderColor { get; set; }

        private string ButtonBorderColor_DefaultValue { get; set; }

        public double? ButtonBorderRadius { get; set; }

        private double? ButtonBorderRadius_DefaultValue { get; set; }

        public double? ButtonBorderWidth { get; set; }

        private double? ButtonBorderWidth_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? LiveRedraw { get; set; }

        private bool? LiveRedraw_DefaultValue { get; set; }

        public string[] Margin { get; set; }

        private string[] Margin_DefaultValue { get; set; }

        public double? MinWidth { get; set; }

        private double? MinWidth_DefaultValue { get; set; }

        public string RifleColor { get; set; }

        private string RifleColor_DefaultValue { get; set; }

        public bool? ShowFull { get; set; }

        private bool? ShowFull_DefaultValue { get; set; }

        public double? Size { get; set; }

        private double? Size_DefaultValue { get; set; }

        public string TrackBackgroundColor { get; set; }

        private string TrackBackgroundColor_DefaultValue { get; set; }

        public string TrackBorderColor { get; set; }

        private string TrackBorderColor_DefaultValue { get; set; }

        public double? TrackBorderRadius { get; set; }

        private double? TrackBorderRadius_DefaultValue { get; set; }

        public double? TrackBorderWidth { get; set; }

        private double? TrackBorderWidth_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public YAxisScrollbar()
        {
            this.BarBackgroundColor = this.BarBackgroundColor_DefaultValue = "#cccccc";
            this.BarBorderColor = this.BarBorderColor_DefaultValue = "#cccccc";
            double? nullable1 = new double?(0.0);
            this.BarBorderRadius_DefaultValue = nullable1;
            this.BarBorderRadius = nullable1;
            nullable1 = new double?(1.0);
            this.BarBorderWidth_DefaultValue = nullable1;
            this.BarBorderWidth = nullable1;
            this.ButtonArrowColor = this.ButtonArrowColor_DefaultValue = "#333333";
            this.ButtonBackgroundColor = this.ButtonBackgroundColor_DefaultValue = "#e6e6e6";
            this.ButtonBorderColor = this.ButtonBorderColor_DefaultValue = "#cccccc";
            nullable1 = new double?(0.0);
            this.ButtonBorderRadius_DefaultValue = nullable1;
            this.ButtonBorderRadius = nullable1;
            nullable1 = new double?(1.0);
            this.ButtonBorderWidth_DefaultValue = nullable1;
            this.ButtonBorderWidth = nullable1;
            bool? nullable2 = new bool?(false);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            nullable2 = new bool?(true);
            this.LiveRedraw_DefaultValue = nullable2;
            this.LiveRedraw = nullable2;
            this.Margin = this.Margin_DefaultValue = new string[0];
            nullable1 = new double?(6.0);
            this.MinWidth_DefaultValue = nullable1;
            this.MinWidth = nullable1;
            this.RifleColor = this.RifleColor_DefaultValue = "#333333";
            nullable2 = new bool?(true);
            this.ShowFull_DefaultValue = nullable2;
            this.ShowFull = nullable2;
            nullable1 = new double?(14.0);
            this.Size_DefaultValue = nullable1;
            this.Size = nullable1;
            this.TrackBackgroundColor = this.TrackBackgroundColor_DefaultValue = "#f2f2f2";
            this.TrackBorderColor = this.TrackBorderColor_DefaultValue = "#f2f2f2";
            nullable1 = new double?(0.0);
            this.TrackBorderRadius_DefaultValue = nullable1;
            this.TrackBorderRadius = nullable1;
            nullable1 = new double?(1.0);
            this.TrackBorderWidth_DefaultValue = nullable1;
            this.TrackBorderWidth = nullable1;
            nullable1 = new double?(3.0);
            this.ZIndex_DefaultValue = nullable1;
            this.ZIndex = nullable1;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.BarBackgroundColor != this.BarBackgroundColor_DefaultValue)
                hashtable.Add((object) "barBackgroundColor", (object) this.BarBackgroundColor);
            if (this.BarBorderColor != this.BarBorderColor_DefaultValue)
                hashtable.Add((object) "barBorderColor", (object) this.BarBorderColor);
            double? barBorderRadius = this.BarBorderRadius;
            double? nullable1 = this.BarBorderRadius_DefaultValue;
            if ((barBorderRadius.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (barBorderRadius.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "barBorderRadius", (object) this.BarBorderRadius);
            nullable1 = this.BarBorderWidth;
            double? nullable2 = this.BarBorderWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "barBorderWidth", (object) this.BarBorderWidth);
            if (this.ButtonArrowColor != this.ButtonArrowColor_DefaultValue)
                hashtable.Add((object) "buttonArrowColor", (object) this.ButtonArrowColor);
            if (this.ButtonBackgroundColor != this.ButtonBackgroundColor_DefaultValue)
                hashtable.Add((object) "buttonBackgroundColor", (object) this.ButtonBackgroundColor);
            if (this.ButtonBorderColor != this.ButtonBorderColor_DefaultValue)
                hashtable.Add((object) "buttonBorderColor", (object) this.ButtonBorderColor);
            nullable2 = this.ButtonBorderRadius;
            nullable1 = this.ButtonBorderRadius_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "buttonBorderRadius", (object) this.ButtonBorderRadius);
            nullable1 = this.ButtonBorderWidth;
            nullable2 = this.ButtonBorderWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "buttonBorderWidth", (object) this.ButtonBorderWidth);
            bool? enabled = this.Enabled;
            bool? nullable3 = this.Enabled_DefaultValue;
            if ((enabled.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (enabled.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable3 = this.LiveRedraw;
            bool? nullable4 = this.LiveRedraw_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "liveRedraw", (object) this.LiveRedraw);
            if (this.Margin != this.Margin_DefaultValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            nullable2 = this.MinWidth;
            nullable1 = this.MinWidth_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "minWidth", (object) this.MinWidth);
            if (this.RifleColor != this.RifleColor_DefaultValue)
                hashtable.Add((object) "rifleColor", (object) this.RifleColor);
            nullable4 = this.ShowFull;
            nullable3 = this.ShowFull_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "showFull", (object) this.ShowFull);
            nullable1 = this.Size;
            nullable2 = this.Size_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "size", (object) this.Size);
            if (this.TrackBackgroundColor != this.TrackBackgroundColor_DefaultValue)
                hashtable.Add((object) "trackBackgroundColor", (object) this.TrackBackgroundColor);
            if (this.TrackBorderColor != this.TrackBorderColor_DefaultValue)
                hashtable.Add((object) "trackBorderColor", (object) this.TrackBorderColor);
            nullable2 = this.TrackBorderRadius;
            nullable1 = this.TrackBorderRadius_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "trackBorderRadius", (object) this.TrackBorderRadius);
            nullable1 = this.TrackBorderWidth;
            nullable2 = this.TrackBorderWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "trackBorderWidth", (object) this.TrackBorderWidth);
            nullable2 = this.ZIndex;
            nullable1 = this.ZIndex_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
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