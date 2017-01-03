// Type: Highsoft.Web.Mvc.Charts.PlotOptionsSolidgauge


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsSolidgauge : BaseObject
    {
        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public PlotOptionsSolidgaugeCursor Cursor { get; set; }

        private PlotOptionsSolidgaugeCursor Cursor_DefaultValue { get; set; }

        public PlotOptionsSolidgaugeDataLabels DataLabels { get; set; }

        private PlotOptionsSolidgaugeDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PlotOptionsSolidgaugeEvents Events { get; set; }

        private PlotOptionsSolidgaugeEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public PlotOptionsSolidgaugeLinecap Linecap { get; set; }

        private PlotOptionsSolidgaugeLinecap Linecap_DefaultValue { get; set; }

        public double? Overshoot { get; set; }

        private double? Overshoot_DefaultValue { get; set; }

        public PlotOptionsSolidgaugePoint Point { get; set; }

        private PlotOptionsSolidgaugePoint Point_DefaultValue { get; set; }

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

        public PlotOptionsSolidgaugeTooltip Tooltip { get; set; }

        private PlotOptionsSolidgaugeTooltip Tooltip_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public bool? Wrap { get; set; }

        private bool? Wrap_DefaultValue { get; set; }

        public PlotOptionsSolidgauge()
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
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsSolidgaugeCursor.Null;
            this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsSolidgaugeDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            bool? nullable2 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable2;
            this.EnableMouseTracking = nullable2;
            this.Events = this.Events_DefaultValue = new PlotOptionsSolidgaugeEvents();
            nullable2 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable2;
            this.GetExtremesFromAll = nullable2;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            this.Linecap = this.Linecap_DefaultValue = PlotOptionsSolidgaugeLinecap.Round;
            nullable1 = new double?(0.0);
            this.Overshoot_DefaultValue = nullable1;
            this.Overshoot = nullable1;
            this.Point = this.Point_DefaultValue = new PlotOptionsSolidgaugePoint();
            nullable2 = new bool?(false);
            this.Selected_DefaultValue = nullable2;
            this.Selected = nullable2;
            nullable2 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable2;
            this.ShowCheckbox = nullable2;
            bool? nullable3 = new bool?();
            this.ShowInLegend_DefaultValue = nullable3;
            this.ShowInLegend = nullable3;
            nullable3 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable3;
            this.StickyTracking = nullable3;
            double? nullable4 = new double?();
            this.Threshold_DefaultValue = nullable4;
            this.Threshold = nullable4;
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsSolidgaugeTooltip();
            nullable3 = new bool?(true);
            this.Visible_DefaultValue = nullable3;
            this.Visible = nullable3;
            nullable3 = new bool?(true);
            this.Wrap_DefaultValue = nullable3;
            this.Wrap = nullable3;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? nullable1 = this.AnimationLimit;
            double? nullable2 = this.AnimationLimit_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
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
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable4 = this.GetExtremesFromAll;
            nullable3 = this.GetExtremesFromAll_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            if (this.Linecap != this.Linecap_DefaultValue)
                hashtable.Add((object) "linecap", (object) Highcharts.FirstCharacterToLower(this.Linecap.ToString()));
            nullable2 = this.Overshoot;
            nullable1 = this.Overshoot_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "overshoot", (object) this.Overshoot);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable3 = this.Selected;
            nullable4 = this.Selected_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "selected", (object) this.Selected);
            nullable4 = this.ShowCheckbox;
            nullable3 = this.ShowCheckbox_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable3 = this.ShowInLegend;
            nullable4 = this.ShowInLegend_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable4 = this.StickyTracking;
            nullable3 = this.StickyTracking_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            nullable1 = this.Threshold;
            nullable2 = this.Threshold_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable3 = this.Visible;
            nullable4 = this.Visible_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "visible", (object) this.Visible);
            nullable4 = this.Wrap;
            nullable3 = this.Wrap_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "wrap", (object) this.Wrap);
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