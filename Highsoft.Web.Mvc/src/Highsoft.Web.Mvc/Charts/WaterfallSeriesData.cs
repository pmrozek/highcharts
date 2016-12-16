// Type: Highsoft.Web.Mvc.Charts.WaterfallSeriesData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class WaterfallSeriesData : BaseObject
    {
        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? ColorIndex { get; set; }

        private double? ColorIndex_DefaultValue { get; set; }

        public object DataLabels { get; set; }

        private object DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public string Drilldown { get; set; }

        private string Drilldown_DefaultValue { get; set; }

        public WaterfallSeriesDataEvents Events { get; set; }

        private WaterfallSeriesDataEvents Events_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public bool? IsIntermediateSum { get; set; }

        private bool? IsIntermediateSum_DefaultValue { get; set; }

        public bool? IsSum { get; set; }

        private bool? IsSum_DefaultValue { get; set; }

        public double? Labelrank { get; set; }

        private double? Labelrank_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public WaterfallSeriesData()
        {
            this.ClassName = this.ClassName_DefaultValue = (string) null;
            this.Color = this.Color_DefaultValue = "undefined";
            double? nullable1 = new double?();
            this.ColorIndex_DefaultValue = nullable1;
            this.ColorIndex = nullable1;
            this.DataLabels = this.DataLabels_DefaultValue = (object) null;
            this.Description = this.Description_DefaultValue = "undefined";
            this.Drilldown = this.Drilldown_DefaultValue = "";
            this.Events = this.Events_DefaultValue = new WaterfallSeriesDataEvents();
            this.Id = this.Id_DefaultValue = (string) null;
            bool? nullable2 = new bool?(false);
            this.IsIntermediateSum_DefaultValue = nullable2;
            this.IsIntermediateSum = nullable2;
            nullable2 = new bool?(false);
            this.IsSum_DefaultValue = nullable2;
            this.IsSum = nullable2;
            double? nullable3 = new double?();
            this.Labelrank_DefaultValue = nullable3;
            this.Labelrank = nullable3;
            this.Name = this.Name_DefaultValue = (string) null;
            nullable2 = new bool?(false);
            this.Selected_DefaultValue = nullable2;
            this.Selected = nullable2;
            nullable3 = new double?(double.MinValue);
            this.X_DefaultValue = nullable3;
            this.X = nullable3;
            nullable3 = new double?(double.MinValue);
            this.Y_DefaultValue = nullable3;
            this.Y = nullable3;
        }

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
            if (this.DataLabels != this.DataLabels_DefaultValue)
                hashtable.Add((object) "dataLabels", this.DataLabels);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Drilldown != this.Drilldown_DefaultValue)
                hashtable.Add((object) "drilldown", (object) this.Drilldown);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            bool? nullable3 = this.IsIntermediateSum;
            bool? nullable4 = this.IsIntermediateSum_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "isIntermediateSum", (object) this.IsIntermediateSum);
            nullable4 = this.IsSum;
            nullable3 = this.IsSum_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "isSum", (object) this.IsSum);
            nullable2 = this.Labelrank;
            nullable1 = this.Labelrank_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "labelrank", (object) this.Labelrank);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            nullable3 = this.Selected;
            nullable4 = this.Selected_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
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