// Type: Highsoft.Web.Mvc.Charts.PlotOptionsArea


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsArea : BaseObject
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

        public PlotOptionsAreaCursor Cursor { get; set; }

        private PlotOptionsAreaCursor Cursor_DefaultValue { get; set; }

        public PlotOptionsAreaDashStyle DashStyle { get; set; }

        private PlotOptionsAreaDashStyle DashStyle_DefaultValue { get; set; }

        public PlotOptionsAreaDataLabels DataLabels { get; set; }

        private PlotOptionsAreaDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PlotOptionsAreaEvents Events { get; set; }

        private PlotOptionsAreaEvents Events_DefaultValue { get; set; }

        public string FillColor { get; set; }

        private string FillColor_DefaultValue { get; set; }

        public double? FillOpacity { get; set; }

        private double? FillOpacity_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public PlotOptionsAreaLinecap Linecap { get; set; }

        private PlotOptionsAreaLinecap Linecap_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public PlotOptionsAreaMarker Marker { get; set; }

        private PlotOptionsAreaMarker Marker_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public string NegativeFillColor { get; set; }

        private string NegativeFillColor_DefaultValue { get; set; }

        public PlotOptionsAreaPoint Point { get; set; }

        private PlotOptionsAreaPoint Point_DefaultValue { get; set; }

        public double? PointInterval { get; set; }

        private double? PointInterval_DefaultValue { get; set; }

        public PlotOptionsAreaPointIntervalUnit PointIntervalUnit { get; set; }

        private PlotOptionsAreaPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

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

        public PlotOptionsAreaStacking Stacking { get; set; }

        private PlotOptionsAreaStacking Stacking_DefaultValue { get; set; }

        public PlotOptionsAreaStates States { get; set; }

        private PlotOptionsAreaStates States_DefaultValue { get; set; }

        public PlotOptionsAreaStep Step { get; set; }

        private PlotOptionsAreaStep Step_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public double? Threshold { get; set; }

        private double? Threshold_DefaultValue { get; set; }

        public PlotOptionsAreaTooltip Tooltip { get; set; }

        private PlotOptionsAreaTooltip Tooltip_DefaultValue { get; set; }

        public bool? TrackByArea { get; set; }

        private bool? TrackByArea_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public PlotOptionsAreaZones Zones { get; set; }

        private PlotOptionsAreaZones Zones_DefaultValue { get; set; }

        public PlotOptionsArea()
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
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsAreaCursor.Null;
            this.DashStyle = this.DashStyle_DefaultValue = PlotOptionsAreaDashStyle.Solid;
            this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsAreaDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new PlotOptionsAreaEvents();
            this.FillColor = this.FillColor_DefaultValue = (string) null;
            nullable2 = new double?(0.75);
            this.FillOpacity_DefaultValue = nullable2;
            this.FillOpacity = nullable2;
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            this.LineColor = this.LineColor_DefaultValue = (string) null;
            nullable2 = new double?(2.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            this.Linecap = this.Linecap_DefaultValue = PlotOptionsAreaLinecap.Round;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            this.Marker = this.Marker_DefaultValue = new PlotOptionsAreaMarker();
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.NegativeFillColor = this.NegativeFillColor_DefaultValue = (string) null;
            this.Point = this.Point_DefaultValue = new PlotOptionsAreaPoint();
            nullable2 = new double?(1.0);
            this.PointInterval_DefaultValue = nullable2;
            this.PointInterval = nullable2;
            this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsAreaPointIntervalUnit.Null;
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
            nullable1 = new bool?(false);
            this.SoftThreshold_DefaultValue = nullable1;
            this.SoftThreshold = nullable1;
            this.Stacking = this.Stacking_DefaultValue = PlotOptionsAreaStacking.Null;
            this.States = this.States_DefaultValue = new PlotOptionsAreaStates();
            this.Step = this.Step_DefaultValue = PlotOptionsAreaStep.False;
            nullable1 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable1;
            this.StickyTracking = nullable1;
            nullable2 = new double?(0.0);
            this.Threshold_DefaultValue = nullable2;
            this.Threshold = nullable2;
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsAreaTooltip();
            nullable1 = new bool?(false);
            this.TrackByArea_DefaultValue = nullable1;
            this.TrackByArea = nullable1;
            nullable2 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable2;
            this.TurboThreshold = nullable2;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new PlotOptionsAreaZones();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AllowPointSelect;
            bool? nullable2 = this.AllowPointSelect_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? nullable3 = this.AnimationLimit;
            double? nullable4 = this.AnimationLimit_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable2 = this.ConnectEnds;
            nullable1 = this.ConnectEnds_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "connectEnds", (object) this.ConnectEnds);
            nullable1 = this.ConnectNulls;
            nullable2 = this.ConnectNulls_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "connectNulls", (object) this.ConnectNulls);
            nullable4 = this.CropThreshold;
            nullable3 = this.CropThreshold_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DashStyle != this.DashStyle_DefaultValue)
                hashtable.Add((object) "dashStyle", (object) Highcharts.FirstCharacterToLower(this.DashStyle.ToString()));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            nullable2 = this.EnableMouseTracking;
            nullable1 = this.EnableMouseTracking_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            if (this.FillColor != this.FillColor_DefaultValue)
                hashtable.Add((object) "fillColor", (object) this.FillColor);
            nullable3 = this.FillOpacity;
            nullable4 = this.FillOpacity_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "fillOpacity", (object) this.FillOpacity);
            nullable1 = this.GetExtremesFromAll;
            nullable2 = this.GetExtremesFromAll_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            nullable4 = this.LineWidth;
            nullable3 = this.LineWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            if (this.Linecap != this.Linecap_DefaultValue)
                hashtable.Add((object) "linecap", (object) Highcharts.FirstCharacterToLower(this.Linecap.ToString()));
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            if (this.Marker.IsDirty())
                hashtable.Add((object) "marker", (object) this.Marker.ToHashtable());
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            if (this.NegativeFillColor != this.NegativeFillColor_DefaultValue)
                hashtable.Add((object) "negativeFillColor", (object) this.NegativeFillColor);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable3 = this.PointInterval;
            nullable4 = this.PointInterval_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "pointInterval", (object) this.PointInterval);
            if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
                hashtable.Add((object) "pointIntervalUnit",
                    (object) Highcharts.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
            if (this.PointPlacement.IsDirty())
                hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
            nullable4 = this.PointStart;
            nullable3 = this.PointStart_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "pointStart", (object) this.PointStart);
            nullable2 = this.Selected;
            nullable1 = this.Selected_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            nullable1 = this.ShowCheckbox;
            nullable2 = this.ShowCheckbox_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable2 = this.ShowInLegend;
            nullable1 = this.ShowInLegend_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable1 = this.SoftThreshold;
            nullable2 = this.SoftThreshold_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "softThreshold", (object) this.SoftThreshold);
            if (this.Stacking != this.Stacking_DefaultValue)
                hashtable.Add((object) "stacking", (object) Highcharts.FirstCharacterToLower(this.Stacking.ToString()));
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            if (this.Step != this.Step_DefaultValue)
                hashtable.Add((object) "step", (object) Highcharts.FirstCharacterToLower(this.Step.ToString()));
            nullable2 = this.StickyTracking;
            nullable1 = this.StickyTracking_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            nullable3 = this.Threshold;
            nullable4 = this.Threshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable1 = this.TrackByArea;
            nullable2 = this.TrackByArea_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "trackByArea", (object) this.TrackByArea);
            nullable4 = this.TurboThreshold;
            nullable3 = this.TurboThreshold_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            nullable2 = this.Visible;
            nullable1 = this.Visible_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
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