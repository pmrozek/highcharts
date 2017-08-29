// Type: Highsoft.Web.Mvc.Charts.XAxisPlotLinesLabel


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class XAxisPlotLinesLabel : BaseObject
    {
        public XAxisPlotLinesLabel()
        {
            this.Align = this.Align_DefaultValue = "left";
            double? nullable1 = new double?();
            this.Rotation_DefaultValue = nullable1;
            this.Rotation = nullable1;
            this.Style = this.Style_DefaultValue = new Hashtable();
            this.Text = this.Text_DefaultValue = "";
            this.TextAlign = this.TextAlign_DefaultValue = (string) null;
            bool? nullable2 = new bool?(false);
            this.UseHTML_DefaultValue = nullable2;
            this.UseHTML = nullable2;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = XAxisPlotLinesLabelVerticalAlign.Top;
            double? nullable3 = new double?();
            this.X_DefaultValue = nullable3;
            this.X = nullable3;
            double? nullable4 = new double?();
            this.Y_DefaultValue = nullable4;
            this.Y = nullable4;
        }

        public string Align { get; set; }

        private string Align_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public string TextAlign { get; set; }

        private string TextAlign_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public XAxisPlotLinesLabelVerticalAlign VerticalAlign { get; set; }

        private XAxisPlotLinesLabelVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) this.Align);
            double? nullable1 = this.Rotation;
            double? nullable2 = this.Rotation_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            if (this.TextAlign != this.TextAlign_DefaultValue)
                hashtable.Add((object) "textAlign", (object) this.TextAlign);
            bool? useHtml = this.UseHTML;
            bool? htmlDefaultValue = this.UseHTML_DefaultValue;
            if (useHtml.GetValueOrDefault() != htmlDefaultValue.GetValueOrDefault() ||
                useHtml.HasValue != htmlDefaultValue.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
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