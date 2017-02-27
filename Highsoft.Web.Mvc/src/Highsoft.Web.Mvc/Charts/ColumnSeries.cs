// Type: Highsoft.Web.Mvc.Charts.ColumnSeries


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ColumnSeries : Series
    {
        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderRadius { get; set; }

        private double? BorderRadius_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public bool? ColorByPoint { get; set; }

        private bool? ColorByPoint_DefaultValue { get; set; }

        public List<string> Colors { get; set; }

        private List<string> Colors_DefaultValue { get; set; }

        public double? CropThreshold { get; set; }

        private double? CropThreshold_DefaultValue { get; set; }

        public ColumnSeriesCursor Cursor { get; set; }

        private ColumnSeriesCursor Cursor_DefaultValue { get; set; }

        public List<ColumnSeriesData> Data { get; set; }

        private List<ColumnSeriesData> Data_DefaultValue { get; set; }

        public ColumnSeriesDataLabels DataLabels { get; set; }

        private ColumnSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public double? Depth { get; set; }

        private double? Depth_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public string EdgeColor { get; set; }

        private string EdgeColor_DefaultValue { get; set; }

        public double? EdgeWidth { get; set; }

        private double? EdgeWidth_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public ColumnSeriesEvents Events { get; set; }

        private ColumnSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public double? GroupPadding { get; set; }

        private double? GroupPadding_DefaultValue { get; set; }

        public double? GroupZPadding { get; set; }

        private double? GroupZPadding_DefaultValue { get; set; }

        public bool? Grouping { get; set; }

        private bool? Grouping_DefaultValue { get; set; }

        public new string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public new double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public new double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public double? MaxPointWidth { get; set; }

        private double? MaxPointWidth_DefaultValue { get; set; }

        public double? MinPointLength { get; set; }

        private double? MinPointLength_DefaultValue { get; set; }

        public new string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public ColumnSeriesPoint Point { get; set; }

        private ColumnSeriesPoint Point_DefaultValue { get; set; }

        public double? PointInterval { get; set; }

        private double? PointInterval_DefaultValue { get; set; }

        public ColumnSeriesPointIntervalUnit PointIntervalUnit { get; set; }

        private ColumnSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

        public double? PointPadding { get; set; }

        private double? PointPadding_DefaultValue { get; set; }

        public PointPlacement PointPlacement { get; set; }

        private PointPlacement PointPlacement_DefaultValue { get; set; }

        public double? PointRange { get; set; }

        private double? PointRange_DefaultValue { get; set; }

        public double? PointStart { get; set; }

        private double? PointStart_DefaultValue { get; set; }

        public double? PointWidth { get; set; }

        private double? PointWidth_DefaultValue { get; set; }

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

        public new string Stack { get; set; }

        private string Stack_DefaultValue { get; set; }

        public ColumnSeriesStacking Stacking { get; set; }

        private ColumnSeriesStacking Stacking_DefaultValue { get; set; }

        public ColumnSeriesStates States { get; set; }

        private ColumnSeriesStates States_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public double? Threshold { get; set; }

        private double? Threshold_DefaultValue { get; set; }

        public ColumnSeriesTooltip Tooltip { get; set; }

        private ColumnSeriesTooltip Tooltip_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public ColumnSeriesType Type { get; set; }

        private ColumnSeriesType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public new string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public new string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public new double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public ColumnSeriesZones Zones { get; set; }

        private ColumnSeriesZones Zones_DefaultValue { get; set; }

        public ColumnSeries()
        {
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.BorderColor = this.BorderColor_DefaultValue = "#ffffff";
            nullable2 = new double?(0.0);
            this.BorderRadius_DefaultValue = nullable2;
            this.BorderRadius = nullable2;
            nullable2 = new double?(1.0);
            this.BorderWidth_DefaultValue = nullable2;
            this.BorderWidth = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            nullable1 = new bool?(false);
            this.ColorByPoint_DefaultValue = nullable1;
            this.ColorByPoint = nullable1;
            this.Colors = this.Colors_DefaultValue = new List<string>();
            nullable2 = new double?(50.0);
            this.CropThreshold_DefaultValue = nullable2;
            this.CropThreshold = nullable2;
            this.Cursor = this.Cursor_DefaultValue = ColumnSeriesCursor.Null;
            this.Data = this.Data_DefaultValue = new List<ColumnSeriesData>();
            this.DataLabels = this.DataLabels_DefaultValue = new ColumnSeriesDataLabels();
            nullable2 = new double?(25.0);
            this.Depth_DefaultValue = nullable2;
            this.Depth = nullable2;
            this.Description = this.Description_DefaultValue = "undefined";
            this.EdgeColor = this.EdgeColor_DefaultValue = "";
            nullable2 = new double?(1.0);
            this.EdgeWidth_DefaultValue = nullable2;
            this.EdgeWidth = nullable2;
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new ColumnSeriesEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            nullable2 = new double?(0.2);
            this.GroupPadding_DefaultValue = nullable2;
            this.GroupPadding = nullable2;
            nullable2 = new double?(1.0);
            this.GroupZPadding_DefaultValue = nullable2;
            this.GroupZPadding = nullable2;
            nullable1 = new bool?(true);
            this.Grouping_DefaultValue = nullable1;
            this.Grouping = nullable1;
            this.Id = this.Id_DefaultValue = "";
            double? nullable3 = new double?();
            this.Index_DefaultValue = nullable3;
            this.Index = nullable3;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            double? nullable4 = new double?();
            this.LegendIndex_DefaultValue = nullable4;
            this.LegendIndex = nullable4;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            double? nullable5 = new double?();
            this.MaxPointWidth_DefaultValue = nullable5;
            this.MaxPointWidth = nullable5;
            nullable5 = new double?(0.0);
            this.MinPointLength_DefaultValue = nullable5;
            this.MinPointLength = nullable5;
            this.Name = this.Name_DefaultValue = (string) null;
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.Point = this.Point_DefaultValue = new ColumnSeriesPoint();
            nullable5 = new double?(1.0);
            this.PointInterval_DefaultValue = nullable5;
            this.PointInterval = nullable5;
            this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = ColumnSeriesPointIntervalUnit.Null;
            nullable5 = new double?(0.1);
            this.PointPadding_DefaultValue = nullable5;
            this.PointPadding = nullable5;
            this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
            double? nullable6 = new double?();
            this.PointRange_DefaultValue = nullable6;
            this.PointRange = nullable6;
            nullable6 = new double?(0.0);
            this.PointStart_DefaultValue = nullable6;
            this.PointStart = nullable6;
            double? nullable7 = new double?();
            this.PointWidth_DefaultValue = nullable7;
            this.PointWidth = nullable7;
            nullable1 = new bool?(false);
            this.Selected_DefaultValue = nullable1;
            this.Selected = nullable1;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable1 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable1;
            this.ShowCheckbox = nullable1;
            nullable1 = new bool?(true);
            this.ShowInLegend_DefaultValue = nullable1;
            this.ShowInLegend = nullable1;
            nullable1 = new bool?(true);
            this.SoftThreshold_DefaultValue = nullable1;
            this.SoftThreshold = nullable1;
            this.Stack = this.Stack_DefaultValue = (string) null;
            this.Stacking = this.Stacking_DefaultValue = ColumnSeriesStacking.Null;
            this.States = this.States_DefaultValue = new ColumnSeriesStates();
            nullable1 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable1;
            this.StickyTracking = nullable1;
            nullable7 = new double?(0.0);
            this.Threshold_DefaultValue = nullable7;
            this.Threshold = nullable7;
            this.Tooltip = this.Tooltip_DefaultValue = new ColumnSeriesTooltip();
            nullable7 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable7;
            this.TurboThreshold = nullable7;
            this.Type = this.Type_DefaultValue = ColumnSeriesType.Null;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable8 = new double?();
            this.ZIndex_DefaultValue = nullable8;
            this.ZIndex = nullable8;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new ColumnSeriesZones();
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
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            nullable4 = this.BorderRadius;
            nullable3 = this.BorderRadius_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable3 = this.BorderWidth;
            nullable4 = this.BorderWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable2 = this.ColorByPoint;
            nullable1 = this.ColorByPoint_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "colorByPoint", (object) this.ColorByPoint);
            if (this.Colors != this.Colors_DefaultValue)
                hashtable.Add((object) "colors", (object) this.Colors);
            nullable4 = this.CropThreshold;
            nullable3 = this.CropThreshold_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            nullable3 = this.Depth;
            nullable4 = this.Depth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "depth", (object) this.Depth);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.EdgeColor != this.EdgeColor_DefaultValue)
                hashtable.Add((object) "edgeColor", (object) this.EdgeColor);
            nullable4 = this.EdgeWidth;
            nullable3 = this.EdgeWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "edgeWidth", (object) this.EdgeWidth);
            nullable1 = this.EnableMouseTracking;
            nullable2 = this.EnableMouseTracking_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable2 = this.GetExtremesFromAll;
            nullable1 = this.GetExtremesFromAll_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            nullable3 = this.GroupPadding;
            nullable4 = this.GroupPadding_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "groupPadding", (object) this.GroupPadding);
            nullable4 = this.GroupZPadding;
            nullable3 = this.GroupZPadding_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "groupZPadding", (object) this.GroupZPadding);
            nullable1 = this.Grouping;
            nullable2 = this.Grouping_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "grouping", (object) this.Grouping);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable3 = this.Index;
            nullable4 = this.Index_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "index", (object) this.Index);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable4 = this.LegendIndex;
            nullable3 = this.LegendIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable3 = this.MaxPointWidth;
            nullable4 = this.MaxPointWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "maxPointWidth", (object) this.MaxPointWidth);
            nullable4 = this.MinPointLength;
            nullable3 = this.MinPointLength_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minPointLength", (object) this.MinPointLength);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
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
            nullable4 = this.PointPadding;
            nullable3 = this.PointPadding_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "pointPadding", (object) this.PointPadding);
            if (this.PointPlacement.IsDirty())
                hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
            nullable3 = this.PointRange;
            nullable4 = this.PointRange_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "pointRange", (object) this.PointRange);
            nullable4 = this.PointStart;
            nullable3 = this.PointStart_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "pointStart", (object) this.PointStart);
            nullable3 = this.PointWidth;
            nullable4 = this.PointWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "pointWidth", (object) this.PointWidth);
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
            if (this.Stack != this.Stack_DefaultValue)
                hashtable.Add((object) "stack", (object) this.Stack);
            if (this.Stacking != this.Stacking_DefaultValue)
                hashtable.Add((object) "stacking", (object) Highcharts.FirstCharacterToLower(this.Stacking.ToString()));
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            nullable2 = this.StickyTracking;
            nullable1 = this.StickyTracking_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            nullable4 = this.Threshold;
            nullable3 = this.Threshold_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable3 = this.TurboThreshold;
            nullable4 = this.TurboThreshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable1 = this.Visible;
            nullable2 = this.Visible_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
            nullable4 = this.ZIndex;
            nullable3 = this.ZIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
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