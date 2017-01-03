// Type: Highsoft.Web.Mvc.Charts.YAxisStackLabels


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class YAxisStackLabels : BaseObject
    {
        public YAxisStackLabelsAlign Align { get; set; }

        private YAxisStackLabelsAlign Align_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Format { get; set; }

        private string Format_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public YAxisStackLabelsTextAlign TextAlign { get; set; }

        private YAxisStackLabelsTextAlign TextAlign_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public YAxisStackLabelsVerticalAlign VerticalAlign { get; set; }

        private YAxisStackLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public YAxisStackLabels()
        {
            this.Align = this.Align_DefaultValue = YAxisStackLabelsAlign.Null;
            bool? nullable1 = new bool?(false);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Format = this.Format_DefaultValue = "{total}";
            this.Formatter = this.Formatter_DefaultValue = "";
            double? nullable2 = new double?(0.0);
            this.Rotation_DefaultValue = nullable2;
            this.Rotation = nullable2;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "#000000");
            hashtable1.Add((object) "fontSize", (object) "11px");
            hashtable1.Add((object) "fontWeight", (object) "bold");
            hashtable1.Add((object) "textShadow",
                (object) "1px 1px contrast},{ -1px -1px contrast},{ -1px 1px contrast},{ 1px -1px contrast");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            this.TextAlign = this.TextAlign_DefaultValue = YAxisStackLabelsTextAlign.Null;
            nullable1 = new bool?(false);
            this.UseHTML_DefaultValue = nullable1;
            this.UseHTML = nullable1;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = YAxisStackLabelsVerticalAlign.Null;
            double? nullable3 = new double?();
            this.X_DefaultValue = nullable3;
            this.X = nullable3;
            double? nullable4 = new double?();
            this.Y_DefaultValue = nullable4;
            this.Y = nullable4;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highcharts.FirstCharacterToLower(this.Align.ToString()));
            bool? nullable1 = this.Enabled;
            bool? nullable2 = this.Enabled_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highcharts.AddFunction("YAxisStackLabelsFormatter.formatter", this.Formatter);
            }
            double? nullable3 = this.Rotation;
            double? nullable4 = this.Rotation_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.TextAlign != this.TextAlign_DefaultValue)
                hashtable.Add((object) "textAlign", (object) Highcharts.FirstCharacterToLower(this.TextAlign.ToString()));
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable4 = this.X;
            nullable3 = this.X_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "x", (object) this.X);
            nullable3 = this.Y;
            nullable4 = this.Y_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
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