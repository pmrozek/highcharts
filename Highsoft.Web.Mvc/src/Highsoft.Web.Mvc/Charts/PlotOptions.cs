// Type: Highsoft.Web.Mvc.Charts.PlotOptions


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptions : BaseObject
    {
        public PlotOptions()
        {
            this.Area = this.Area_DefaultValue = new PlotOptionsArea();
            this.Arearange = this.Arearange_DefaultValue = new PlotOptionsArearange();
            this.Areaspline = this.Areaspline_DefaultValue = new PlotOptionsAreaspline();
            this.Areasplinerange = this.Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
            this.Bar = this.Bar_DefaultValue = new PlotOptionsBar();
            this.Boxplot = this.Boxplot_DefaultValue = new PlotOptionsBoxplot();
            this.Bubble = this.Bubble_DefaultValue = new PlotOptionsBubble();
            this.Column = this.Column_DefaultValue = new PlotOptionsColumn();
            this.Columnrange = this.Columnrange_DefaultValue = new PlotOptionsColumnrange();
            this.Errorbar = this.Errorbar_DefaultValue = new PlotOptionsErrorbar();
            this.Funnel = this.Funnel_DefaultValue = new PlotOptionsFunnel();
            this.Gauge = this.Gauge_DefaultValue = new PlotOptionsGauge();
            this.Heatmap = this.Heatmap_DefaultValue = new PlotOptionsHeatmap();
            this.Line = this.Line_DefaultValue = new PlotOptionsLine();
            this.Pie = this.Pie_DefaultValue = new PlotOptionsPie();
            this.Polygon = this.Polygon_DefaultValue = new PlotOptionsPolygon();
            this.Pyramid = this.Pyramid_DefaultValue = new PlotOptionsPyramid();
            this.Scatter = this.Scatter_DefaultValue = new PlotOptionsScatter();
            this.Series = this.Series_DefaultValue = new PlotOptionsSeries();
            this.Solidgauge = this.Solidgauge_DefaultValue = new PlotOptionsSolidgauge();
            this.Spline = this.Spline_DefaultValue = new PlotOptionsSpline();
            this.Treemap = this.Treemap_DefaultValue = new PlotOptionsTreemap();
            this.Waterfall = this.Waterfall_DefaultValue = new PlotOptionsWaterfall();
        }

        public PlotOptionsArea Area { get; set; }

        private PlotOptionsArea Area_DefaultValue { get; set; }

        public PlotOptionsArearange Arearange { get; set; }

        private PlotOptionsArearange Arearange_DefaultValue { get; set; }

        public PlotOptionsAreaspline Areaspline { get; set; }

        private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }

        public PlotOptionsAreasplinerange Areasplinerange { get; set; }

        private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }

        public PlotOptionsBar Bar { get; set; }

        private PlotOptionsBar Bar_DefaultValue { get; set; }

        public PlotOptionsBoxplot Boxplot { get; set; }

        private PlotOptionsBoxplot Boxplot_DefaultValue { get; set; }

        public PlotOptionsBubble Bubble { get; set; }

        private PlotOptionsBubble Bubble_DefaultValue { get; set; }

        public PlotOptionsColumn Column { get; set; }

        private PlotOptionsColumn Column_DefaultValue { get; set; }

        public PlotOptionsColumnrange Columnrange { get; set; }

        private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }

        public PlotOptionsErrorbar Errorbar { get; set; }

        private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }

        public PlotOptionsFunnel Funnel { get; set; }

        private PlotOptionsFunnel Funnel_DefaultValue { get; set; }

        public PlotOptionsGauge Gauge { get; set; }

        private PlotOptionsGauge Gauge_DefaultValue { get; set; }

        public PlotOptionsHeatmap Heatmap { get; set; }

        private PlotOptionsHeatmap Heatmap_DefaultValue { get; set; }

        public PlotOptionsLine Line { get; set; }

        private PlotOptionsLine Line_DefaultValue { get; set; }

        public PlotOptionsPie Pie { get; set; }

        private PlotOptionsPie Pie_DefaultValue { get; set; }

        public PlotOptionsPolygon Polygon { get; set; }

        private PlotOptionsPolygon Polygon_DefaultValue { get; set; }

        public PlotOptionsPyramid Pyramid { get; set; }

        private PlotOptionsPyramid Pyramid_DefaultValue { get; set; }

        public PlotOptionsScatter Scatter { get; set; }

        private PlotOptionsScatter Scatter_DefaultValue { get; set; }

        public PlotOptionsSeries Series { get; set; }

        private PlotOptionsSeries Series_DefaultValue { get; set; }

        public PlotOptionsSolidgauge Solidgauge { get; set; }

        private PlotOptionsSolidgauge Solidgauge_DefaultValue { get; set; }

        public PlotOptionsSpline Spline { get; set; }

        private PlotOptionsSpline Spline_DefaultValue { get; set; }

        public PlotOptionsTreemap Treemap { get; set; }

        private PlotOptionsTreemap Treemap_DefaultValue { get; set; }

        public PlotOptionsWaterfall Waterfall { get; set; }

        private PlotOptionsWaterfall Waterfall_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Area.IsDirty())
                hashtable.Add((object) "area", (object) this.Area.ToHashtable());
            if (this.Arearange.IsDirty())
                hashtable.Add((object) "arearange", (object) this.Arearange.ToHashtable());
            if (this.Areaspline.IsDirty())
                hashtable.Add((object) "areaspline", (object) this.Areaspline.ToHashtable());
            if (this.Areasplinerange.IsDirty())
                hashtable.Add((object) "areasplinerange", (object) this.Areasplinerange.ToHashtable());
            if (this.Bar.IsDirty())
                hashtable.Add((object) "bar", (object) this.Bar.ToHashtable());
            if (this.Boxplot.IsDirty())
                hashtable.Add((object) "boxplot", (object) this.Boxplot.ToHashtable());
            if (this.Bubble.IsDirty())
                hashtable.Add((object) "bubble", (object) this.Bubble.ToHashtable());
            if (this.Column.IsDirty())
                hashtable.Add((object) "column", (object) this.Column.ToHashtable());
            if (this.Columnrange.IsDirty())
                hashtable.Add((object) "columnrange", (object) this.Columnrange.ToHashtable());
            if (this.Errorbar.IsDirty())
                hashtable.Add((object) "errorbar", (object) this.Errorbar.ToHashtable());
            if (this.Funnel.IsDirty())
                hashtable.Add((object) "funnel", (object) this.Funnel.ToHashtable());
            if (this.Gauge.IsDirty())
                hashtable.Add((object) "gauge", (object) this.Gauge.ToHashtable());
            if (this.Heatmap.IsDirty())
                hashtable.Add((object) "heatmap", (object) this.Heatmap.ToHashtable());
            if (this.Line.IsDirty())
                hashtable.Add((object) "line", (object) this.Line.ToHashtable());
            if (this.Pie.IsDirty())
                hashtable.Add((object) "pie", (object) this.Pie.ToHashtable());
            if (this.Polygon.IsDirty())
                hashtable.Add((object) "polygon", (object) this.Polygon.ToHashtable());
            if (this.Pyramid.IsDirty())
                hashtable.Add((object) "pyramid", (object) this.Pyramid.ToHashtable());
            if (this.Scatter.IsDirty())
                hashtable.Add((object) "scatter", (object) this.Scatter.ToHashtable());
            if (this.Series.IsDirty())
                hashtable.Add((object) "series", (object) this.Series.ToHashtable());
            if (this.Solidgauge.IsDirty())
                hashtable.Add((object) "solidgauge", (object) this.Solidgauge.ToHashtable());
            if (this.Spline.IsDirty())
                hashtable.Add((object) "spline", (object) this.Spline.ToHashtable());
            if (this.Treemap.IsDirty())
                hashtable.Add((object) "treemap", (object) this.Treemap.ToHashtable());
            if (this.Waterfall.IsDirty())
                hashtable.Add((object) "waterfall", (object) this.Waterfall.ToHashtable());
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