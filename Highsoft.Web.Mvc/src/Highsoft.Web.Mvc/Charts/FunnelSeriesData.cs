// Type: Highsoft.Web.Mvc.Charts.FunnelSeriesData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class FunnelSeriesData : BaseObject
    {
        public FunnelSeriesData()
        {
            this.ClassName = this.ClassName_DefaultValue = (string) null;
            this.Color = this.Color_DefaultValue = "undefined";
            double? nullable1 = new double?();
            this.ColorIndex_DefaultValue = nullable1;
            this.ColorIndex = nullable1;
            this.DataLabels = this.DataLabels_DefaultValue = new FunnelSeriesDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            this.Drilldown = this.Drilldown_DefaultValue = "";
            this.Events = this.Events_DefaultValue = new FunnelSeriesDataEvents();
            this.Id = this.Id_DefaultValue = (string) null;
            double? nullable2 = new double?();
            this.Labelrank_DefaultValue = nullable2;
            this.Labelrank = nullable2;
            double? nullable3 = new double?();
            this.LegendIndex_DefaultValue = nullable3;
            this.LegendIndex = nullable3;
            this.Name = this.Name_DefaultValue = (string) null;
            bool? nullable4 = new bool?(false);
            this.Selected_DefaultValue = nullable4;
            this.Selected = nullable4;
            nullable3 = new double?(double.MinValue);
            this.Y_DefaultValue = nullable3;
            this.Y = nullable3;
        }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? ColorIndex { get; set; }

        private double? ColorIndex_DefaultValue { get; set; }

        public FunnelSeriesDataLabels DataLabels { get; set; }

        private FunnelSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public string Drilldown { get; set; }

        private string Drilldown_DefaultValue { get; set; }

        public FunnelSeriesDataEvents Events { get; set; }

        private FunnelSeriesDataEvents Events_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Labelrank { get; set; }

        private double? Labelrank_DefaultValue { get; set; }

        public double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            double? nullable1 = this.ColorIndex;
            double? nullable2 = this.ColorIndex_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "colorIndex", (object) this.ColorIndex);
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Drilldown != this.Drilldown_DefaultValue)
                hashtable.Add((object) "drilldown", (object) this.Drilldown);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable2 = this.Labelrank;
            nullable1 = this.Labelrank_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "labelrank", (object) this.Labelrank);
            nullable1 = this.LegendIndex;
            nullable2 = this.LegendIndex_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            bool? selected = this.Selected;
            bool? selectedDefaultValue = this.Selected_DefaultValue;
            if (selected.GetValueOrDefault() != selectedDefaultValue.GetValueOrDefault() ||
                selected.HasValue != selectedDefaultValue.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            nullable2 = this.Y;
            nullable1 = this.Y_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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