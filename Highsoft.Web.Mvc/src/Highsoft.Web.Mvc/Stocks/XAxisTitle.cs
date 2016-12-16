// Type: Highsoft.Web.Mvc.Stocks.XAxisTitle


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class XAxisTitle : BaseObject
    {
        public XAxisTitleAlign Align { get; set; }

        private XAxisTitleAlign Align_DefaultValue { get; set; }

        public string[] Margin { get; set; }

        private string[] Margin_DefaultValue { get; set; }

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

        public XAxisTitle()
        {
            this.Align = this.Align_DefaultValue = XAxisTitleAlign.Middle;
            this.Margin = this.Margin_DefaultValue = (string[]) null;
            double? nullable1 = new double?();
            this.Offset_DefaultValue = nullable1;
            this.Offset = nullable1;
            nullable1 = new double?(0.0);
            this.Rotation_DefaultValue = nullable1;
            this.Rotation = nullable1;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "#666666");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            this.Text = this.Text_DefaultValue = "null";
            nullable1 = new double?(0.0);
            this.X_DefaultValue = nullable1;
            this.X = nullable1;
            double? nullable2 = new double?();
            this.Y_DefaultValue = nullable2;
            this.Y = nullable2;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            if (this.Margin != this.Margin_DefaultValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            double? nullable1 = this.Offset;
            double? nullable2 = this.Offset_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "offset", (object) this.Offset);
            nullable2 = this.Rotation;
            nullable1 = this.Rotation_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            nullable1 = this.X;
            nullable2 = this.X_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable2 = this.Y;
            nullable1 = this.Y_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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