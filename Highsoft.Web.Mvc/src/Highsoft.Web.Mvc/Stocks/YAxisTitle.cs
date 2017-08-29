// Type: Highsoft.Web.Mvc.Stocks.YAxisTitle


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class YAxisTitle : BaseObject
    {
        public YAxisTitle()
        {
            this.Align = this.Align_DefaultValue = YAxisTitleAlign.Middle;
            double? nullable1 = new double?();
            this.Margin_DefaultValue = nullable1;
            this.Margin = nullable1;
            double? nullable2 = new double?();
            this.Offset_DefaultValue = nullable2;
            this.Offset = nullable2;
            nullable2 = new double?(270.0);
            this.Rotation_DefaultValue = nullable2;
            this.Rotation = nullable2;
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#666666"
                }
            };
            this.Text = this.Text_DefaultValue = "null";
            nullable2 = new double?(0.0);
            this.X_DefaultValue = nullable2;
            this.X = nullable2;
            double? nullable3 = new double?();
            this.Y_DefaultValue = nullable3;
            this.Y = nullable3;
        }

        public YAxisTitleAlign Align { get; set; }

        private YAxisTitleAlign Align_DefaultValue { get; set; }

        public double? Margin { get; set; }

        private double? Margin_DefaultValue { get; set; }

        public double? Offset { get; set; }

        private double? Offset_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            double? nullable1 = this.Margin;
            double? nullable2 = this.Margin_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            nullable2 = this.Offset;
            nullable1 = this.Offset_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "offset", (object) this.Offset);
            nullable1 = this.Rotation;
            nullable2 = this.Rotation_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            nullable2 = this.X;
            nullable1 = this.X_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable1 = this.Y;
            nullable2 = this.Y_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
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