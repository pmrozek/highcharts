// Type: Highsoft.Web.Mvc.Stocks.PlotOptions


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class PlotOptions : BaseObject
    {
        public PlotOptionsArea Area { get; set; }

        private PlotOptionsArea Area_DefaultValue { get; set; }

        public PlotOptionsArearange Arearange { get; set; }

        private PlotOptionsArearange Arearange_DefaultValue { get; set; }

        public PlotOptionsAreaspline Areaspline { get; set; }

        private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }

        public PlotOptionsAreasplinerange Areasplinerange { get; set; }

        private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }

        public PlotOptionsCandlestick Candlestick { get; set; }

        private PlotOptionsCandlestick Candlestick_DefaultValue { get; set; }

        public PlotOptionsColumn Column { get; set; }

        private PlotOptionsColumn Column_DefaultValue { get; set; }

        public PlotOptionsColumnrange Columnrange { get; set; }

        private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }

        public PlotOptionsFlags Flags { get; set; }

        private PlotOptionsFlags Flags_DefaultValue { get; set; }

        public PlotOptionsLine Line { get; set; }

        private PlotOptionsLine Line_DefaultValue { get; set; }

        public PlotOptionsOhlc Ohlc { get; set; }

        private PlotOptionsOhlc Ohlc_DefaultValue { get; set; }

        public PlotOptionsPolygon Polygon { get; set; }

        private PlotOptionsPolygon Polygon_DefaultValue { get; set; }

        public PlotOptionsScatter Scatter { get; set; }

        private PlotOptionsScatter Scatter_DefaultValue { get; set; }

        public PlotOptionsSeries Series { get; set; }

        private PlotOptionsSeries Series_DefaultValue { get; set; }

        public PlotOptionsSpline Spline { get; set; }

        private PlotOptionsSpline Spline_DefaultValue { get; set; }

        public PlotOptions()
        {
            this.Area = this.Area_DefaultValue = new PlotOptionsArea();
            this.Arearange = this.Arearange_DefaultValue = new PlotOptionsArearange();
            this.Areaspline = this.Areaspline_DefaultValue = new PlotOptionsAreaspline();
            this.Areasplinerange = this.Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
            this.Candlestick = this.Candlestick_DefaultValue = new PlotOptionsCandlestick();
            this.Column = this.Column_DefaultValue = new PlotOptionsColumn();
            this.Columnrange = this.Columnrange_DefaultValue = new PlotOptionsColumnrange();
            this.Flags = this.Flags_DefaultValue = new PlotOptionsFlags();
            this.Line = this.Line_DefaultValue = new PlotOptionsLine();
            this.Ohlc = this.Ohlc_DefaultValue = new PlotOptionsOhlc();
            this.Polygon = this.Polygon_DefaultValue = new PlotOptionsPolygon();
            this.Scatter = this.Scatter_DefaultValue = new PlotOptionsScatter();
            this.Series = this.Series_DefaultValue = new PlotOptionsSeries();
            this.Spline = this.Spline_DefaultValue = new PlotOptionsSpline();
        }

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
            if (this.Candlestick.IsDirty())
                hashtable.Add((object) "candlestick", (object) this.Candlestick.ToHashtable());
            if (this.Column.IsDirty())
                hashtable.Add((object) "column", (object) this.Column.ToHashtable());
            if (this.Columnrange.IsDirty())
                hashtable.Add((object) "columnrange", (object) this.Columnrange.ToHashtable());
            if (this.Flags.IsDirty())
                hashtable.Add((object) "flags", (object) this.Flags.ToHashtable());
            if (this.Line.IsDirty())
                hashtable.Add((object) "line", (object) this.Line.ToHashtable());
            if (this.Ohlc.IsDirty())
                hashtable.Add((object) "ohlc", (object) this.Ohlc.ToHashtable());
            if (this.Polygon.IsDirty())
                hashtable.Add((object) "polygon", (object) this.Polygon.ToHashtable());
            if (this.Scatter.IsDirty())
                hashtable.Add((object) "scatter", (object) this.Scatter.ToHashtable());
            if (this.Series.IsDirty())
                hashtable.Add((object) "series", (object) this.Series.ToHashtable());
            if (this.Spline.IsDirty())
                hashtable.Add((object) "spline", (object) this.Spline.ToHashtable());
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