// Type: Highsoft.Web.Mvc.Stocks.XAxisPlotLinesLabel


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class XAxisPlotLinesLabel : BaseObject
    {
        public string Align { get; set; }

        private string Align_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

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

        public XAxisPlotLinesLabel()
        {
            this.Align = this.Align_DefaultValue = "left";
            double? nullable1 = new double?();
            this.Rotation_DefaultValue = nullable1;
            this.Rotation = nullable1;
            this.Style = this.Style_DefaultValue = new Hashtable();
            this.TextAlign = this.TextAlign_DefaultValue = "";
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

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) this.Align);
            double? rotation = this.Rotation;
            double? nullable1 = this.Rotation_DefaultValue;
            if ((rotation.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (rotation.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.TextAlign != this.TextAlign_DefaultValue)
                hashtable.Add((object) "textAlign", (object) this.TextAlign);
            bool? useHtml = this.UseHTML;
            bool? htmlDefaultValue = this.UseHTML_DefaultValue;
            if ((useHtml.GetValueOrDefault() == htmlDefaultValue.GetValueOrDefault()
                    ? (useHtml.HasValue != htmlDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highstock.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable1 = this.X;
            double? nullable2 = this.X_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "x", (object) this.X);
            nullable2 = this.Y;
            nullable1 = this.Y_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
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