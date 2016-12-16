// Type: Highsoft.Web.Mvc.Stocks.Title


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Title : BaseObject
    {
        public TitleAlign Align { get; set; }

        private TitleAlign Align_DefaultValue { get; set; }

        public bool? Floating { get; set; }

        private bool? Floating_DefaultValue { get; set; }

        public string[] Margin { get; set; }

        private string[] Margin_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public TitleVerticalAlign VerticalAlign { get; set; }

        private TitleVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? WidthAdjust { get; set; }

        private double? WidthAdjust_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public Title()
        {
            this.Align = this.Align_DefaultValue = TitleAlign.Center;
            bool? nullable1 = new bool?(false);
            this.Floating_DefaultValue = nullable1;
            this.Floating = nullable1;
            this.Margin = this.Margin_DefaultValue = new string[0];
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "#333333");
            hashtable1.Add((object) "fontSize", (object) "16px");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            this.Text = this.Text_DefaultValue = "null";
            nullable1 = new bool?(false);
            this.UseHTML_DefaultValue = nullable1;
            this.UseHTML = nullable1;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = TitleVerticalAlign.Null;
            double? nullable2 = new double?(-44.0);
            this.WidthAdjust_DefaultValue = nullable2;
            this.WidthAdjust = nullable2;
            nullable2 = new double?(0.0);
            this.X_DefaultValue = nullable2;
            this.X = nullable2;
            double? nullable3 = new double?();
            this.Y_DefaultValue = nullable3;
            this.Y = nullable3;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            bool? nullable1 = this.Floating;
            bool? nullable2 = this.Floating_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "floating", (object) this.Floating);
            if (this.Margin != this.Margin_DefaultValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highstock.FirstCharacterToLower(this.VerticalAlign.ToString()));
            double? nullable3 = this.WidthAdjust;
            double? nullable4 = this.WidthAdjust_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "widthAdjust", (object) this.WidthAdjust);
            nullable4 = this.X;
            nullable3 = this.X_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable3 = this.Y;
            nullable4 = this.Y_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
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