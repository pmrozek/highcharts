// Type: Highsoft.Web.Mvc.Charts.YAxisPlotLines


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class YAxisPlotLines : BaseObject
    {
        public YAxisPlotLines()
        {
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            this.DashStyle = this.DashStyle_DefaultValue = YAxisPlotLinesDashStyle.Solid;
            this.Events = this.Events_DefaultValue = (object) null;
            this.Id = this.Id_DefaultValue = (string) null;
            this.Label = this.Label_DefaultValue = new YAxisPlotLinesLabel();
            double? nullable1 = new double?();
            this.Value_DefaultValue = nullable1;
            this.Value = nullable1;
            double? nullable2 = new double?();
            this.Width_DefaultValue = nullable2;
            this.Width = nullable2;
            double? nullable3 = new double?();
            this.ZIndex_DefaultValue = nullable3;
            this.ZIndex = nullable3;
        }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public YAxisPlotLinesDashStyle DashStyle { get; set; }

        private YAxisPlotLinesDashStyle DashStyle_DefaultValue { get; set; }

        public object Events { get; set; }

        private object Events_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public YAxisPlotLinesLabel Label { get; set; }

        private YAxisPlotLinesLabel Label_DefaultValue { get; set; }

        public double? Value { get; set; }

        private double? Value_DefaultValue { get; set; }

        public double? Width { get; set; }

        private double? Width_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.DashStyle != this.DashStyle_DefaultValue)
                hashtable.Add((object) "dashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.DashStyle.ToString()));
            if (this.Events != this.Events_DefaultValue)
                hashtable.Add((object) "events", this.Events);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            if (this.Label.IsDirty())
                hashtable.Add((object) "label", (object) this.Label.ToHashtable());
            double? nullable1 = this.Value;
            double? nullable2 = this.Value_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "value", (object) this.Value);
            nullable2 = this.Width;
            nullable1 = this.Width_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "width", (object) this.Width);
            nullable1 = this.ZIndex;
            nullable2 = this.ZIndex_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
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