// Type: Highsoft.Web.Mvc.Charts.SolidgaugeSeries


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class SolidgaugeSeries : Series
    {
        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public SolidgaugeSeriesCursor Cursor { get; set; }

        private SolidgaugeSeriesCursor Cursor_DefaultValue { get; set; }

        public List<SolidgaugeSeriesData> Data { get; set; }

        private List<SolidgaugeSeriesData> Data_DefaultValue { get; set; }

        public SolidgaugeSeriesDataLabels DataLabels { get; set; }

        private SolidgaugeSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public SolidgaugeSeriesEvents Events { get; set; }

        private SolidgaugeSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public new string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public new double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public new double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public SolidgaugeSeriesLinecap Linecap { get; set; }

        private SolidgaugeSeriesLinecap Linecap_DefaultValue { get; set; }

        public new string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public double? Overshoot { get; set; }

        private double? Overshoot_DefaultValue { get; set; }

        public SolidgaugeSeriesPoint Point { get; set; }

        private SolidgaugeSeriesPoint Point_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public bool? ShowCheckbox { get; set; }

        private bool? ShowCheckbox_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public double? Threshold { get; set; }

        private double? Threshold_DefaultValue { get; set; }

        public SolidgaugeSeriesTooltip Tooltip { get; set; }

        private SolidgaugeSeriesTooltip Tooltip_DefaultValue { get; set; }

        public SolidgaugeSeriesType Type { get; set; }

        private SolidgaugeSeriesType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public bool? Wrap { get; set; }

        private bool? Wrap_DefaultValue { get; set; }

        public new string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public new string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public new double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public SolidgaugeSeries()
        {
            Animation animation1 = new Animation();
            animation1.Enabled = true;
            Animation animation2 = animation1;
            this.Animation_DefaultValue = animation1;
            this.Animation = animation2;
            double? nullable1 = new double?();
            this.AnimationLimit_DefaultValue = nullable1;
            this.AnimationLimit = nullable1;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Cursor = this.Cursor_DefaultValue = SolidgaugeSeriesCursor.Null;
            this.Data = this.Data_DefaultValue = new List<SolidgaugeSeriesData>();
            this.DataLabels = this.DataLabels_DefaultValue = new SolidgaugeSeriesDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            bool? nullable2 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable2;
            this.EnableMouseTracking = nullable2;
            this.Events = this.Events_DefaultValue = new SolidgaugeSeriesEvents();
            nullable2 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable2;
            this.GetExtremesFromAll = nullable2;
            this.Id = this.Id_DefaultValue = "";
            double? nullable3 = new double?();
            this.Index_DefaultValue = nullable3;
            this.Index = nullable3;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            double? nullable4 = new double?();
            this.LegendIndex_DefaultValue = nullable4;
            this.LegendIndex = nullable4;
            this.Linecap = this.Linecap_DefaultValue = SolidgaugeSeriesLinecap.Round;
            this.Name = this.Name_DefaultValue = (string) null;
            nullable4 = new double?(0.0);
            this.Overshoot_DefaultValue = nullable4;
            this.Overshoot = nullable4;
            this.Point = this.Point_DefaultValue = new SolidgaugeSeriesPoint();
            nullable2 = new bool?(false);
            this.Selected_DefaultValue = nullable2;
            this.Selected = nullable2;
            nullable2 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable2;
            this.ShowCheckbox = nullable2;
            bool? nullable5 = new bool?();
            this.ShowInLegend_DefaultValue = nullable5;
            this.ShowInLegend = nullable5;
            nullable5 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable5;
            this.StickyTracking = nullable5;
            double? nullable6 = new double?();
            this.Threshold_DefaultValue = nullable6;
            this.Threshold = nullable6;
            this.Tooltip = this.Tooltip_DefaultValue = new SolidgaugeSeriesTooltip();
            this.Type = this.Type_DefaultValue = SolidgaugeSeriesType.Null;
            nullable5 = new bool?(true);
            this.Visible_DefaultValue = nullable5;
            this.Visible = nullable5;
            nullable5 = new bool?(true);
            this.Wrap_DefaultValue = nullable5;
            this.Wrap = nullable5;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable7 = new double?();
            this.ZIndex_DefaultValue = nullable7;
            this.ZIndex = nullable7;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? nullable1 = this.AnimationLimit;
            double? nullable2 = this.AnimationLimit_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            bool? nullable3 = this.EnableMouseTracking;
            bool? nullable4 = this.EnableMouseTracking_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable4 = this.GetExtremesFromAll;
            nullable3 = this.GetExtremesFromAll_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable2 = this.Index;
            nullable1 = this.Index_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "index", (object) this.Index);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable1 = this.LegendIndex;
            nullable2 = this.LegendIndex_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.Linecap != this.Linecap_DefaultValue)
                hashtable.Add((object) "linecap", (object) Highcharts.FirstCharacterToLower(this.Linecap.ToString()));
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            nullable2 = this.Overshoot;
            nullable1 = this.Overshoot_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "overshoot", (object) this.Overshoot);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable3 = this.Selected;
            nullable4 = this.Selected_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            nullable4 = this.ShowCheckbox;
            nullable3 = this.ShowCheckbox_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable3 = this.ShowInLegend;
            nullable4 = this.ShowInLegend_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable4 = this.StickyTracking;
            nullable3 = this.StickyTracking_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            nullable1 = this.Threshold;
            nullable2 = this.Threshold_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable3 = this.Visible;
            nullable4 = this.Visible_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            nullable4 = this.Wrap;
            nullable3 = this.Wrap_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "wrap", (object) this.Wrap);
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
            nullable2 = this.ZIndex;
            nullable1 = this.ZIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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