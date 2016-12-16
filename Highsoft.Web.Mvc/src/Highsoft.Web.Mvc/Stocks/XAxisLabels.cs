// Type: Highsoft.Web.Mvc.Stocks.XAxisLabels


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class XAxisLabels : BaseObject
    {
        public XAxisLabelsAlign Align { get; set; }

        private XAxisLabelsAlign Align_DefaultValue { get; set; }

        public List<double> AutoRotation { get; set; }

        private List<double> AutoRotation_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Format { get; set; }

        private string Format_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public double? StaggerLines { get; set; }

        private double? StaggerLines_DefaultValue { get; set; }

        public double? Step { get; set; }

        private double? Step_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public XAxisLabels()
        {
            this.Align = this.Align_DefaultValue = XAxisLabelsAlign.Center;
            List<double> doubleList1 = new List<double>();
            doubleList1.Add(-45.0);
            List<double> doubleList2 = doubleList1;
            this.AutoRotation_DefaultValue = doubleList1;
            this.AutoRotation = doubleList2;
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Format = this.Format_DefaultValue = "{value}";
            this.Formatter = this.Formatter_DefaultValue = "";
            double? nullable2 = new double?(0.0);
            this.Rotation_DefaultValue = nullable2;
            this.Rotation = nullable2;
            double? nullable3 = new double?();
            this.StaggerLines_DefaultValue = nullable3;
            this.StaggerLines = nullable3;
            double? nullable4 = new double?();
            this.Step_DefaultValue = nullable4;
            this.Step = nullable4;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "color", (object) "#666666");
            hashtable1.Add((object) "cursor", (object) "default");
            hashtable1.Add((object) "fontSize", (object) "11px");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            nullable1 = new bool?(false);
            this.UseHTML_DefaultValue = nullable1;
            this.UseHTML = nullable1;
            nullable4 = new double?(0.0);
            this.X_DefaultValue = nullable4;
            this.X = nullable4;
            double? nullable5 = new double?();
            this.Y_DefaultValue = nullable5;
            this.Y = nullable5;
            nullable5 = new double?(7.0);
            this.ZIndex_DefaultValue = nullable5;
            this.ZIndex = nullable5;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            if (this.AutoRotation != this.AutoRotation_DefaultValue)
                hashtable.Add((object) "autoRotation", (object) this.AutoRotation);
            bool? nullable1 = this.Enabled;
            bool? nullable2 = this.Enabled_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highstock.AddFunction("XAxisLabelsFormatter.formatter", this.Formatter);
            }
            double? nullable3 = this.Rotation;
            double? nullable4 = this.Rotation_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            nullable4 = this.StaggerLines;
            nullable3 = this.StaggerLines_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "staggerLines", (object) this.StaggerLines);
            nullable3 = this.Step;
            nullable4 = this.Step_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "step", (object) this.Step);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
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
            nullable4 = this.ZIndex;
            nullable3 = this.ZIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
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