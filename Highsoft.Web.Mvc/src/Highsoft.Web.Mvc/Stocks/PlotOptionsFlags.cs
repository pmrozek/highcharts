// Type: Highsoft.Web.Mvc.Stocks.PlotOptionsFlags


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptionsFlags : BaseObject
    {
        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public List<string> Colors { get; set; }

        private List<string> Colors_DefaultValue { get; set; }

        public double? CropThreshold { get; set; }

        private double? CropThreshold_DefaultValue { get; set; }

        public PlotOptionsFlagsCursor Cursor { get; set; }

        private PlotOptionsFlagsCursor Cursor_DefaultValue { get; set; }

        public PlotOptionsFlagsDataLabels DataLabels { get; set; }

        private PlotOptionsFlagsDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PlotOptionsFlagsEvents Events { get; set; }

        private PlotOptionsFlagsEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public double? MaxPointWidth { get; set; }

        private double? MaxPointWidth_DefaultValue { get; set; }

        public object NavigatorOptions { get; set; }

        private object NavigatorOptions_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public PlotOptionsFlagsOnKey OnKey { get; set; }

        private PlotOptionsFlagsOnKey OnKey_DefaultValue { get; set; }

        public string OnSeries { get; set; }

        private string OnSeries_DefaultValue { get; set; }

        public PlotOptionsFlagsPoint Point { get; set; }

        private PlotOptionsFlagsPoint Point_DefaultValue { get; set; }

        public PlotOptionsFlagsPointIntervalUnit PointIntervalUnit { get; set; }

        private PlotOptionsFlagsPointIntervalUnit PointIntervalUnit_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public PlotOptionsFlagsShape Shape { get; set; }

        private PlotOptionsFlagsShape Shape_DefaultValue { get; set; }

        public bool? ShowCheckbox { get; set; }

        private bool? ShowCheckbox_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public bool? ShowInNavigator { get; set; }

        private bool? ShowInNavigator_DefaultValue { get; set; }

        public bool? SoftThreshold { get; set; }

        private bool? SoftThreshold_DefaultValue { get; set; }

        public double? StackDistance { get; set; }

        private double? StackDistance_DefaultValue { get; set; }

        public PlotOptionsFlagsStates States { get; set; }

        private PlotOptionsFlagsStates States_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public PlotOptionsFlagsTextAlign TextAlign { get; set; }

        private PlotOptionsFlagsTextAlign TextAlign_DefaultValue { get; set; }

        public double? Threshold { get; set; }

        private double? Threshold_DefaultValue { get; set; }

        public string Title { get; set; }

        private string Title_DefaultValue { get; set; }

        public PlotOptionsFlagsTooltip Tooltip { get; set; }

        private PlotOptionsFlagsTooltip Tooltip_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public PlotOptionsFlagsZones Zones { get; set; }

        private PlotOptionsFlagsZones Zones_DefaultValue { get; set; }

        public PlotOptionsFlags()
        {
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            this.Colors = this.Colors_DefaultValue = new List<string>();
            nullable2 = new double?(50.0);
            this.CropThreshold_DefaultValue = nullable2;
            this.CropThreshold = nullable2;
            this.Cursor = this.Cursor_DefaultValue = PlotOptionsFlagsCursor.Null;
            this.DataLabels = this.DataLabels_DefaultValue = new PlotOptionsFlagsDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new PlotOptionsFlagsEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            nullable2 = new double?(0.0);
            this.LegendIndex_DefaultValue = nullable2;
            this.LegendIndex = nullable2;
            this.LineColor = this.LineColor_DefaultValue = "#000000";
            nullable2 = new double?(1.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            double? nullable3 = new double?();
            this.MaxPointWidth_DefaultValue = nullable3;
            this.MaxPointWidth = nullable3;
            this.NavigatorOptions = this.NavigatorOptions_DefaultValue = (object) null;
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            this.OnKey = this.OnKey_DefaultValue = PlotOptionsFlagsOnKey.Y;
            this.OnSeries = this.OnSeries_DefaultValue = "undefined";
            this.Point = this.Point_DefaultValue = new PlotOptionsFlagsPoint();
            this.PointIntervalUnit = this.PointIntervalUnit_DefaultValue = PlotOptionsFlagsPointIntervalUnit.Null;
            nullable1 = new bool?(false);
            this.Selected_DefaultValue = nullable1;
            this.Selected = nullable1;
            Shadow shadow1 = new Shadow();
            shadow1.Enabled = false;
            Shadow shadow2 = shadow1;
            this.Shadow_DefaultValue = shadow1;
            this.Shadow = shadow2;
            this.Shape = this.Shape_DefaultValue = PlotOptionsFlagsShape.Flag;
            nullable1 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable1;
            this.ShowCheckbox = nullable1;
            nullable1 = new bool?(true);
            this.ShowInLegend_DefaultValue = nullable1;
            this.ShowInLegend = nullable1;
            bool? nullable4 = new bool?();
            this.ShowInNavigator_DefaultValue = nullable4;
            this.ShowInNavigator = nullable4;
            nullable4 = new bool?(false);
            this.SoftThreshold_DefaultValue = nullable4;
            this.SoftThreshold = nullable4;
            nullable3 = new double?(12.0);
            this.StackDistance_DefaultValue = nullable3;
            this.StackDistance = nullable3;
            this.States = this.States_DefaultValue = new PlotOptionsFlagsStates();
            nullable4 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable4;
            this.StickyTracking = nullable4;
            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add((object) "fontSize", (object) "11px");
            hashtable1.Add((object) "fontWeight", (object) "bold");
            Hashtable hashtable2 = hashtable1;
            this.Style_DefaultValue = hashtable1;
            this.Style = hashtable2;
            this.TextAlign = this.TextAlign_DefaultValue = PlotOptionsFlagsTextAlign.Center;
            nullable3 = new double?(0.0);
            this.Threshold_DefaultValue = nullable3;
            this.Threshold = nullable3;
            this.Title = this.Title_DefaultValue = "A";
            this.Tooltip = this.Tooltip_DefaultValue = new PlotOptionsFlagsTooltip();
            nullable4 = new bool?(false);
            this.UseHTML_DefaultValue = nullable4;
            this.UseHTML = nullable4;
            nullable4 = new bool?(true);
            this.Visible_DefaultValue = nullable4;
            this.Visible = nullable4;
            nullable3 = new double?(-30.0);
            this.Y_DefaultValue = nullable3;
            this.Y = nullable3;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new PlotOptionsFlagsZones();
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
            if (this.Colors != this.Colors_DefaultValue)
                hashtable.Add((object) "colors", (object) this.Colors);
            nullable4 = this.CropThreshold;
            nullable3 = this.CropThreshold_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highstock.FirstCharacterToLower(this.Cursor.ToString()));
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
            nullable1 = this.GetExtremesFromAll;
            nullable2 = this.GetExtremesFromAll_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable3 = this.LegendIndex;
            nullable4 = this.LegendIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            nullable4 = this.LineWidth;
            nullable3 = this.LineWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable3 = this.MaxPointWidth;
            nullable4 = this.MaxPointWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "maxPointWidth", (object) this.MaxPointWidth);
            if (this.NavigatorOptions != this.NavigatorOptions_DefaultValue)
                hashtable.Add((object) "navigatorOptions", this.NavigatorOptions);
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            if (this.OnKey != this.OnKey_DefaultValue)
                hashtable.Add((object) "onKey", (object) Highstock.FirstCharacterToLower(this.OnKey.ToString()));
            if (this.OnSeries != this.OnSeries_DefaultValue)
                hashtable.Add((object) "onSeries", (object) this.OnSeries);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
                hashtable.Add((object) "pointIntervalUnit",
                    (object) Highstock.FirstCharacterToLower(this.PointIntervalUnit.ToString()));
            nullable2 = this.Selected;
            nullable1 = this.Selected_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            if (this.Shape != this.Shape_DefaultValue)
                hashtable.Add((object) "shape", (object) Highstock.FirstCharacterToLower(this.Shape.ToString()));
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
            nullable1 = this.ShowInNavigator;
            nullable2 = this.ShowInNavigator_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "showInNavigator", (object) this.ShowInNavigator);
            nullable2 = this.SoftThreshold;
            nullable1 = this.SoftThreshold_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "softThreshold", (object) this.SoftThreshold);
            nullable4 = this.StackDistance;
            nullable3 = this.StackDistance_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "stackDistance", (object) this.StackDistance);
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            nullable1 = this.StickyTracking;
            nullable2 = this.StickyTracking_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.TextAlign != this.TextAlign_DefaultValue)
                hashtable.Add((object) "textAlign", (object) Highstock.FirstCharacterToLower(this.TextAlign.ToString()));
            nullable3 = this.Threshold;
            nullable4 = this.Threshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Title != this.Title_DefaultValue)
                hashtable.Add((object) "title", (object) this.Title);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            nullable1 = this.Visible;
            nullable2 = this.Visible_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            nullable4 = this.Y;
            nullable3 = this.Y_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
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