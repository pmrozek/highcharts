// Type: Highsoft.Web.Mvc.Charts.PlotOptionsSeries


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsSeries : BaseObject
    {
        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public bool? ConnectEnds { get; set; }

        private bool? ConnectEnds_DefaultValue { get; set; }

        public bool? ConnectNulls { get; set; }

        private bool? ConnectNulls_DefaultValue { get; set; }

        public double? CropThreshold { get; set; }

        private double? CropThreshold_DefaultValue { get; set; }

        public PlotOptionsSeriesCursor Cursor { get; set; }

        private PlotOptionsSeriesCursor Cursor_DefaultValue { get; set; }

        public PlotOptionsSeriesDashStyle DashStyle { get; set; }

        private PlotOptionsSeriesDashStyle DashStyle_DefaultValue { get; set; }

        public PlotOptionsSeriesDataLabels DataLabels { get; set; }

        private PlotOptionsSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PlotOptionsSeriesEvents Events { get; set; }

        private PlotOptionsSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public PlotOptionsSeriesLinecap Linecap { get; set; }

        private PlotOptionsSeriesLinecap Linecap_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public PlotOptionsSeriesMarker Marker { get; set; }

        private PlotOptionsSeriesMarker Marker_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public PlotOptionsSeriesPoint Point { get; set; }

        private PlotOptionsSeriesPoint Point_DefaultValue { get; set; }

        public double? PointInterval { get; set; }

        private double? PointInterval_DefaultValue { get; set; }

        public PlotOptionsSeriesPointIntervalUnit PointIntervalUnit { get; set; }

        private PlotOptionsSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

        public PointPlacement PointPlacement { get; set; }

        private PointPlacement PointPlacement_DefaultValue { get; set; }

        public double? PointStart { get; set; }

        private double? PointStart_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public bool? ShowCheckbox { get; set; }

        private bool? ShowCheckbox_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public bool? SoftThreshold { get; set; }

        private bool? SoftThreshold_DefaultValue { get; set; }

        public PlotOptionsSeriesStacking Stacking { get; set; }

        private PlotOptionsSeriesStacking Stacking_DefaultValue { get; set; }

        public PlotOptionsSeriesStates States { get; set; }

        private PlotOptionsSeriesStates States_DefaultValue { get; set; }

        public PlotOptionsSeriesStep Step { get; set; }

        private PlotOptionsSeriesStep Step_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public double? Threshold { get; set; }

        private double? Threshold_DefaultValue { get; set; }

        public PlotOptionsSeriesTooltip Tooltip { get; set; }

        private PlotOptionsSeriesTooltip Tooltip_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public PlotOptionsSeriesZones Zones { get; set; }

        private PlotOptionsSeriesZones Zones_DefaultValue { get; set; }

        public PlotOptionsSeries()
        {
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            Animation animation1 = new Animation();
            animation1.Enabled = true;
            Animation animation2 = animation1;
            this.Animation_DefaultValue = animation1;
            this.Animation = animation2;
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            nullable1 = new bool?(true);
            this.ConnectEnds_DefaultValue = nullable1;
            this.ConnectEnds = nullable1;
            nullable1 = new bool?(false);
            this.ConnectNulls_DefaultValue = nullable1;
            this.ConnectNulls = nullable1;
            nullable2 = new double?(300.0);
            this.CropThreshold_DefaultValue = nullable2;
            this.CropThreshold = nullable2;
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsSeriesCursor.Null;
            this.DashStyle = this.DashStyle_DefaultValue = PlotOptionsSeriesDashStyle.Solid;
            this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsSeriesDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new PlotOptionsSeriesEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            nullable2 = new double?(2.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            this.Linecap = this.Linecap_DefaultValue = PlotOptionsSeriesLinecap.Round;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            this.Marker = this.Marker_DefaultValue = new PlotOptionsSeriesMarker();
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.Point = this.Point_DefaultValue = new PlotOptionsSeriesPoint();
            nullable2 = new double?(1.0);
            this.PointInterval_DefaultValue = nullable2;
            this.PointInterval = nullable2;
            this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsSeriesPointIntervalUnit.Null;
            this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
            nullable2 = new double?(0.0);
            this.PointStart_DefaultValue = nullable2;
            this.PointStart = nullable2;
            nullable1 = new bool?(false);
            this.Selected_DefaultValue = nullable1;
            this.Selected = nullable1;
            Shadow shadow1 = new Shadow();
            shadow1.Enabled = false;
            Shadow shadow2 = shadow1;
            this.Shadow_DefaultValue = shadow1;
            this.Shadow = shadow2;
            nullable1 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable1;
            this.ShowCheckbox = nullable1;
            nullable1 = new bool?(true);
            this.ShowInLegend_DefaultValue = nullable1;
            this.ShowInLegend = nullable1;
            nullable1 = new bool?(true);
            this.SoftThreshold_DefaultValue = nullable1;
            this.SoftThreshold = nullable1;
            this.Stacking = this.Stacking_DefaultValue = PlotOptionsSeriesStacking.Null;
            this.States = this.States_DefaultValue = new PlotOptionsSeriesStates();
            this.Step = this.Step_DefaultValue = PlotOptionsSeriesStep.Null;
            nullable1 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable1;
            this.StickyTracking = nullable1;
            nullable2 = new double?(0.0);
            this.Threshold_DefaultValue = nullable2;
            this.Threshold = nullable2;
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsSeriesTooltip();
            nullable2 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable2;
            this.TurboThreshold = nullable2;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new PlotOptionsSeriesZones();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? allowPointSelect = this.AllowPointSelect;
            bool? selectDefaultValue = this.AllowPointSelect_DefaultValue;
            if ((allowPointSelect.GetValueOrDefault() == selectDefaultValue.GetValueOrDefault()
                    ? (allowPointSelect.HasValue != selectDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? animationLimit = this.AnimationLimit;
            double? nullable1 = this.AnimationLimit_DefaultValue;
            if ((animationLimit.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (animationLimit.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            bool? connectEnds = this.ConnectEnds;
            bool? nullable2 = this.ConnectEnds_DefaultValue;
            if ((connectEnds.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (connectEnds.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "connectEnds", (object) this.ConnectEnds);
            nullable2 = this.ConnectNulls;
            bool? nullable3 = this.ConnectNulls_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "connectNulls", (object) this.ConnectNulls);
            nullable1 = this.CropThreshold;
            double? nullable4 = this.CropThreshold_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DashStyle != this.DashStyle_DefaultValue)
                hashtable.Add((object) "dashStyle", (object) Highcharts.FirstCharacterToLower(this.DashStyle.ToString()));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            nullable3 = this.EnableMouseTracking;
            nullable2 = this.EnableMouseTracking_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable2 = this.GetExtremesFromAll;
            nullable3 = this.GetExtremesFromAll_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable4 = this.LineWidth;
            nullable1 = this.LineWidth_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            if (this.Linecap != this.Linecap_DefaultValue)
                hashtable.Add((object) "linecap", (object) Highcharts.FirstCharacterToLower(this.Linecap.ToString()));
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            if (this.Marker.IsDirty())
                hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable1 = this.PointInterval;
            nullable4 = this.PointInterval_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointInterval", (object) this.PointInterval);
            if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
                hashtable.Add((object) "pointIntervalUnit",
                    (object) Highcharts.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
            if (this.PointPlacement.IsDirty())
                hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
            nullable4 = this.PointStart;
            nullable1 = this.PointStart_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointStart", (object) this.PointStart);
            nullable3 = this.Selected;
            nullable2 = this.Selected_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            nullable2 = this.ShowCheckbox;
            nullable3 = this.ShowCheckbox_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable3 = this.ShowInLegend;
            nullable2 = this.ShowInLegend_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable2 = this.SoftThreshold;
            nullable3 = this.SoftThreshold_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "softThreshold", (object) this.SoftThreshold);
            if (this.Stacking != this.Stacking_DefaultValue)
                hashtable.Add((object) "stacking", (object) Highcharts.FirstCharacterToLower(this.Stacking.ToString()));
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            if (this.Step != this.Step_DefaultValue)
                hashtable.Add((object) "step", (object) Highcharts.FirstCharacterToLower(this.Step.ToString()));
            nullable3 = this.StickyTracking;
            nullable2 = this.StickyTracking_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            nullable1 = this.Threshold;
            nullable4 = this.Threshold_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable4 = this.TurboThreshold;
            nullable1 = this.TurboThreshold_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            nullable2 = this.Visible;
            nullable3 = this.Visible_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.ZoneAxis != this.ZoneAxis_DefaultValue)
                hashtable.Add((object) "zoneAxis", (object) this.ZoneAxis);
            if (this.Zones.IsDirty())
                hashtable.Add((object) "zones", (object) this.Zones.ToHashtable());
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