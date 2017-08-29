// Type: Highsoft.Web.Mvc.Charts.Lang


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Lang : BaseObject
    {
        public Lang()
        {
            this.ContextButtonTitle = this.ContextButtonTitle_DefaultValue = "Chart context menu";
            this.DecimalPoint = this.DecimalPoint_DefaultValue = ".";
            this.DownloadJPEG = this.DownloadJPEG_DefaultValue = "Download JPEG image";
            this.DownloadPDF = this.DownloadPDF_DefaultValue = "Download PDF document";
            this.DownloadPNG = this.DownloadPNG_DefaultValue = "Download PNG image";
            this.DownloadSVG = this.DownloadSVG_DefaultValue = "Download SVG vector image";
            this.DrillUpText = this.DrillUpText_DefaultValue = "Back to {series.name}";
            this.InvalidDate = this.InvalidDate_DefaultValue = "";
            this.Loading = this.Loading_DefaultValue = "Loading...";
            this.Months = this.Months_DefaultValue = new List<string>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            this.NoData = this.NoData_DefaultValue = "No data to display";
            double? nullable = new double?(1000.0);
            this.NumericSymbolMagnitude_DefaultValue = nullable;
            this.NumericSymbolMagnitude = nullable;
            this.NumericSymbols = this.NumericSymbols_DefaultValue = new List<string>()
            {
                "k",
                "M",
                "G",
                "T",
                "P",
                "E"
            };
            this.PrintChart = this.PrintChart_DefaultValue = "Print chart";
            this.ResetZoom = this.ResetZoom_DefaultValue = "Reset zoom";
            this.ResetZoomTitle = this.ResetZoomTitle_DefaultValue = "Reset zoom level 1:1";
            this.ShortMonths = this.ShortMonths_DefaultValue = new List<string>()
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };
            this.ShortWeekdays = this.ShortWeekdays_DefaultValue = (List<string>) null;
            this.ThousandsSep = this.ThousandsSep_DefaultValue = " ";
            this.Weekdays = this.Weekdays_DefaultValue = new List<string>()
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
        }

        public string ContextButtonTitle { get; set; }

        private string ContextButtonTitle_DefaultValue { get; set; }

        public string DecimalPoint { get; set; }

        private string DecimalPoint_DefaultValue { get; set; }

        public string DownloadJPEG { get; set; }

        private string DownloadJPEG_DefaultValue { get; set; }

        public string DownloadPDF { get; set; }

        private string DownloadPDF_DefaultValue { get; set; }

        public string DownloadPNG { get; set; }

        private string DownloadPNG_DefaultValue { get; set; }

        public string DownloadSVG { get; set; }

        private string DownloadSVG_DefaultValue { get; set; }

        public string DrillUpText { get; set; }

        private string DrillUpText_DefaultValue { get; set; }

        public string InvalidDate { get; set; }

        private string InvalidDate_DefaultValue { get; set; }

        public string Loading { get; set; }

        private string Loading_DefaultValue { get; set; }

        public List<string> Months { get; set; }

        private List<string> Months_DefaultValue { get; set; }

        public string NoData { get; set; }

        private string NoData_DefaultValue { get; set; }

        public double? NumericSymbolMagnitude { get; set; }

        private double? NumericSymbolMagnitude_DefaultValue { get; set; }

        public List<string> NumericSymbols { get; set; }

        private List<string> NumericSymbols_DefaultValue { get; set; }

        public string PrintChart { get; set; }

        private string PrintChart_DefaultValue { get; set; }

        public string ResetZoom { get; set; }

        private string ResetZoom_DefaultValue { get; set; }

        public string ResetZoomTitle { get; set; }

        private string ResetZoomTitle_DefaultValue { get; set; }

        public List<string> ShortMonths { get; set; }

        private List<string> ShortMonths_DefaultValue { get; set; }

        public List<string> ShortWeekdays { get; set; }

        private List<string> ShortWeekdays_DefaultValue { get; set; }

        public string ThousandsSep { get; set; }

        private string ThousandsSep_DefaultValue { get; set; }

        public List<string> Weekdays { get; set; }

        private List<string> Weekdays_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ContextButtonTitle != this.ContextButtonTitle_DefaultValue)
                hashtable.Add((object) "contextButtonTitle", (object) this.ContextButtonTitle);
            if (this.DecimalPoint != this.DecimalPoint_DefaultValue)
                hashtable.Add((object) "decimalPoint", (object) this.DecimalPoint);
            if (this.DownloadJPEG != this.DownloadJPEG_DefaultValue)
                hashtable.Add((object) "downloadJPEG", (object) this.DownloadJPEG);
            if (this.DownloadPDF != this.DownloadPDF_DefaultValue)
                hashtable.Add((object) "downloadPDF", (object) this.DownloadPDF);
            if (this.DownloadPNG != this.DownloadPNG_DefaultValue)
                hashtable.Add((object) "downloadPNG", (object) this.DownloadPNG);
            if (this.DownloadSVG != this.DownloadSVG_DefaultValue)
                hashtable.Add((object) "downloadSVG", (object) this.DownloadSVG);
            if (this.DrillUpText != this.DrillUpText_DefaultValue)
                hashtable.Add((object) "drillUpText", (object) this.DrillUpText);
            if (this.InvalidDate != this.InvalidDate_DefaultValue)
                hashtable.Add((object) "invalidDate", (object) this.InvalidDate);
            if (this.Loading != this.Loading_DefaultValue)
                hashtable.Add((object) "loading", (object) this.Loading);
            if (this.Months != this.Months_DefaultValue)
                hashtable.Add((object) "months", (object) this.Months);
            if (this.NoData != this.NoData_DefaultValue)
                hashtable.Add((object) "noData", (object) this.NoData);
            double? numericSymbolMagnitude = this.NumericSymbolMagnitude;
            double? magnitudeDefaultValue = this.NumericSymbolMagnitude_DefaultValue;
            if (numericSymbolMagnitude.GetValueOrDefault() != magnitudeDefaultValue.GetValueOrDefault() ||
                numericSymbolMagnitude.HasValue != magnitudeDefaultValue.HasValue)
                hashtable.Add((object) "numericSymbolMagnitude", (object) this.NumericSymbolMagnitude);
            if (this.NumericSymbols != this.NumericSymbols_DefaultValue)
                hashtable.Add((object) "numericSymbols", (object) this.NumericSymbols);
            if (this.PrintChart != this.PrintChart_DefaultValue)
                hashtable.Add((object) "printChart", (object) this.PrintChart);
            if (this.ResetZoom != this.ResetZoom_DefaultValue)
                hashtable.Add((object) "resetZoom", (object) this.ResetZoom);
            if (this.ResetZoomTitle != this.ResetZoomTitle_DefaultValue)
                hashtable.Add((object) "resetZoomTitle", (object) this.ResetZoomTitle);
            if (this.ShortMonths != this.ShortMonths_DefaultValue)
                hashtable.Add((object) "shortMonths", (object) this.ShortMonths);
            if (this.ShortWeekdays != this.ShortWeekdays_DefaultValue)
                hashtable.Add((object) "shortWeekdays", (object) this.ShortWeekdays);
            if (this.ThousandsSep != this.ThousandsSep_DefaultValue)
                hashtable.Add((object) "thousandsSep", (object) this.ThousandsSep);
            if (this.Weekdays != this.Weekdays_DefaultValue)
                hashtable.Add((object) "weekdays", (object) this.Weekdays);
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