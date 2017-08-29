// Type: Highsoft.Web.Mvc.Charts.PlotOptionsGauge


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsGauge : BaseObject
    {
        public PlotOptionsGauge()
        {
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            double? nullable1 = new double?();
            this.AnimationLimit_DefaultValue = nullable1;
            this.AnimationLimit = nullable1;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            double? nullable2 = new double?();
            this.ColorIndex_DefaultValue = nullable2;
            this.ColorIndex = nullable2;
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsGaugeCursor.Null;
            this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsGaugeDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            this.Dial = this.Dial_DefaultValue = new PlotOptionsGaugeDial();
            bool? nullable3 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable3;
            this.EnableMouseTracking = nullable3;
            this.Events = this.Events_DefaultValue = new PlotOptionsGaugeEvents();
            nullable3 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable3;
            this.GetExtremesFromAll = nullable3;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            nullable2 = new double?(0.0);
            this.Overshoot_DefaultValue = nullable2;
            this.Overshoot = nullable2;
            this.Pivot = this.Pivot_DefaultValue = new PlotOptionsGaugePivot();
            this.Point = this.Point_DefaultValue = new PlotOptionsGaugePoint();
            nullable3 = new bool?(false);
            this.Selected_DefaultValue = nullable3;
            this.Selected = nullable3;
            nullable3 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable3;
            this.ShowCheckbox = nullable3;
            bool? nullable4 = new bool?();
            this.ShowInLegend_DefaultValue = nullable4;
            this.ShowInLegend = nullable4;
            nullable4 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable4;
            this.StickyTracking = nullable4;
            nullable2 = new double?(0.0);
            this.Threshold_DefaultValue = nullable2;
            this.Threshold = nullable2;
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsGaugeTooltip();
            nullable4 = new bool?(true);
            this.Visible_DefaultValue = nullable4;
            this.Visible = nullable4;
            nullable4 = new bool?(true);
            this.Wrap_DefaultValue = nullable4;
            this.Wrap = nullable4;
        }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? ColorIndex { get; set; }

        private double? ColorIndex_DefaultValue { get; set; }

        public PlotOptionsGaugeCursor Cursor { get; set; }

        private PlotOptionsGaugeCursor Cursor_DefaultValue { get; set; }

        public PlotOptionsGaugeDataLabels DataLabels { get; set; }

        private PlotOptionsGaugeDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public PlotOptionsGaugeDial Dial { get; set; }

        private PlotOptionsGaugeDial Dial_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PlotOptionsGaugeEvents Events { get; set; }

        private PlotOptionsGaugeEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public double? Overshoot { get; set; }

        private double? Overshoot_DefaultValue { get; set; }

        public PlotOptionsGaugePivot Pivot { get; set; }

        private PlotOptionsGaugePivot Pivot_DefaultValue { get; set; }

        public PlotOptionsGaugePoint Point { get; set; }

        private PlotOptionsGaugePoint Point_DefaultValue { get; set; }

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

        public PlotOptionsGaugeTooltip Tooltip { get; set; }

        private PlotOptionsGaugeTooltip Tooltip_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public bool? Wrap { get; set; }

        private bool? Wrap_DefaultValue { get; set; }

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
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable2 = this.ColorIndex;
            nullable1 = this.ColorIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "colorIndex", (object) this.ColorIndex);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Dial.IsDirty())
                hashtable.Add((object) "dial", (object) this.Dial.ToHashtable());
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
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            nullable1 = this.Overshoot;
            nullable2 = this.Overshoot_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "overshoot", (object) this.Overshoot);
            if (this.Pivot.IsDirty())
                hashtable.Add((object) "pivot", (object) this.Pivot.ToHashtable());
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
            nullable2 = this.Threshold;
            nullable1 = this.Threshold_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
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