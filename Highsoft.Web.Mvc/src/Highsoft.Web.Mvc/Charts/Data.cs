// Type: Highsoft.Web.Mvc.Charts.Data


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Data : BaseObject
    {
        public Data()
        {
            this.Columns = this.Columns_DefaultValue = new List<List<object>>();
            this.Complete = this.Complete_DefaultValue = "";
            this.Csv = this.Csv_DefaultValue = (string) null;
            this.DateFormat = this.DateFormat_DefaultValue = (string) null;
            this.DecimalPoint = this.DecimalPoint_DefaultValue = ".";
            double? nullable1 = new double?();
            this.EndColumn_DefaultValue = nullable1;
            this.EndColumn = nullable1;
            double? nullable2 = new double?();
            this.EndRow_DefaultValue = nullable2;
            this.EndRow = nullable2;
            bool? nullable3 = new bool?(true);
            this.FirstRowAsNames_DefaultValue = nullable3;
            this.FirstRowAsNames = nullable3;
            this.GoogleSpreadsheetKey = this.GoogleSpreadsheetKey_DefaultValue = "";
            this.GoogleSpreadsheetWorksheet = this.GoogleSpreadsheetWorksheet_DefaultValue = (string) null;
            this.ItemDelimiter = this.ItemDelimiter_DefaultValue = "";
            this.LineDelimiter = this.LineDelimiter_DefaultValue = "\n";
            this.ParseDate = this.ParseDate_DefaultValue = "";
            this.Parsed = this.Parsed_DefaultValue = "";
            this.Rows = this.Rows_DefaultValue = new List<List<object>>();
            this.SeriesMapping = this.SeriesMapping_DefaultValue = new List<object>();
            nullable2 = new double?(0.0);
            this.StartColumn_DefaultValue = nullable2;
            this.StartColumn = nullable2;
            nullable2 = new double?(0.0);
            this.StartRow_DefaultValue = nullable2;
            this.StartRow = nullable2;
            nullable3 = new bool?(false);
            this.SwitchRowsAndColumns_DefaultValue = nullable3;
            this.SwitchRowsAndColumns = nullable3;
            this.Table = this.Table_DefaultValue = "";
        }

        public List<List<object>> Columns { get; set; }

        private List<List<object>> Columns_DefaultValue { get; set; }

        public string Complete { get; set; }

        private string Complete_DefaultValue { get; set; }

        public string Csv { get; set; }

        private string Csv_DefaultValue { get; set; }

        public string DateFormat { get; set; }

        private string DateFormat_DefaultValue { get; set; }

        public string DecimalPoint { get; set; }

        private string DecimalPoint_DefaultValue { get; set; }

        public double? EndColumn { get; set; }

        private double? EndColumn_DefaultValue { get; set; }

        public double? EndRow { get; set; }

        private double? EndRow_DefaultValue { get; set; }

        public bool? FirstRowAsNames { get; set; }

        private bool? FirstRowAsNames_DefaultValue { get; set; }

        public string GoogleSpreadsheetKey { get; set; }

        private string GoogleSpreadsheetKey_DefaultValue { get; set; }

        public string GoogleSpreadsheetWorksheet { get; set; }

        private string GoogleSpreadsheetWorksheet_DefaultValue { get; set; }

        public string ItemDelimiter { get; set; }

        private string ItemDelimiter_DefaultValue { get; set; }

        public string LineDelimiter { get; set; }

        private string LineDelimiter_DefaultValue { get; set; }

        public string ParseDate { get; set; }

        private string ParseDate_DefaultValue { get; set; }

        public string Parsed { get; set; }

        private string Parsed_DefaultValue { get; set; }

        public List<List<object>> Rows { get; set; }

        private List<List<object>> Rows_DefaultValue { get; set; }

        public List<object> SeriesMapping { get; set; }

        private List<object> SeriesMapping_DefaultValue { get; set; }

        public double? StartColumn { get; set; }

        private double? StartColumn_DefaultValue { get; set; }

        public double? StartRow { get; set; }

        private double? StartRow_DefaultValue { get; set; }

        public bool? SwitchRowsAndColumns { get; set; }

        private bool? SwitchRowsAndColumns_DefaultValue { get; set; }

        public string Table { get; set; }

        private string Table_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Columns != this.Columns_DefaultValue)
                hashtable.Add((object) "columns", (object) this.Columns);
            if (this.Complete != this.Complete_DefaultValue)
            {
                hashtable.Add((object) "complete", (object) this.Complete);
                Highcharts.AddFunction("DataComplete.complete", this.Complete);
            }
            if (this.Csv != this.Csv_DefaultValue)
                hashtable.Add((object) "csv", (object) this.Csv);
            if (this.DateFormat != this.DateFormat_DefaultValue)
                hashtable.Add((object) "dateFormat", (object) this.DateFormat);
            if (this.DecimalPoint != this.DecimalPoint_DefaultValue)
                hashtable.Add((object) "decimalPoint", (object) this.DecimalPoint);
            double? nullable1 = this.EndColumn;
            double? nullable2 = this.EndColumn_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "endColumn", (object) this.EndColumn);
            nullable2 = this.EndRow;
            nullable1 = this.EndRow_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "endRow", (object) this.EndRow);
            bool? nullable3 = this.FirstRowAsNames;
            bool? nullable4 = this.FirstRowAsNames_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "firstRowAsNames", (object) this.FirstRowAsNames);
            if (this.GoogleSpreadsheetKey != this.GoogleSpreadsheetKey_DefaultValue)
                hashtable.Add((object) "googleSpreadsheetKey", (object) this.GoogleSpreadsheetKey);
            if (this.GoogleSpreadsheetWorksheet != this.GoogleSpreadsheetWorksheet_DefaultValue)
                hashtable.Add((object) "googleSpreadsheetWorksheet", (object) this.GoogleSpreadsheetWorksheet);
            if (this.ItemDelimiter != this.ItemDelimiter_DefaultValue)
                hashtable.Add((object) "itemDelimiter", (object) this.ItemDelimiter);
            if (this.LineDelimiter != this.LineDelimiter_DefaultValue)
                hashtable.Add((object) "lineDelimiter", (object) this.LineDelimiter);
            if (this.ParseDate != this.ParseDate_DefaultValue)
            {
                hashtable.Add((object) "parseDate", (object) this.ParseDate);
                Highcharts.AddFunction("DataParseDate.parseDate", this.ParseDate);
            }
            if (this.Parsed != this.Parsed_DefaultValue)
            {
                hashtable.Add((object) "parsed", (object) this.Parsed);
                Highcharts.AddFunction("DataParsed.parsed", this.Parsed);
            }
            if (this.Rows != this.Rows_DefaultValue)
                hashtable.Add((object) "rows", (object) this.Rows);
            if (this.SeriesMapping != this.SeriesMapping_DefaultValue)
                hashtable.Add((object) "seriesMapping", (object) this.SeriesMapping);
            nullable1 = this.StartColumn;
            nullable2 = this.StartColumn_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "startColumn", (object) this.StartColumn);
            nullable2 = this.StartRow;
            nullable1 = this.StartRow_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "startRow", (object) this.StartRow);
            nullable4 = this.SwitchRowsAndColumns;
            nullable3 = this.SwitchRowsAndColumns_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "switchRowsAndColumns", (object) this.SwitchRowsAndColumns);
            if (this.Table != this.Table_DefaultValue)
                hashtable.Add((object) "table", (object) this.Table);
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