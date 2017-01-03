// Type: Highsoft.Web.Mvc.Charts.ErrorbarSeries


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ErrorbarSeries : Series
    {
        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public bool? ColorByPoint { get; set; }

        private bool? ColorByPoint_DefaultValue { get; set; }

        public List<string> Colors { get; set; }

        private List<string> Colors_DefaultValue { get; set; }

        public ErrorbarSeriesCursor Cursor { get; set; }

        private ErrorbarSeriesCursor Cursor_DefaultValue { get; set; }

        public List<ErrorbarSeriesData> Data { get; set; }

        private List<ErrorbarSeriesData> Data_DefaultValue { get; set; }

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

        public ErrorbarSeriesEvents Events { get; set; }

        private ErrorbarSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public double? GroupZPadding { get; set; }

        private double? GroupZPadding_DefaultValue { get; set; }

        public new string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public new double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public new double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public double? MaxPointWidth { get; set; }

        private double? MaxPointWidth_DefaultValue { get; set; }

        public new string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public ErrorbarSeriesPoint Point { get; set; }

        private ErrorbarSeriesPoint Point_DefaultValue { get; set; }

        public double? PointInterval { get; set; }

        private double? PointInterval_DefaultValue { get; set; }

        public ErrorbarSeriesPointIntervalUnit PointIntervalUnit { get; set; }

        private ErrorbarSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

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

        public ErrorbarSeriesStates States { get; set; }

        private ErrorbarSeriesStates States_DefaultValue { get; set; }

        public string StemColor { get; set; }

        private string StemColor_DefaultValue { get; set; }

        public ErrorbarSeriesStemDashStyle StemDashStyle { get; set; }

        private ErrorbarSeriesStemDashStyle StemDashStyle_DefaultValue { get; set; }

        public double? StemWidth { get; set; }

        private double? StemWidth_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public ErrorbarSeriesTooltip Tooltip { get; set; }

        private ErrorbarSeriesTooltip Tooltip_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public ErrorbarSeriesType Type { get; set; }

        private ErrorbarSeriesType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public string WhiskerColor { get; set; }

        private string WhiskerColor_DefaultValue { get; set; }

        public string WhiskerLength { get; set; }

        private string WhiskerLength_DefaultValue { get; set; }

        public double? WhiskerWidth { get; set; }

        private double? WhiskerWidth_DefaultValue { get; set; }

        public new string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public new string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public new double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public ErrorbarSeriesZones Zones { get; set; }

        private ErrorbarSeriesZones Zones_DefaultValue { get; set; }

        public ErrorbarSeries()
        {
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = "#000000";
            nullable1 = new bool?(false);
            this.ColorByPoint_DefaultValue = nullable1;
            this.ColorByPoint = nullable1;
            this.Colors = this.Colors_DefaultValue = new List<string>();
            this.Cursor = this.Cursor_DefaultValue = ErrorbarSeriesCursor.Null;
            this.Data = this.Data_DefaultValue = new List<ErrorbarSeriesData>();
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
            this.Events = this.Events_DefaultValue = new ErrorbarSeriesEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            nullable2 = new double?(1.0);
            this.GroupZPadding_DefaultValue = nullable2;
            this.GroupZPadding = nullable2;
            this.Id = this.Id_DefaultValue = "";
            double? nullable3 = new double?();
            this.Index_DefaultValue = nullable3;
            this.Index = nullable3;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            double? nullable4 = new double?();
            this.LegendIndex_DefaultValue = nullable4;
            this.LegendIndex = nullable4;
            nullable4 = new double?(1.0);
            this.LineWidth_DefaultValue = nullable4;
            this.LineWidth = nullable4;
            this.LinkedTo = this.LinkedTo_DefaultValue = ":previous";
            double? nullable5 = new double?();
            this.MaxPointWidth_DefaultValue = nullable5;
            this.MaxPointWidth = nullable5;
            this.Name = this.Name_DefaultValue = (string) null;
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.Point = this.Point_DefaultValue = new ErrorbarSeriesPoint();
            nullable5 = new double?(1.0);
            this.PointInterval_DefaultValue = nullable5;
            this.PointInterval = nullable5;
            this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = ErrorbarSeriesPointIntervalUnit.Null;
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
            this.States = this.States_DefaultValue = new ErrorbarSeriesStates();
            this.StemColor = this.StemColor_DefaultValue = "null";
            this.StemDashStyle = this.StemDashStyle_DefaultValue = ErrorbarSeriesStemDashStyle.Solid;
            double? nullable8 = new double?();
            this.StemWidth_DefaultValue = nullable8;
            this.StemWidth = nullable8;
            nullable1 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable1;
            this.StickyTracking = nullable1;
            this.Tooltip = this.Tooltip_DefaultValue = new ErrorbarSeriesTooltip();
            nullable8 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable8;
            this.TurboThreshold = nullable8;
            this.Type = this.Type_DefaultValue = ErrorbarSeriesType.Null;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
            this.WhiskerColor = this.WhiskerColor_DefaultValue = "null";
            this.WhiskerLength = this.WhiskerLength_DefaultValue = "50%";
            double? nullable9 = new double?();
            this.WhiskerWidth_DefaultValue = nullable9;
            this.WhiskerWidth = nullable9;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable10 = new double?();
            this.ZIndex_DefaultValue = nullable10;
            this.ZIndex = nullable10;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new ErrorbarSeriesZones();
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
            bool? colorByPoint = this.ColorByPoint;
            bool? nullable2 = this.ColorByPoint_DefaultValue;
            if ((colorByPoint.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (colorByPoint.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "colorByPoint", (object) this.ColorByPoint);
            if (this.Colors != this.Colors_DefaultValue)
                hashtable.Add((object) "colors", (object) this.Colors);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            nullable1 = this.Depth;
            double? nullable3 = this.Depth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "depth", (object) this.Depth);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.EdgeColor != this.EdgeColor_DefaultValue)
                hashtable.Add((object) "edgeColor", (object) this.EdgeColor);
            nullable3 = this.EdgeWidth;
            nullable1 = this.EdgeWidth_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "edgeWidth", (object) this.EdgeWidth);
            nullable2 = this.EnableMouseTracking;
            bool? nullable4 = this.EnableMouseTracking_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable4 = this.GetExtremesFromAll;
            nullable2 = this.GetExtremesFromAll_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            nullable1 = this.GroupZPadding;
            nullable3 = this.GroupZPadding_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "groupZPadding", (object) this.GroupZPadding);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable3 = this.Index;
            nullable1 = this.Index_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "index", (object) this.Index);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable1 = this.LegendIndex;
            nullable3 = this.LegendIndex_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            nullable3 = this.LineWidth;
            nullable1 = this.LineWidth_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable1 = this.MaxPointWidth;
            nullable3 = this.MaxPointWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "maxPointWidth", (object) this.MaxPointWidth);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable3 = this.PointInterval;
            nullable1 = this.PointInterval_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointInterval", (object) this.PointInterval);
            if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
                hashtable.Add((object) "pointIntervalUnit",
                    (object) Highcharts.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
            nullable1 = this.PointPadding;
            nullable3 = this.PointPadding_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointPadding", (object) this.PointPadding);
            if (this.PointPlacement.IsDirty())
                hashtable.Add((object) "pointPlacement", (object) this.PointPlacement.ToJSON());
            nullable3 = this.PointRange;
            nullable1 = this.PointRange_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointRange", (object) this.PointRange);
            nullable1 = this.PointStart;
            nullable3 = this.PointStart_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointStart", (object) this.PointStart);
            nullable3 = this.PointWidth;
            nullable1 = this.PointWidth_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "pointWidth", (object) this.PointWidth);
            nullable2 = this.Selected;
            nullable4 = this.Selected_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            if (this.StemColor != this.StemColor_DefaultValue)
                hashtable.Add((object) "stemColor", (object) this.StemColor);
            if (this.StemDashStyle != this.StemDashStyle_DefaultValue)
                hashtable.Add((object) "stemDashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.StemDashStyle.ToString()));
            nullable1 = this.StemWidth;
            nullable3 = this.StemWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "stemWidth", (object) this.StemWidth);
            nullable4 = this.StickyTracking;
            nullable2 = this.StickyTracking_DefaultValue;
            if ((nullable4.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable4.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable3 = this.TurboThreshold;
            nullable1 = this.TurboThreshold_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable2 = this.Visible;
            nullable4 = this.Visible_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable4.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable4.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.WhiskerColor != this.WhiskerColor_DefaultValue)
                hashtable.Add((object) "whiskerColor", (object) this.WhiskerColor);
            if (this.WhiskerLength != this.WhiskerLength_DefaultValue)
                hashtable.Add((object) "whiskerLength", (object) this.WhiskerLength);
            nullable1 = this.WhiskerWidth;
            nullable3 = this.WhiskerWidth_DefaultValue;
            if ((nullable1.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable1.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "whiskerWidth", (object) this.WhiskerWidth);
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
            nullable3 = this.ZIndex;
            nullable1 = this.ZIndex_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
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