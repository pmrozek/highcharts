
// Type: Highsoft.Web.Mvc.Stocks.Lang




using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
  public class Lang : BaseObject
  {
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

    public string Loading { get; set; }

    private string Loading_DefaultValue { get; set; }

    public List<string> Months { get; set; }

    private List<string> Months_DefaultValue { get; set; }

    public List<string> NumericSymbols { get; set; }

    private List<string> NumericSymbols_DefaultValue { get; set; }

    public string PrintChart { get; set; }

    private string PrintChart_DefaultValue { get; set; }

    public string RangeSelectorFrom { get; set; }

    private string RangeSelectorFrom_DefaultValue { get; set; }

    public string RangeSelectorTo { get; set; }

    private string RangeSelectorTo_DefaultValue { get; set; }

    public string RangeSelectorZoom { get; set; }

    private string RangeSelectorZoom_DefaultValue { get; set; }

    public string ResetZoom { get; set; }

    private string ResetZoom_DefaultValue { get; set; }

    public string ResetZoomTitle { get; set; }

    private string ResetZoomTitle_DefaultValue { get; set; }

    public List<string> ShortMonths { get; set; }

    private List<string> ShortMonths_DefaultValue { get; set; }

    public string ThousandsSep { get; set; }

    private string ThousandsSep_DefaultValue { get; set; }

    public List<string> Weekdays { get; set; }

    private List<string> Weekdays_DefaultValue { get; set; }

    public Lang()
    {
      this.ContextButtonTitle = this.ContextButtonTitle_DefaultValue = "Chart context menu";
      this.DecimalPoint = this.DecimalPoint_DefaultValue = "'.'";
      this.DownloadJPEG = this.DownloadJPEG_DefaultValue = "'Download JPEG image'";
      this.DownloadPDF = this.DownloadPDF_DefaultValue = "'Download PDF document'";
      this.DownloadPNG = this.DownloadPNG_DefaultValue = "'Download PNG image'";
      this.DownloadSVG = this.DownloadSVG_DefaultValue = "'Download SVG vector image'";
      this.Loading = this.Loading_DefaultValue = "Loading...";
      List<string> stringList1 = new List<string>();
      stringList1.Add("January");
      stringList1.Add("February");
      stringList1.Add("March");
      stringList1.Add("April");
      stringList1.Add("May");
      stringList1.Add("June");
      stringList1.Add("July");
      stringList1.Add("August");
      stringList1.Add("September");
      stringList1.Add("October");
      stringList1.Add("November");
      stringList1.Add("December");
      List<string> stringList2 = stringList1;
      this.Months_DefaultValue = stringList1;
      this.Months = stringList2;
      List<string> stringList3 = new List<string>();
      stringList3.Add("k");
      stringList3.Add("M");
      stringList3.Add("G");
      stringList3.Add("T");
      stringList3.Add("P");
      stringList3.Add("E");
      List<string> stringList4 = stringList3;
      this.NumericSymbols_DefaultValue = stringList3;
      this.NumericSymbols = stringList4;
      this.PrintChart = this.PrintChart_DefaultValue = "Print chart";
      this.RangeSelectorFrom = this.RangeSelectorFrom_DefaultValue = "From";
      this.RangeSelectorTo = this.RangeSelectorTo_DefaultValue = "To";
      this.RangeSelectorZoom = this.RangeSelectorZoom_DefaultValue = "Zoom";
      this.ResetZoom = this.ResetZoom_DefaultValue = "Reset zoom";
      this.ResetZoomTitle = this.ResetZoomTitle_DefaultValue = "Reset zoom level 1:1";
      List<string> stringList5 = new List<string>();
      stringList5.Add("Jan");
      stringList5.Add("Feb");
      stringList5.Add("Mar");
      stringList5.Add("Apr");
      stringList5.Add("May");
      stringList5.Add("Jun");
      stringList5.Add("Jul");
      stringList5.Add("Aug");
      stringList5.Add("Sep");
      stringList5.Add("Oct");
      stringList5.Add("Nov");
      stringList5.Add("Dec");
      List<string> stringList6 = stringList5;
      this.ShortMonths_DefaultValue = stringList5;
      this.ShortMonths = stringList6;
      this.ThousandsSep = this.ThousandsSep_DefaultValue = " ";
      List<string> stringList7 = new List<string>();
      stringList7.Add("Sunday");
      stringList7.Add("Monday");
      stringList7.Add("Tuesday");
      stringList7.Add("Wednesday");
      stringList7.Add("Thursday");
      stringList7.Add("Friday");
      stringList7.Add("Saturday");
      List<string> stringList8 = stringList7;
      this.Weekdays_DefaultValue = stringList7;
      this.Weekdays = stringList8;
    }

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
      if (this.Loading != this.Loading_DefaultValue)
        hashtable.Add((object) "loading", (object) this.Loading);
      if (this.Months != this.Months_DefaultValue)
        hashtable.Add((object) "months", (object) this.Months);
      if (this.NumericSymbols != this.NumericSymbols_DefaultValue)
        hashtable.Add((object) "numericSymbols", (object) this.NumericSymbols);
      if (this.PrintChart != this.PrintChart_DefaultValue)
        hashtable.Add((object) "printChart", (object) this.PrintChart);
      if (this.RangeSelectorFrom != this.RangeSelectorFrom_DefaultValue)
        hashtable.Add((object) "rangeSelectorFrom", (object) this.RangeSelectorFrom);
      if (this.RangeSelectorTo != this.RangeSelectorTo_DefaultValue)
        hashtable.Add((object) "rangeSelectorTo", (object) this.RangeSelectorTo);
      if (this.RangeSelectorZoom != this.RangeSelectorZoom_DefaultValue)
        hashtable.Add((object) "rangeSelectorZoom", (object) this.RangeSelectorZoom);
      if (this.ResetZoom != this.ResetZoom_DefaultValue)
        hashtable.Add((object) "resetZoom", (object) this.ResetZoom);
      if (this.ResetZoomTitle != this.ResetZoomTitle_DefaultValue)
        hashtable.Add((object) "resetZoomTitle", (object) this.ResetZoomTitle);
      if (this.ShortMonths != this.ShortMonths_DefaultValue)
        hashtable.Add((object) "shortMonths", (object) this.ShortMonths);
      if (this.ThousandsSep != this.ThousandsSep_DefaultValue)
        hashtable.Add((object) "thousandsSep", (object) this.ThousandsSep);
      if (this.Weekdays != this.Weekdays_DefaultValue)
        hashtable.Add((object) "weekdays", (object) this.Weekdays);
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
