// Type: Highsoft.Web.Mvc.Charts.ZAxis


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ZAxis : BaseObject
    {
        public bool? AllowDecimals { get; set; }

        private bool? AllowDecimals_DefaultValue { get; set; }

        public string AlternateGridColor { get; set; }

        private string AlternateGridColor_DefaultValue { get; set; }

        public List<string> Categories { get; set; }

        private List<string> Categories_DefaultValue { get; set; }

        public double? Ceiling { get; set; }

        private double? Ceiling_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public ZAxisCrosshair Crosshair { get; set; }

        private ZAxisCrosshair Crosshair_DefaultValue { get; set; }

        public Hashtable DateTimeLabelFormats { get; set; }

        private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EndOnTick { get; set; }

        private bool? EndOnTick_DefaultValue { get; set; }

        public ZAxisEvents Events { get; set; }

        private ZAxisEvents Events_DefaultValue { get; set; }

        public double? Floor { get; set; }

        private double? Floor_DefaultValue { get; set; }

        public string GridLineColor { get; set; }

        private string GridLineColor_DefaultValue { get; set; }

        public ZAxisGridLineDashStyle GridLineDashStyle { get; set; }

        private ZAxisGridLineDashStyle GridLineDashStyle_DefaultValue { get; set; }

        public double? GridLineWidth { get; set; }

        private double? GridLineWidth_DefaultValue { get; set; }

        public double? GridZIndex { get; set; }

        private double? GridZIndex_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public ZAxisLabels Labels { get; set; }

        private ZAxisLabels Labels_DefaultValue { get; set; }

        public string LineColor { get; set; }

        private string LineColor_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public double? LinkedTo { get; set; }

        private double? LinkedTo_DefaultValue { get; set; }

        public double? Max { get; set; }

        private double? Max_DefaultValue { get; set; }

        public double? MaxPadding { get; set; }

        private double? MaxPadding_DefaultValue { get; set; }

        public double? Min { get; set; }

        private double? Min_DefaultValue { get; set; }

        public double? MinPadding { get; set; }

        private double? MinPadding_DefaultValue { get; set; }

        public double? MinRange { get; set; }

        private double? MinRange_DefaultValue { get; set; }

        public double? MinTickInterval { get; set; }

        private double? MinTickInterval_DefaultValue { get; set; }

        public string MinorGridLineColor { get; set; }

        private string MinorGridLineColor_DefaultValue { get; set; }

        public ZAxisMinorGridLineDashStyle MinorGridLineDashStyle { get; set; }

        private ZAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue { get; set; }

        public double? MinorGridLineWidth { get; set; }

        private double? MinorGridLineWidth_DefaultValue { get; set; }

        public string MinorTickColor { get; set; }

        private string MinorTickColor_DefaultValue { get; set; }

        public string MinorTickInterval { get; set; }

        private string MinorTickInterval_DefaultValue { get; set; }

        public double? MinorTickLength { get; set; }

        private double? MinorTickLength_DefaultValue { get; set; }

        public ZAxisMinorTickPosition MinorTickPosition { get; set; }

        private ZAxisMinorTickPosition MinorTickPosition_DefaultValue { get; set; }

        public double? MinorTickWidth { get; set; }

        private double? MinorTickWidth_DefaultValue { get; set; }

        public bool? NameToX { get; set; }

        private bool? NameToX_DefaultValue { get; set; }

        public double? Offset { get; set; }

        private double? Offset_DefaultValue { get; set; }

        public bool? Opposite { get; set; }

        private bool? Opposite_DefaultValue { get; set; }

        public ZAxisPlotBands PlotBands { get; set; }

        private ZAxisPlotBands PlotBands_DefaultValue { get; set; }

        public ZAxisPlotLines PlotLines { get; set; }

        private ZAxisPlotLines PlotLines_DefaultValue { get; set; }

        public bool? Reversed { get; set; }

        private bool? Reversed_DefaultValue { get; set; }

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

        public double? StartOfWeek { get; set; }

        private double? StartOfWeek_DefaultValue { get; set; }

        public bool? StartOnTick { get; set; }

        private bool? StartOnTick_DefaultValue { get; set; }

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

        public ZAxisTickPosition TickPosition { get; set; }

        private ZAxisTickPosition TickPosition_DefaultValue { get; set; }

        public string TickPositioner { get; set; }

        private string TickPositioner_DefaultValue { get; set; }

        public List<double> TickPositions { get; set; }

        private List<double> TickPositions_DefaultValue { get; set; }

        public double? TickWidth { get; set; }

        private double? TickWidth_DefaultValue { get; set; }

        public ZAxisTickmarkPlacement TickmarkPlacement { get; set; }

        private ZAxisTickmarkPlacement TickmarkPlacement_DefaultValue { get; set; }

        public ZAxisTitle Title { get; set; }

        private ZAxisTitle Title_DefaultValue { get; set; }

        public ZAxisType Type { get; set; }

        private ZAxisType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public ZAxis()
        {
            bool? nullable1 = new bool?(true);
            this.AllowDecimals_DefaultValue = nullable1;
            this.AllowDecimals = nullable1;
            this.AlternateGridColor = this.AlternateGridColor_DefaultValue = (string) null;
            this.Categories = this.Categories_DefaultValue = (List<string>) null;
            double? nullable2 = new double?();
            this.Ceiling_DefaultValue = nullable2;
            this.Ceiling = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Crosshair = this.Crosshair_DefaultValue = new ZAxisCrosshair();
            this.DateTimeLabelFormats = this.DateTimeLabelFormats_DefaultValue = new Hashtable();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(false);
            this.EndOnTick_DefaultValue = nullable1;
            this.EndOnTick = nullable1;
            this.Events = this.Events_DefaultValue = new ZAxisEvents();
            double? nullable3 = new double?();
            this.Floor_DefaultValue = nullable3;
            this.Floor = nullable3;
            this.GridLineColor = this.GridLineColor_DefaultValue = "#e6e6e6";
            this.GridLineDashStyle = this.GridLineDashStyle_DefaultValue = ZAxisGridLineDashStyle.Solid;
            nullable3 = new double?(0.0);
            this.GridLineWidth_DefaultValue = nullable3;
            this.GridLineWidth = nullable3;
            nullable3 = new double?(1.0);
            this.GridZIndex_DefaultValue = nullable3;
            this.GridZIndex = nullable3;
            this.Id = this.Id_DefaultValue = (string) null;
            this.Labels = this.Labels_DefaultValue = new ZAxisLabels();
            this.LineColor = this.LineColor_DefaultValue = "#ccd6eb";
            nullable3 = new double?(1.0);
            this.LineWidth_DefaultValue = nullable3;
            this.LineWidth = nullable3;
            double? nullable4 = new double?();
            this.LinkedTo_DefaultValue = nullable4;
            this.LinkedTo = nullable4;
            double? nullable5 = new double?();
            this.Max_DefaultValue = nullable5;
            this.Max = nullable5;
            nullable5 = new double?(0.01);
            this.MaxPadding_DefaultValue = nullable5;
            this.MaxPadding = nullable5;
            double? nullable6 = new double?();
            this.Min_DefaultValue = nullable6;
            this.Min = nullable6;
            nullable6 = new double?(0.01);
            this.MinPadding_DefaultValue = nullable6;
            this.MinPadding = nullable6;
            double? nullable7 = new double?();
            this.MinRange_DefaultValue = nullable7;
            this.MinRange = nullable7;
            double? nullable8 = new double?();
            this.MinTickInterval_DefaultValue = nullable8;
            this.MinTickInterval = nullable8;
            this.MinorGridLineColor = this.MinorGridLineColor_DefaultValue = "#f2f2f2";
            this.MinorGridLineDashStyle = this.MinorGridLineDashStyle_DefaultValue = ZAxisMinorGridLineDashStyle.Solid;
            nullable8 = new double?(1.0);
            this.MinorGridLineWidth_DefaultValue = nullable8;
            this.MinorGridLineWidth = nullable8;
            this.MinorTickColor = this.MinorTickColor_DefaultValue = "#999999";
            this.MinorTickInterval = this.MinorTickInterval_DefaultValue = (string) null;
            nullable8 = new double?(2.0);
            this.MinorTickLength_DefaultValue = nullable8;
            this.MinorTickLength = nullable8;
            this.MinorTickPosition = this.MinorTickPosition_DefaultValue = ZAxisMinorTickPosition.Outside;
            nullable8 = new double?(0.0);
            this.MinorTickWidth_DefaultValue = nullable8;
            this.MinorTickWidth = nullable8;
            nullable1 = new bool?(true);
            this.NameToX_DefaultValue = nullable1;
            this.NameToX = nullable1;
            nullable8 = new double?(0.0);
            this.Offset_DefaultValue = nullable8;
            this.Offset = nullable8;
            nullable1 = new bool?(false);
            this.Opposite_DefaultValue = nullable1;
            this.Opposite = nullable1;
            this.PlotBands = this.PlotBands_DefaultValue = new ZAxisPlotBands();
            this.PlotLines = this.PlotLines_DefaultValue = new ZAxisPlotLines();
            nullable1 = new bool?(false);
            this.Reversed_DefaultValue = nullable1;
            this.Reversed = nullable1;
            nullable1 = new bool?(true);
            this.ShowEmpty_DefaultValue = nullable1;
            this.ShowEmpty = nullable1;
            nullable1 = new bool?(true);
            this.ShowFirstLabel_DefaultValue = nullable1;
            this.ShowFirstLabel = nullable1;
            nullable1 = new bool?(true);
            this.ShowLastLabel_DefaultValue = nullable1;
            this.ShowLastLabel = nullable1;
            double? nullable9 = new double?();
            this.SoftMax_DefaultValue = nullable9;
            this.SoftMax = nullable9;
            double? nullable10 = new double?();
            this.SoftMin_DefaultValue = nullable10;
            this.SoftMin = nullable10;
            nullable10 = new double?(1.0);
            this.StartOfWeek_DefaultValue = nullable10;
            this.StartOfWeek = nullable10;
            nullable1 = new bool?(false);
            this.StartOnTick_DefaultValue = nullable1;
            this.StartOnTick = nullable1;
            double? nullable11 = new double?();
            this.TickAmount_DefaultValue = nullable11;
            this.TickAmount = nullable11;
            this.TickColor = this.TickColor_DefaultValue = "#ccd6eb";
            double? nullable12 = new double?();
            this.TickInterval_DefaultValue = nullable12;
            this.TickInterval = nullable12;
            nullable12 = new double?(10.0);
            this.TickLength_DefaultValue = nullable12;
            this.TickLength = nullable12;
            double? nullable13 = new double?();
            this.TickPixelInterval_DefaultValue = nullable13;
            this.TickPixelInterval = nullable13;
            this.TickPosition = this.TickPosition_DefaultValue = ZAxisTickPosition.Outside;
            this.TickPositioner = this.TickPositioner_DefaultValue = "";
            this.TickPositions = this.TickPositions_DefaultValue = (List<double>) null;
            nullable13 = new double?(1.0);
            this.TickWidth_DefaultValue = nullable13;
            this.TickWidth = nullable13;
            this.TickmarkPlacement = this.TickmarkPlacement_DefaultValue = ZAxisTickmarkPlacement.Null;
            this.Title = this.Title_DefaultValue = new ZAxisTitle();
            this.Type = this.Type_DefaultValue = ZAxisType.Linear;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
        }

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
            if (this.Categories != this.Categories_DefaultValue)
                hashtable.Add((object) "categories", (object) this.Categories);
            double? nullable3 = this.Ceiling;
            double? nullable4 = this.Ceiling_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "ceiling", (object) this.Ceiling);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Crosshair != this.Crosshair_DefaultValue)
                hashtable.Add((object) "crosshair", (object) this.Crosshair);
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
            nullable4 = this.Floor;
            nullable3 = this.Floor_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "floor", (object) this.Floor);
            if (this.GridLineColor != this.GridLineColor_DefaultValue)
                hashtable.Add((object) "gridLineColor", (object) this.GridLineColor);
            if (this.GridLineDashStyle != this.GridLineDashStyle_DefaultValue)
                hashtable.Add((object) "gridLineDashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.GridLineDashStyle.ToString()));
            nullable3 = this.GridLineWidth;
            nullable4 = this.GridLineWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "gridLineWidth", (object) this.GridLineWidth);
            nullable4 = this.GridZIndex;
            nullable3 = this.GridZIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "gridZIndex", (object) this.GridZIndex);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            if (this.Labels.IsDirty())
                hashtable.Add((object) "labels", (object) this.Labels.ToHashtable());
            if (this.LineColor != this.LineColor_DefaultValue)
                hashtable.Add((object) "lineColor", (object) this.LineColor);
            nullable3 = this.LineWidth;
            nullable4 = this.LineWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            nullable4 = this.LinkedTo;
            nullable3 = this.LinkedTo_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable3 = this.Max;
            nullable4 = this.Max_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "max", (object) this.Max);
            nullable4 = this.MaxPadding;
            nullable3 = this.MaxPadding_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "maxPadding", (object) this.MaxPadding);
            nullable3 = this.Min;
            nullable4 = this.Min_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "min", (object) this.Min);
            nullable4 = this.MinPadding;
            nullable3 = this.MinPadding_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minPadding", (object) this.MinPadding);
            nullable3 = this.MinRange;
            nullable4 = this.MinRange_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "minRange", (object) this.MinRange);
            nullable4 = this.MinTickInterval;
            nullable3 = this.MinTickInterval_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minTickInterval", (object) this.MinTickInterval);
            if (this.MinorGridLineColor != this.MinorGridLineColor_DefaultValue)
                hashtable.Add((object) "minorGridLineColor", (object) this.MinorGridLineColor);
            if (this.MinorGridLineDashStyle != this.MinorGridLineDashStyle_DefaultValue)
                hashtable.Add((object) "minorGridLineDashStyle",
                    (object) Highcharts.FirstCharacterToLower(this.MinorGridLineDashStyle.ToString()));
            nullable3 = this.MinorGridLineWidth;
            nullable4 = this.MinorGridLineWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "minorGridLineWidth", (object) this.MinorGridLineWidth);
            if (this.MinorTickColor != this.MinorTickColor_DefaultValue)
                hashtable.Add((object) "minorTickColor", (object) this.MinorTickColor);
            if (this.MinorTickInterval != this.MinorTickInterval_DefaultValue)
                hashtable.Add((object) "minorTickInterval", (object) this.MinorTickInterval);
            nullable4 = this.MinorTickLength;
            nullable3 = this.MinorTickLength_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minorTickLength", (object) this.MinorTickLength);
            if (this.MinorTickPosition != this.MinorTickPosition_DefaultValue)
                hashtable.Add((object) "minorTickPosition",
                    (object) Highcharts.FirstCharacterToLower(this.MinorTickPosition.ToString()));
            nullable3 = this.MinorTickWidth;
            nullable4 = this.MinorTickWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "minorTickWidth", (object) this.MinorTickWidth);
            nullable1 = this.NameToX;
            nullable2 = this.NameToX_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "nameToX", (object) this.NameToX);
            nullable4 = this.Offset;
            nullable3 = this.Offset_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "offset", (object) this.Offset);
            nullable2 = this.Opposite;
            nullable1 = this.Opposite_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "opposite", (object) this.Opposite);
            if (this.PlotBands.IsDirty())
                hashtable.Add((object) "plotBands", (object) this.PlotBands.ToHashtable());
            if (this.PlotLines.IsDirty())
                hashtable.Add((object) "plotLines", (object) this.PlotLines.ToHashtable());
            nullable1 = this.Reversed;
            nullable2 = this.Reversed_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "reversed", (object) this.Reversed);
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
            nullable3 = this.SoftMax;
            nullable4 = this.SoftMax_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "softMax", (object) this.SoftMax);
            nullable4 = this.SoftMin;
            nullable3 = this.SoftMin_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "softMin", (object) this.SoftMin);
            nullable3 = this.StartOfWeek;
            nullable4 = this.StartOfWeek_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "startOfWeek", (object) this.StartOfWeek);
            nullable1 = this.StartOnTick;
            nullable2 = this.StartOnTick_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "startOnTick", (object) this.StartOnTick);
            nullable4 = this.TickAmount;
            nullable3 = this.TickAmount_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "tickAmount", (object) this.TickAmount);
            if (this.TickColor != this.TickColor_DefaultValue)
                hashtable.Add((object) "tickColor", (object) this.TickColor);
            nullable3 = this.TickInterval;
            nullable4 = this.TickInterval_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "tickInterval", (object) this.TickInterval);
            nullable4 = this.TickLength;
            nullable3 = this.TickLength_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "tickLength", (object) this.TickLength);
            nullable3 = this.TickPixelInterval;
            nullable4 = this.TickPixelInterval_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "tickPixelInterval", (object) this.TickPixelInterval);
            if (this.TickPosition != this.TickPosition_DefaultValue)
                hashtable.Add((object) "tickPosition",
                    (object) Highcharts.FirstCharacterToLower(this.TickPosition.ToString()));
            if (this.TickPositioner != this.TickPositioner_DefaultValue)
            {
                hashtable.Add((object) "tickPositioner", (object) this.TickPositioner);
                Highcharts.AddFunction("ZAxisTickPositioner.tickPositioner", this.TickPositioner);
            }
            if (this.TickPositions != this.TickPositions_DefaultValue)
                hashtable.Add((object) "tickPositions", (object) this.TickPositions);
            nullable4 = this.TickWidth;
            nullable3 = this.TickWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
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