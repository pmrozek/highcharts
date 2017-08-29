// Type: Highsoft.Web.Mvc.Charts.YAxis


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class YAxis : BaseObject
    {
        public YAxis()
        {
            bool? nullable1 = new bool?(true);
            this.AllowDecimals_DefaultValue = nullable1;
            this.AllowDecimals = nullable1;
            this.AlternateGridColor = this.AlternateGridColor_DefaultValue = (string) null;
            double? nullable2 = new double?(0.0);
            this.Angle_DefaultValue = nullable2;
            this.Angle = nullable2;
            this.Breaks = this.Breaks_DefaultValue = new YAxisBreaks();
            this.Categories = this.Categories_DefaultValue = (List<string>) null;
            double? nullable3 = new double?();
            this.Ceiling_DefaultValue = nullable3;
            this.Ceiling = nullable3;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Crosshair = this.Crosshair_DefaultValue = new YAxisCrosshair();
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EndOnTick_DefaultValue = nullable1;
            this.EndOnTick = nullable1;
            this.Events = this.Events_DefaultValue = new YAxisEvents();
            double? nullable4 = new double?();
            this.Floor_DefaultValue = nullable4;
            this.Floor = nullable4;
            this.GridLineColor = this.GridLineColor_DefaultValue = "#e6e6e6";
            this.GridLineDashStyle = this.GridLineDashStyle_DefaultValue = YAxisGridLineDashStyle.Solid;
            this.GridLineInterpolation = this.GridLineInterpolation_DefaultValue = YAxisGridLineInterpolation.Null;
            nullable4 = new double?(1.0);
            this.GridLineWidth_DefaultValue = nullable4;
            this.GridLineWidth = nullable4;
            nullable4 = new double?(1.0);
            this.GridZIndex_DefaultValue = nullable4;
            this.GridZIndex = nullable4;
            this.Id = this.Id_DefaultValue = (string) null;
            this.Labels = this.Labels_DefaultValue = new YAxisLabels();
            this.LineColor = this.LineColor_DefaultValue = "#ccd6eb";
            nullable4 = new double?(0.0);
            this.LineWidth_DefaultValue = nullable4;
            this.LineWidth = nullable4;
            double? nullable5 = new double?();
            this.LinkedTo_DefaultValue = nullable5;
            this.LinkedTo = nullable5;
            double? nullable6 = new double?();
            this.Max_DefaultValue = nullable6;
            this.Max = nullable6;
            this.MaxColor = this.MaxColor_DefaultValue = "#003399";
            nullable6 = new double?(0.05);
            this.MaxPadding_DefaultValue = nullable6;
            this.MaxPadding = nullable6;
            double? nullable7 = new double?();
            this.Min_DefaultValue = nullable7;
            this.Min = nullable7;
            this.MinColor = this.MinColor_DefaultValue = "#e6ebf5";
            nullable7 = new double?(0.05);
            this.MinPadding_DefaultValue = nullable7;
            this.MinPadding = nullable7;
            double? nullable8 = new double?();
            this.MinRange_DefaultValue = nullable8;
            this.MinRange = nullable8;
            double? nullable9 = new double?();
            this.MinTickInterval_DefaultValue = nullable9;
            this.MinTickInterval = nullable9;
            this.MinorGridLineColor = this.MinorGridLineColor_DefaultValue = "#f2f2f2";
            this.MinorGridLineDashStyle = this.MinorGridLineDashStyle_DefaultValue = YAxisMinorGridLineDashStyle.Solid;
            nullable9 = new double?(1.0);
            this.MinorGridLineWidth_DefaultValue = nullable9;
            this.MinorGridLineWidth = nullable9;
            this.MinorTickColor = this.MinorTickColor_DefaultValue = "#999999";
            this.MinorTickInterval = this.MinorTickInterval_DefaultValue = (string) null;
            nullable9 = new double?(2.0);
            this.MinorTickLength_DefaultValue = nullable9;
            this.MinorTickLength = nullable9;
            this.MinorTickPosition = this.MinorTickPosition_DefaultValue = YAxisMinorTickPosition.Outside;
            nullable9 = new double?(0.0);
            this.MinorTickWidth_DefaultValue = nullable9;
            this.MinorTickWidth = nullable9;
            nullable9 = new double?(0.0);
            this.Offset_DefaultValue = nullable9;
            this.Offset = nullable9;
            nullable1 = new bool?(false);
            this.Opposite_DefaultValue = nullable1;
            this.Opposite = nullable1;
            this.PlotBands = this.PlotBands_DefaultValue = new List<YAxisPlotBands>();
            this.PlotLines = this.PlotLines_DefaultValue = new List<YAxisPlotLines>();
            nullable1 = new bool?(false);
            this.Reversed_DefaultValue = nullable1;
            this.Reversed = nullable1;
            nullable1 = new bool?(true);
            this.ReversedStacks_DefaultValue = nullable1;
            this.ReversedStacks = nullable1;
            nullable1 = new bool?(true);
            this.ShowEmpty_DefaultValue = nullable1;
            this.ShowEmpty = nullable1;
            nullable1 = new bool?(true);
            this.ShowFirstLabel_DefaultValue = nullable1;
            this.ShowFirstLabel = nullable1;
            bool? nullable10 = new bool?();
            this.ShowLastLabel_DefaultValue = nullable10;
            this.ShowLastLabel = nullable10;
            double? nullable11 = new double?();
            this.SoftMax_DefaultValue = nullable11;
            this.SoftMax = nullable11;
            double? nullable12 = new double?();
            this.SoftMin_DefaultValue = nullable12;
            this.SoftMin = nullable12;
            this.StackLabels = this.StackLabels_DefaultValue = new YAxisStackLabels();
            nullable12 = new double?(1.0);
            this.StartOfWeek_DefaultValue = nullable12;
            this.StartOfWeek = nullable12;
            nullable10 = new bool?(true);
            this.StartOnTick_DefaultValue = nullable10;
            this.StartOnTick = nullable10;
            this.Stops = this.Stops_DefaultValue = new List<Stop>();
            double? nullable13 = new double?();
            this.TickAmount_DefaultValue = nullable13;
            this.TickAmount = nullable13;
            this.TickColor = this.TickColor_DefaultValue = "#ccd6eb";
            double? nullable14 = new double?();
            this.TickInterval_DefaultValue = nullable14;
            this.TickInterval = nullable14;
            nullable14 = new double?(10.0);
            this.TickLength_DefaultValue = nullable14;
            this.TickLength = nullable14;
            double? nullable15 = new double?();
            this.TickPixelInterval_DefaultValue = nullable15;
            this.TickPixelInterval = nullable15;
            this.TickPosition = this.TickPosition_DefaultValue = YAxisTickPosition.Outside;
            this.TickPositioner = this.TickPositioner_DefaultValue = "";
            this.TickPositions = this.TickPositions_DefaultValue = (List<double>) null;
            nullable15 = new double?(0.0);
            this.TickWidth_DefaultValue = nullable15;
            this.TickWidth = nullable15;
            this.TickmarkPlacement = this.TickmarkPlacement_DefaultValue = YAxisTickmarkPlacement.Null;
            this.Title = this.Title_DefaultValue = new YAxisTitle();
            this.Type = this.Type_DefaultValue = YAxisType.Linear;
            nullable10 = new bool?(true);
            this.Visible_DefaultValue = nullable10;
            this.Visible = nullable10;
        }

        public bool? AllowDecimals { get; set; }

        private bool? AllowDecimals_DefaultValue { get; set; }

        public string AlternateGridColor { get; set; }

        private string AlternateGridColor_DefaultValue { get; set; }

        public double? Angle { get; set; }

        private double? Angle_DefaultValue { get; set; }

        public YAxisBreaks Breaks { get; set; }

        private YAxisBreaks Breaks_DefaultValue { get; set; }

        public List<string> Categories { get; set; }

        private List<string> Categories_DefaultValue { get; set; }

        public double? Ceiling { get; set; }

        private double? Ceiling_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public YAxisCrosshair Crosshair { get; set; }

        private YAxisCrosshair Crosshair_DefaultValue { get; set; }

        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EndOnTick { get; set; }

        private bool? EndOnTick_DefaultValue { get; set; }

        public YAxisEvents Events { get; set; }

        private YAxisEvents Events_DefaultValue { get; set; }

        public double? Floor { get; set; }

        private double? Floor_DefaultValue { get; set; }

        public string GridLineColor { get; set; }

        private string GridLineColor_DefaultValue { get; set; }

        public YAxisGridLineDashStyle GridLineDashStyle { get; set; }

        private YAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }

        public YAxisGridLineInterpolation GridLineInterpolation { get; set; }

        private YAxisGridLineInterpolation GridLineInterpolation_DefaultValue { get; set; }

        public double? GridLineWidth { get; set; }

        private double? GridLineWidth_DefaultValue { get; set; }

        public double? GridZIndex { get; set; }

        private double? GridZIndex_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public YAxisLabels Labels { get; set; }

        private YAxisLabels Labels_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public double? LinkedTo { get; set; }

        private double? LinkedTo_DefaultValue { get; set; }

        public double? Max { get; set; }

        private double? Max_DefaultValue { get; set; }

        public string MaxColor { get; set; }

        private string MaxColor_DefaultValue { get; set; }

        public double? MaxPadding { get; set; }

        private double? MaxPadding_DefaultValue { get; set; }

        public double? Min { get; set; }

        private double? Min_DefaultValue { get; set; }

        public string MinColor { get; set; }

        private string MinColor_DefaultValue { get; set; }

        public double? MinPadding { get; set; }

        private double? MinPadding_DefaultValue { get; set; }

        public double? MinRange { get; set; }

        private double? MinRange_DefaultValue { get; set; }

        public double? MinTickInterval { get; set; }

        private double? MinTickInterval_DefaultValue { get; set; }

        public string MinorGridLineColor { get; set; }

        private string MinorGridLineColor_DefaultValue { get; set; }

        public YAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }

        private YAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }

        public double? MinorGridLineWidth { get; set; }

        private double? MinorGridLineWidth_DefaultValue { get; set; }

        public string MinorTickColor { get; set; }

        private string MinorTickColor_DefaultValue { get; set; }

        public string MinorTickInterval { get; set; }

        private string MinorTickInterval_DefaultValue { get; set; }

        public double? MinorTickLength { get; set; }

        private double? MinorTickLength_DefaultValue { get; set; }

        public YAxisMinorTickPosition MinorTickPosition { get; set; }

        private YAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }

        public double? MinorTickWidth { get; set; }

        private double? MinorTickWidth_DefaultValue { get; set; }

        public double? Offset { get; set; }

        private double? Offset_DefaultValue { get; set; }

        public bool? Opposite { get; set; }

        private bool? Opposite_DefaultValue { get; set; }

        public List<YAxisPlotBands> PlotBands { get; set; }

        private List<YAxisPlotBands> PlotBands_DefaultValue { get; set; }

        public List<YAxisPlotLines> PlotLines { get; set; }

        private List<YAxisPlotLines> PlotLines_DefaultValue { get; set; }

        public bool? Reversed { get; set; }

        private bool? Reversed_DefaultValue { get; set; }

        public bool? ReversedStacks { get; set; }

        private bool? ReversedStacks_DefaultValue { get; set; }

        public bool? ShowEmpty { get; set; }

        private bool? ShowEmpty_DefaultValue { get; set; }

        public bool? ShowFirstLabel { get; set; }

        private bool? ShowFirstLabel_DefaultValue { get; set; }

        public bool? ShowLastLabel { get; set; }

        private bool? ShowLastLabel_DefaultValue { get; set; }

        public double? SoftMax { get; set; }

        private double? SoftMax_DefaultValue { get; set; }

        public double? SoftMin { get; set; }

        private double? SoftMin_DefaultValue { get; set; }

        public YAxisStackLabels StackLabels { get; set; }

        private YAxisStackLabels StackLabels_DefaultValue { get; set; }

        public double? StartOfWeek { get; set; }

        private double? StartOfWeek_DefaultValue { get; set; }

        public bool? StartOnTick { get; set; }

        private bool? StartOnTick_DefaultValue { get; set; }

        public List<Stop> Stops { get; set; }

        private List<Stop> Stops_DefaultValue { get; set; }

        public double? TickAmount { get; set; }

        private double? TickAmount_DefaultValue { get; set; }

        public string TickColor { get; set; }

        private string TickColor_DefaultValue { get; set; }

        public double? TickInterval { get; set; }

        private double? TickInterval_DefaultValue { get; set; }

        public double? TickLength { get; set; }

        private double? TickLength_DefaultValue { get; set; }

        public double? TickPixelInterval { get; set; }

        private double? TickPixelInterval_DefaultValue { get; set; }

        public YAxisTickPosition TickPosition { get; set; }

        private YAxisTickPosition TickPosition_DefaultValue { get; set; }

        public string TickPositioner { get; set; }

        private string TickPositioner_DefaultValue { get; set; }

        public List<double> TickPositions { get; set; }

        private List<double> TickPositions_DefaultValue { get; set; }

        public double? TickWidth { get; set; }

        private double? TickWidth_DefaultValue { get; set; }

        public YAxisTickmarkPlacement TickmarkPlacement { get; set; }

        private YAxisTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }

        public YAxisTitle Title { get; set; }

        private YAxisTitle Title_DefaultValue { get; set; }

        public YAxisType Type { get; set; }

        private YAxisType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AllowDecimals;
            bool? nullable2 = this.AllowDecimals_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allowDecimals", (object) this.AllowDecimals);
            if (this.AlternateGridColor != this.AlternateGridColor_DefaultValue)
                hashtable.Add((object) "alternateGridColor", (object) this.AlternateGridColor);
            double? nullable3 = this.Angle;
            double? nullable4 = this.Angle_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "angle", (object) this.Angle);
            if (this.Breaks.IsDirty())
                hashtable.Add((object) "breaks", (object) this.Breaks.ToHashtable());
            if (this.Categories != this.Categories_DefaultValue)
                hashtable.Add((object) "categories", (object) this.Categories);
            nullable4 = this.Ceiling;
            nullable3 = this.Ceiling_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "ceiling", (object) this.Ceiling);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Crosshair.IsDirty())
                hashtable.Add((object) "crosshair", (object) this.Crosshair.ToHashtable());
            if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
                hashtable.Add((object) "dateTimeLabelFormats", (object) this.DateTimeLabelFormats);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            nullable2 = this.EndOnTick;
            nullable1 = this.EndOnTick_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "endOnTick", (object) this.EndOnTick);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable3 = this.Floor;
            nullable4 = this.Floor_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "floor", (object) this.Floor);
            if (this.GridLineColor != this.GridLineColor_DefaultValue)
                hashtable.Add((object) "gridLineColor", (object) this.GridLineColor);
            if (this.GridLineDashStyle != this.GridLineDashStyle_DefaultValue)
                hashtable.Add((object) "gridLineDashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.GridLineDashStyle.ToString()));
            if (this.GridLineInterpolation != this.GridLineInterpolation_DefaultValue)
                hashtable.Add((object) "gridLineInterpolation",
                    (object) Highcharts.FirstCharacterToLower(this.GridLineInterpolation.ToString()));
            nullable4 = this.GridLineWidth;
            nullable3 = this.GridLineWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "gridLineWidth", (object) this.GridLineWidth);
            nullable3 = this.GridZIndex;
            nullable4 = this.GridZIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "gridZIndex", (object) this.GridZIndex);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            if (this.Labels.IsDirty())
                hashtable.Add((object) "labels", (object) this.Labels.ToHashtable());
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            nullable4 = this.LineWidth;
            nullable3 = this.LineWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            nullable3 = this.LinkedTo;
            nullable4 = this.LinkedTo_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable4 = this.Max;
            nullable3 = this.Max_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "max", (object) this.Max);
            if (this.MaxColor != this.MaxColor_DefaultValue)
                hashtable.Add((object) "maxColor", (object) this.MaxColor);
            nullable3 = this.MaxPadding;
            nullable4 = this.MaxPadding_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "maxPadding", (object) this.MaxPadding);
            nullable4 = this.Min;
            nullable3 = this.Min_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "min", (object) this.Min);
            if (this.MinColor != this.MinColor_DefaultValue)
                hashtable.Add((object) "minColor", (object) this.MinColor);
            nullable3 = this.MinPadding;
            nullable4 = this.MinPadding_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "minPadding", (object) this.MinPadding);
            nullable4 = this.MinRange;
            nullable3 = this.MinRange_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minRange", (object) this.MinRange);
            nullable3 = this.MinTickInterval;
            nullable4 = this.MinTickInterval_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "minTickInterval", (object) this.MinTickInterval);
            if (this.MinorGridLineColor != this.MinorGridLineColor_DefaultValue)
                hashtable.Add((object) "minorGridLineColor", (object) this.MinorGridLineColor);
            if (this.MinorGridLineDashStyle != this.MinorGridLineDashStyle_DefaultValue)
                hashtable.Add((object) "minorGridLineDashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.MinorGridLineDashStyle.ToString()));
            nullable4 = this.MinorGridLineWidth;
            nullable3 = this.MinorGridLineWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minorGridLineWidth", (object) this.MinorGridLineWidth);
            if (this.MinorTickColor != this.MinorTickColor_DefaultValue)
                hashtable.Add((object) "minorTickColor", (object) this.MinorTickColor);
            if (this.MinorTickInterval != this.MinorTickInterval_DefaultValue)
                hashtable.Add((object) "minorTickInterval", (object) this.MinorTickInterval);
            nullable3 = this.MinorTickLength;
            nullable4 = this.MinorTickLength_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "minorTickLength", (object) this.MinorTickLength);
            if (this.MinorTickPosition != this.MinorTickPosition_DefaultValue)
                hashtable.Add((object) "minorTickPosition",
                    (object) Highcharts.FirstCharacterToLower(this.MinorTickPosition.ToString()));
            nullable4 = this.MinorTickWidth;
            nullable3 = this.MinorTickWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minorTickWidth", (object) this.MinorTickWidth);
            nullable3 = this.Offset;
            nullable4 = this.Offset_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "offset", (object) this.Offset);
            nullable1 = this.Opposite;
            nullable2 = this.Opposite_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "opposite", (object) this.Opposite);
            if (this.PlotBands != this.PlotBands_DefaultValue)
                hashtable.Add((object) "plotBands", (object) this.HashifyList((IEnumerable) this.PlotBands));
            if (this.PlotLines != this.PlotLines_DefaultValue)
                hashtable.Add((object) "plotLines", (object) this.HashifyList((IEnumerable) this.PlotLines));
            nullable2 = this.Reversed;
            nullable1 = this.Reversed_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "reversed", (object) this.Reversed);
            nullable1 = this.ReversedStacks;
            nullable2 = this.ReversedStacks_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "reversedStacks", (object) this.ReversedStacks);
            nullable2 = this.ShowEmpty;
            nullable1 = this.ShowEmpty_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showEmpty", (object) this.ShowEmpty);
            nullable1 = this.ShowFirstLabel;
            nullable2 = this.ShowFirstLabel_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "showFirstLabel", (object) this.ShowFirstLabel);
            nullable2 = this.ShowLastLabel;
            nullable1 = this.ShowLastLabel_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showLastLabel", (object) this.ShowLastLabel);
            nullable4 = this.SoftMax;
            nullable3 = this.SoftMax_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "softMax", (object) this.SoftMax);
            nullable3 = this.SoftMin;
            nullable4 = this.SoftMin_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "softMin", (object) this.SoftMin);
            if (this.StackLabels.IsDirty())
                hashtable.Add((object) "stackLabels", (object) this.StackLabels.ToHashtable());
            nullable4 = this.StartOfWeek;
            nullable3 = this.StartOfWeek_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "startOfWeek", (object) this.StartOfWeek);
            nullable1 = this.StartOnTick;
            nullable2 = this.StartOnTick_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "startOnTick", (object) this.StartOnTick);
            if (this.Stops.Any<Stop>())
                hashtable.Add((object) "stops", (object) this.GetLists((IEnumerable) this.Stops));
            nullable3 = this.TickAmount;
            nullable4 = this.TickAmount_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "tickAmount", (object) this.TickAmount);
            if (this.TickColor != this.TickColor_DefaultValue)
                hashtable.Add((object) "tickColor", (object) this.TickColor);
            nullable4 = this.TickInterval;
            nullable3 = this.TickInterval_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "tickInterval", (object) this.TickInterval);
            nullable3 = this.TickLength;
            nullable4 = this.TickLength_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "tickLength", (object) this.TickLength);
            nullable4 = this.TickPixelInterval;
            nullable3 = this.TickPixelInterval_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "tickPixelInterval", (object) this.TickPixelInterval);
            if (this.TickPosition != this.TickPosition_DefaultValue)
                hashtable.Add((object) "tickPosition",
                    (object) Highcharts.FirstCharacterToLower(this.TickPosition.ToString()));
            if (this.TickPositioner != this.TickPositioner_DefaultValue)
            {
                hashtable.Add((object) "tickPositioner", (object) this.TickPositioner);
                Highcharts.AddFunction("YAxisTickPositioner.tickPositioner", this.TickPositioner);
            }
            if (this.TickPositions != this.TickPositions_DefaultValue)
                hashtable.Add((object) "tickPositions", (object) this.TickPositions);
            nullable3 = this.TickWidth;
            nullable4 = this.TickWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "tickWidth", (object) this.TickWidth);
            if (this.TickmarkPlacement != this.TickmarkPlacement_DefaultValue)
                hashtable.Add((object) "tickmarkPlacement",
                    (object) Highcharts.FirstCharacterToLower(this.TickmarkPlacement.ToString()));
            if (this.Title.IsDirty())
                hashtable.Add((object) "title", (object) this.Title.ToHashtable());
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable2 = this.Visible;
            nullable1 = this.Visible_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
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