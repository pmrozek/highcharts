// Type: Highsoft.Web.Mvc.Charts.Exporting


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Exporting : BaseObject
    {
        public bool? AllowHTML { get; set; }

        private bool? AllowHTML_DefaultValue { get; set; }

        public ExportingButtons Buttons { get; set; }

        private ExportingButtons Buttons_DefaultValue { get; set; }

        public object ChartOptions { get; set; }

        private object ChartOptions_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Error { get; set; }

        private string Error_DefaultValue { get; set; }

        public bool? FallbackToExportServer { get; set; }

        private bool? FallbackToExportServer_DefaultValue { get; set; }

        public string Filename { get; set; }

        private string Filename_DefaultValue { get; set; }

        public object FormAttributes { get; set; }

        private object FormAttributes_DefaultValue { get; set; }

        public string LibURL { get; set; }

        private string LibURL_DefaultValue { get; set; }

        public double? PrintMaxWidth { get; set; }

        private double? PrintMaxWidth_DefaultValue { get; set; }

        public double? Scale { get; set; }

        private double? Scale_DefaultValue { get; set; }

        public double? SourceHeight { get; set; }

        private double? SourceHeight_DefaultValue { get; set; }

        public double? SourceWidth { get; set; }

        private double? SourceWidth_DefaultValue { get; set; }

        public ExportingType Type { get; set; }

        private ExportingType Type_DefaultValue { get; set; }

        public string Url { get; set; }

        private string Url_DefaultValue { get; set; }

        public double? Width { get; set; }

        private double? Width_DefaultValue { get; set; }

        public Exporting()
        {
            bool? nullable1 = new bool?(false);
            this.AllowHTML_DefaultValue = nullable1;
            this.AllowHTML = nullable1;
            this.Buttons = this.Buttons_DefaultValue = new ExportingButtons();
            this.ChartOptions = this.ChartOptions_DefaultValue = (object) null;
            nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Error = this.Error_DefaultValue = "";
            nullable1 = new bool?(true);
            this.FallbackToExportServer_DefaultValue = nullable1;
            this.FallbackToExportServer = nullable1;
            this.Filename = this.Filename_DefaultValue = "chart";
            this.FormAttributes = this.FormAttributes_DefaultValue = (object) "";
            this.LibURL = this.LibURL_DefaultValue = "https://code.highcharts.com/{version}/lib";
            double? nullable2 = new double?(780.0);
            this.PrintMaxWidth_DefaultValue = nullable2;
            this.PrintMaxWidth = nullable2;
            nullable2 = new double?(2.0);
            this.Scale_DefaultValue = nullable2;
            this.Scale = nullable2;
            double? nullable3 = new double?();
            this.SourceHeight_DefaultValue = nullable3;
            this.SourceHeight = nullable3;
            double? nullable4 = new double?();
            this.SourceWidth_DefaultValue = nullable4;
            this.SourceWidth = nullable4;
            this.Type = this.Type_DefaultValue = ExportingType.Imagepng;
            this.Url = this.Url_DefaultValue = "https://export.highcharts.com";
            double? nullable5 = new double?();
            this.Width_DefaultValue = nullable5;
            this.Width = nullable5;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? allowHtml = this.AllowHTML;
            bool? htmlDefaultValue = this.AllowHTML_DefaultValue;
            if ((allowHtml.GetValueOrDefault() == htmlDefaultValue.GetValueOrDefault()
                    ? (allowHtml.HasValue != htmlDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "allowHTML", (object) this.AllowHTML);
            if (this.Buttons.IsDirty())
                hashtable.Add((object) "buttons", (object) this.Buttons.ToHashtable());
            if (this.ChartOptions != this.ChartOptions_DefaultValue)
                hashtable.Add((object) "chartOptions", this.ChartOptions);
            bool? enabled = this.Enabled;
            bool? nullable1 = this.Enabled_DefaultValue;
            if ((enabled.GetValueOrDefault() == nullable1.GetValueOrDefault()
                    ? (enabled.HasValue != nullable1.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Error != this.Error_DefaultValue)
            {
                hashtable.Add((object) "error", (object) this.Error);
                Highcharts.AddFunction("ExportingError.error", this.Error);
            }
            nullable1 = this.FallbackToExportServer;
            bool? serverDefaultValue = this.FallbackToExportServer_DefaultValue;
            if ((nullable1.GetValueOrDefault() == serverDefaultValue.GetValueOrDefault()
                    ? (nullable1.HasValue != serverDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "fallbackToExportServer", (object) this.FallbackToExportServer);
            if (this.Filename != this.Filename_DefaultValue)
                hashtable.Add((object) "filename", (object) this.Filename);
            if (this.FormAttributes != this.FormAttributes_DefaultValue)
                hashtable.Add((object) "formAttributes", this.FormAttributes);
            if (this.LibURL != this.LibURL_DefaultValue)
                hashtable.Add((object) "libURL", (object) this.LibURL);
            double? printMaxWidth = this.PrintMaxWidth;
            double? nullable2 = this.PrintMaxWidth_DefaultValue;
            if ((printMaxWidth.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (printMaxWidth.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "printMaxWidth", (object) this.PrintMaxWidth);
            nullable2 = this.Scale;
            double? nullable3 = this.Scale_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "scale", (object) this.Scale);
            nullable3 = this.SourceHeight;
            nullable2 = this.SourceHeight_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "sourceHeight", (object) this.SourceHeight);
            nullable2 = this.SourceWidth;
            nullable3 = this.SourceWidth_DefaultValue;
            if ((nullable2.GetValueOrDefault() == nullable3.GetValueOrDefault()
                    ? (nullable2.HasValue != nullable3.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "sourceWidth", (object) this.SourceWidth);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            if (this.Url != this.Url_DefaultValue)
                hashtable.Add((object) "url", (object) this.Url);
            nullable3 = this.Width;
            nullable2 = this.Width_DefaultValue;
            if ((nullable3.GetValueOrDefault() == nullable2.GetValueOrDefault()
                    ? (nullable3.HasValue != nullable2.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "width", (object) this.Width);
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