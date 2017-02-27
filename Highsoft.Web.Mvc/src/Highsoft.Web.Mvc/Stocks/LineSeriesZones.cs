// Type: Highsoft.Web.Mvc.Stocks.LineSeriesZones


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class LineSeriesZones : BaseObject
    {
        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public string DashStyle { get; set; }

        private string DashStyle_DefaultValue { get; set; }

        public string FillColor { get; set; }

        private string FillColor_DefaultValue { get; set; }

        public double? Value { get; set; }

        private double? Value_DefaultValue { get; set; }

        public LineSeriesZones()
        {
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            this.DashStyle = this.DashStyle_DefaultValue = (string) null;
            this.FillColor = this.FillColor_DefaultValue = (string) null;
            double? nullable = new double?();
            this.Value_DefaultValue = nullable;
            this.Value = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.DashStyle != this.DashStyle_DefaultValue)
                hashtable.Add((object) "dashStyle", (object) this.DashStyle);
            if (this.FillColor != this.FillColor_DefaultValue)
                hashtable.Add((object) "fillColor", (object) this.FillColor);
            double? nullable = this.Value;
            double? valueDefaultValue = this.Value_DefaultValue;
            if (nullable.GetValueOrDefault() != valueDefaultValue.GetValueOrDefault() ||
                nullable.HasValue != valueDefaultValue.HasValue)
                hashtable.Add((object) "value", (object) this.Value);
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