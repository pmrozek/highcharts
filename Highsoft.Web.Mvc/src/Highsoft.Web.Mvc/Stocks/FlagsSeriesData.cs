// Type: Highsoft.Web.Mvc.Stocks.FlagsSeriesData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class FlagsSeriesData : BaseObject
    {
        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public FlagsSeriesDataEvents Events { get; set; }

        private FlagsSeriesDataEvents Events_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Labelrank { get; set; }

        private double? Labelrank_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public string Title { get; set; }

        private string Title_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public FlagsSeriesData()
        {
            this.Color = this.Color_DefaultValue = "undefined";
            this.Description = this.Description_DefaultValue = "undefined";
            this.Events = this.Events_DefaultValue = new FlagsSeriesDataEvents();
            this.Id = this.Id_DefaultValue = "null";
            double? nullable1 = new double?();
            this.Labelrank_DefaultValue = nullable1;
            this.Labelrank = nullable1;
            bool? nullable2 = new bool?(false);
            this.Selected_DefaultValue = nullable2;
            this.Selected = nullable2;
            this.Text = this.Text_DefaultValue = (string) null;
            this.Title = this.Title_DefaultValue = (string) null;
            nullable1 = new double?(double.MinValue);
            this.X_DefaultValue = nullable1;
            this.X = nullable1;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            double? labelrank = this.Labelrank;
            double? nullable = this.Labelrank_DefaultValue;
            if ((labelrank.GetValueOrDefault() == nullable.GetValueOrDefault()
                    ? (labelrank.HasValue != nullable.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "labelrank", (object) this.Labelrank);
            bool? selected = this.Selected;
            bool? selectedDefaultValue = this.Selected_DefaultValue;
            if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault()
                    ? (selected.HasValue != selectedDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            if (this.Title != this.Title_DefaultValue)
                hashtable.Add((object) "title", (object) this.Title);
            nullable = this.X;
            double? xDefaultValue = this.X_DefaultValue;
            if ((nullable.GetValueOrDefault() == xDefaultValue.GetValueOrDefault()
                    ? (nullable.HasValue != xDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "x", (object) this.X);
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