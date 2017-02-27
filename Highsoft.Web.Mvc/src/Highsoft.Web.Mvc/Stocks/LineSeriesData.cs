// Type: Highsoft.Web.Mvc.Stocks.LineSeriesData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class LineSeriesData : BaseObject
    {
        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public object DataLabels { get; set; }

        private object DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public LineSeriesDataEvents Events { get; set; }

        private LineSeriesDataEvents Events_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Labelrank { get; set; }

        private double? Labelrank_DefaultValue { get; set; }

        public LineSeriesDataMarker Marker { get; set; }

        private LineSeriesDataMarker Marker_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public LineSeriesData()
        {
            this.Color = this.Color_DefaultValue = "undefined";
            this.DataLabels = this.DataLabels_DefaultValue = (object) null;
            this.Description = this.Description_DefaultValue = "undefined";
            this.Events = this.Events_DefaultValue = new LineSeriesDataEvents();
            this.Id = this.Id_DefaultValue = "null";
            double? nullable1 = new double?();
            this.Labelrank_DefaultValue = nullable1;
            this.Labelrank = nullable1;
            this.Marker = this.Marker_DefaultValue = new LineSeriesDataMarker();
            this.Name = this.Name_DefaultValue = (string) null;
            bool? nullable2 = new bool?(false);
            this.Selected_DefaultValue = nullable2;
            this.Selected = nullable2;
            nullable1 = new double?(double.MinValue);
            this.X_DefaultValue = nullable1;
            this.X = nullable1;
            nullable1 = new double?(double.MinValue);
            this.Y_DefaultValue = nullable1;
            this.Y = nullable1;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.DataLabels != this.DataLabels_DefaultValue)
                hashtable.Add((object) "dataLabels", this.DataLabels);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            double? nullable1 = this.Labelrank;
            double? nullable2 = this.Labelrank_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "labelrank", (object) this.Labelrank);
            if (this.Marker.IsDirty())
                hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            bool? selected = this.Selected;
            bool? selectedDefaultValue = this.Selected_DefaultValue;
            if (selected.GetValueOrDefault() != selectedDefaultValue.GetValueOrDefault() ||
                selected.HasValue != selectedDefaultValue.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
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