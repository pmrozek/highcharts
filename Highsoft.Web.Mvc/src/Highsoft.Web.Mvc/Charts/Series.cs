// Type: Highsoft.Web.Mvc.Charts.Series


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Series : BaseObject
    {
        public List<SeriesData> Data { get; set; }

        private List<SeriesData> Data_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public string Stack { get; set; }

        private string Stack_DefaultValue { get; set; }

        public SeriesType Type { get; set; }

        private SeriesType Type_DefaultValue { get; set; }

        public string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public Series()
        {
            this.Data = this.Data_DefaultValue = new List<SeriesData>();
            this.Id = this.Id_DefaultValue = "";
            double? nullable1 = new double?();
            this.Index_DefaultValue = nullable1;
            this.Index = nullable1;
            double? nullable2 = new double?();
            this.LegendIndex_DefaultValue = nullable2;
            this.LegendIndex = nullable2;
            this.Name = this.Name_DefaultValue = (string) null;
            this.Stack = this.Stack_DefaultValue = (string) null;
            this.Type = this.Type_DefaultValue = SeriesType.Null;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable3 = new double?();
            this.ZIndex_DefaultValue = nullable3;
            this.ZIndex = nullable3;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            double? index = this.Index;
            double? nullable1 = this.Index_DefaultValue;
            if ((index.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (index.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "index", (object) this.Index);
            nullable1 = this.LegendIndex;
            double? nullable2 = this.LegendIndex_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.Stack != this.Stack_DefaultValue)
                hashtable.Add((object) "stack", (object) this.Stack);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
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