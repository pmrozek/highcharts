// Type: Highsoft.Web.Mvc.Charts.PlotOptionsErrorbar


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsErrorbar : BaseObject
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

        public PlotOptionsErrorbarCursor Cursor { get; set; }

        private PlotOptionsErrorbarCursor Cursor_DefaultValue { get; set; }

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

        public PlotOptionsErrorbarEvents Events { get; set; }

        private PlotOptionsErrorbarEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public double? GroupZPadding { get; set; }

        private double? GroupZPadding_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public double? MaxPointWidth { get; set; }

        private double? MaxPointWidth_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public PlotOptionsErrorbarPoint Point { get; set; }

        private PlotOptionsErrorbarPoint Point_DefaultValue { get; set; }

        public double? PointInterval { get; set; }

        private double? PointInterval_DefaultValue { get; set; }

        public PlotOptionsErrorbarPointIntervalUnit PointIntervalUnit { get; set; }

        private PlotOptionsErrorbarPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

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

        public PlotOptionsErrorbarStates States { get; set; }

        private PlotOptionsErrorbarStates States_DefaultValue { get; set; }

        public string StemColor { get; set; }

        private string StemColor_DefaultValue { get; set; }

        public PlotOptionsErrorbarStemDashStyle StemDashStyle { get; set; }

        private PlotOptionsErrorbarStemDashStyle StemDashStyle_DefaultValue { get; set; }

        public double? StemWidth { get; set; }

        private double? StemWidth_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public PlotOptionsErrorbarTooltip Tooltip { get; set; }

        private PlotOptionsErrorbarTooltip Tooltip_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public string WhiskerColor { get; set; }

        private string WhiskerColor_DefaultValue { get; set; }

        public string WhiskerLength { get; set; }

        private string WhiskerLength_DefaultValue { get; set; }

        public double? WhiskerWidth { get; set; }

        private double? WhiskerWidth_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public PlotOptionsErrorbarZones Zones { get; set; }

        private PlotOptionsErrorbarZones Zones_DefaultValue { get; set; }

        public PlotOptionsErrorbar()
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
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsErrorbarCursor.Null;
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
            this.Events = this.Events_DefaultValue = new PlotOptionsErrorbarEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            nullable2 = new double?(1.0);
            this.GroupZPadding_DefaultValue = nullable2;
            this.GroupZPadding = nullable2;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            nullable2 = new double?(1.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            this.LinkedTo = this.LinkedTo_DefaultValue = ":previous";
            double? nullable3 = new double?();
            this.MaxPointWidth_DefaultValue = nullable3;
            this.MaxPointWidth = nullable3;
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.Point = this.Point_DefaultValue = new PlotOptionsErrorbarPoint();
            nullable3 = new double?(1.0);
            this.PointInterval_DefaultValue = nullable3;
            this.PointInterval = nullable3;
            this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsErrorbarPointIntervalUnit.Null;
            nullable3 = new double?(0.1);
            this.PointPadding_DefaultValue = nullable3;
            this.PointPadding = nullable3;
            this.PointPlacement = this.PointPlacement_DefaultValue = new PointPlacement();
            double? nullable4 = new double?();
            this.PointRange_DefaultValue = nullable4;
            this.PointRange = nullable4;
            nullable4 = new double?(0.0);
            this.PointStart_DefaultValue = nullable4;
            this.PointStart = nullable4;
            double? nullable5 = new double?();
            this.PointWidth_DefaultValue = nullable5;
            this.PointWidth = nullable5;
            nullable1 = new bool?(false);
            this.Selected_DefaultValue = nullable1;
            this.Selected = nullable1;
            this.States = this.States_DefaultValue = new PlotOptionsErrorbarStates();
            this.StemColor = this.StemColor_DefaultValue = "null";
            this.StemDashStyle = this.StemDashStyle_DefaultValue = PlotOptionsErrorbarStemDashStyle.Solid;
            double? nullable6 = new double?();
            this.StemWidth_DefaultValue = nullable6;
            this.StemWidth = nullable6;
            nullable1 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable1;
            this.StickyTracking = nullable1;
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsErrorbarTooltip();
            nullable6 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable6;
            this.TurboThreshold = nullable6;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
            this.WhiskerColor = this.WhiskerColor_DefaultValue = "null";
            this.WhiskerLength = this.WhiskerLength_DefaultValue = "50%";
            double? nullable7 = new double?();
            this.WhiskerWidth_DefaultValue = nullable7;
            this.WhiskerWidth = nullable7;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new PlotOptionsErrorbarZones();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AllowPointSelect;
            bool? nullable2 = this.AllowPointSelect_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
            double? nullable3 = this.AnimationLimit;
            double? nullable4 = this.AnimationLimit_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
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
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            nullable4 = this.Depth;
            nullable3 = this.Depth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "depth", (object) this.Depth);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.EdgeColor != this.EdgeColor_DefaultValue)
                hashtable.Add((object) "edgeColor", (object) this.EdgeColor);
            nullable3 = this.EdgeWidth;
            nullable4 = this.EdgeWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
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
            nullable4 = this.GroupZPadding;
            nullable3 = this.GroupZPadding_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "groupZPadding", (object) this.GroupZPadding);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable3 = this.LineWidth;
            nullable4 = this.LineWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable4 = this.MaxPointWidth;
            nullable3 = this.MaxPointWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "maxPointWidth", (object) this.MaxPointWidth);
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
            nullable1 = this.Selected;
            nullable2 = this.Selected_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            if (this.StemColor != this.StemColor_DefaultValue)
                hashtable.Add((object) "stemColor", (object) this.StemColor);
            if (this.StemDashStyle != this.StemDashStyle_DefaultValue)
                hashtable.Add((object) "stemDashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.StemDashStyle.ToString()));
            nullable4 = this.StemWidth;
            nullable3 = this.StemWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "stemWidth", (object) this.StemWidth);
            nullable2 = this.StickyTracking;
            nullable1 = this.StickyTracking_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable3 = this.TurboThreshold;
            nullable4 = this.TurboThreshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            nullable1 = this.Visible;
            nullable2 = this.Visible_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.WhiskerColor != this.WhiskerColor_DefaultValue)
                hashtable.Add((object) "whiskerColor", (object) this.WhiskerColor);
            if (this.WhiskerLength != this.WhiskerLength_DefaultValue)
                hashtable.Add((object) "whiskerLength", (object) this.WhiskerLength);
            nullable4 = this.WhiskerWidth;
            nullable3 = this.WhiskerWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "whiskerWidth", (object) this.WhiskerWidth);
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