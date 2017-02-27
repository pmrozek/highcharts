// Type: Highsoft.Web.Mvc.Charts.PyramidSeries


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PyramidSeries : Series
    {
        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string[] Center { get; set; }

        private string[] Center_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public List<string> Colors { get; set; }

        private List<string> Colors_DefaultValue { get; set; }

        public PyramidSeriesCursor Cursor { get; set; }

        private PyramidSeriesCursor Cursor_DefaultValue { get; set; }

        public List<PyramidSeriesData> Data { get; set; }

        private List<PyramidSeriesData> Data_DefaultValue { get; set; }

        public PyramidSeriesDataLabels DataLabels { get; set; }

        private PyramidSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public double? Depth { get; set; }

        private double? Depth_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public PyramidSeriesEvents Events { get; set; }

        private PyramidSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public string Height { get; set; }

        private string Height_DefaultValue { get; set; }

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

        public double? MinSize { get; set; }

        private double? MinSize_DefaultValue { get; set; }

        public new string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public PyramidSeriesPoint Point { get; set; }

        private PyramidSeriesPoint Point_DefaultValue { get; set; }

        public bool? Reversed { get; set; }

        private bool? Reversed_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public double? SlicedOffset { get; set; }

        private double? SlicedOffset_DefaultValue { get; set; }

        public PyramidSeriesStates States { get; set; }

        private PyramidSeriesStates States_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public PyramidSeriesTooltip Tooltip { get; set; }

        private PyramidSeriesTooltip Tooltip_DefaultValue { get; set; }

        public PyramidSeriesType Type { get; set; }

        private PyramidSeriesType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public string Width { get; set; }

        private string Width_DefaultValue { get; set; }

        public new double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public PyramidSeriesZones Zones { get; set; }

        private PyramidSeriesZones Zones_DefaultValue { get; set; }

        public PyramidSeries()
        {
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.BorderColor = this.BorderColor_DefaultValue = "#ffffff";
            nullable2 = new double?(1.0);
            this.BorderWidth_DefaultValue = nullable2;
            this.BorderWidth = nullable2;
            this.Center = this.Center_DefaultValue = new string[2];
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Colors = this.Colors_DefaultValue = new List<string>();
            this.Cursor = this.Cursor_DefaultValue = PyramidSeriesCursor.Null;
            this.Data = this.Data_DefaultValue = new List<PyramidSeriesData>();
            this.DataLabels = this.DataLabels_DefaultValue = new PyramidSeriesDataLabels();
            nullable2 = new double?(0.0);
            this.Depth_DefaultValue = nullable2;
            this.Depth = nullable2;
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new PyramidSeriesEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            this.Height = this.Height_DefaultValue = (string) null;
            this.Id = this.Id_DefaultValue = "";
            double? nullable3 = new double?();
            this.Index_DefaultValue = nullable3;
            this.Index = nullable3;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            double? nullable4 = new double?();
            this.LegendIndex_DefaultValue = nullable4;
            this.LegendIndex = nullable4;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            nullable4 = new double?(80.0);
            this.MinSize_DefaultValue = nullable4;
            this.MinSize = nullable4;
            this.Name = this.Name_DefaultValue = (string) null;
            this.Point = this.Point_DefaultValue = new PyramidSeriesPoint();
            nullable1 = new bool?(true);
            this.Reversed_DefaultValue = nullable1;
            this.Reversed = nullable1;
            nullable1 = new bool?(false);
            this.Selected_DefaultValue = nullable1;
            this.Selected = nullable1;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable1 = new bool?(false);
            this.ShowInLegend_DefaultValue = nullable1;
            this.ShowInLegend = nullable1;
            nullable4 = new double?(10.0);
            this.SlicedOffset_DefaultValue = nullable4;
            this.SlicedOffset = nullable4;
            this.States = this.States_DefaultValue = new PyramidSeriesStates();
            nullable1 = new bool?(false);
            this.StickyTracking_DefaultValue = nullable1;
            this.StickyTracking = nullable1;
            this.Tooltip = this.Tooltip_DefaultValue = new PyramidSeriesTooltip();
            this.Type = this.Type_DefaultValue = PyramidSeriesType.Null;
            nullable1 = new bool?(true);
            this.Visible_DefaultValue = nullable1;
            this.Visible = nullable1;
            this.Width = this.Width_DefaultValue = "90%";
            double? nullable5 = new double?();
            this.ZIndex_DefaultValue = nullable5;
            this.ZIndex = nullable5;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new PyramidSeriesZones();
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
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            nullable4 = this.BorderWidth;
            nullable3 = this.BorderWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.Center != this.Center_DefaultValue)
                hashtable.Add((object) "center", (object) this.Center);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Colors != this.Colors_DefaultValue)
                hashtable.Add((object) "colors", (object) this.Colors);
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
            if (this.Height != this.Height_DefaultValue)
                hashtable.Add((object) "height", (object) this.Height);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable4 = this.Index;
            nullable3 = this.Index_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "index", (object) this.Index);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable3 = this.LegendIndex;
            nullable4 = this.LegendIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable4 = this.MinSize;
            nullable3 = this.MinSize_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "minSize", (object) this.MinSize);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable2 = this.Reversed;
            nullable1 = this.Reversed_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "reversed", (object) this.Reversed);
            nullable1 = this.Selected;
            nullable2 = this.Selected_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            nullable2 = this.ShowInLegend;
            nullable1 = this.ShowInLegend_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable3 = this.SlicedOffset;
            nullable4 = this.SlicedOffset_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "slicedOffset", (object) this.SlicedOffset);
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            nullable1 = this.StickyTracking;
            nullable2 = this.StickyTracking_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable2 = this.Visible;
            nullable1 = this.Visible_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.Width != this.Width_DefaultValue)
                hashtable.Add((object) "width", (object) this.Width);
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