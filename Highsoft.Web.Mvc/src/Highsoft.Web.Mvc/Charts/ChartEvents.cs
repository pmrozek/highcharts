// Type: Highsoft.Web.Mvc.Charts.ChartEvents


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ChartEvents : BaseObject
    {
        public ChartEvents()
        {
            this.AddSeries = this.AddSeries_DefaultValue = "";
            this.AfterPrint = this.AfterPrint_DefaultValue = "";
            this.BeforePrint = this.BeforePrint_DefaultValue = "";
            this.Click = this.Click_DefaultValue = "";
            this.Drilldown = this.Drilldown_DefaultValue = "";
            this.Drillup = this.Drillup_DefaultValue = "";
            this.Drillupall = this.Drillupall_DefaultValue = "";
            this.Load = this.Load_DefaultValue = "";
            this.Redraw = this.Redraw_DefaultValue = "";
            this.Render = this.Render_DefaultValue = "";
            this.Selection = this.Selection_DefaultValue = "";
        }

        public string AddSeries { get; set; }

        private string AddSeries_DefaultValue { get; set; }

        public string AfterPrint { get; set; }

        private string AfterPrint_DefaultValue { get; set; }

        public string BeforePrint { get; set; }

        private string BeforePrint_DefaultValue { get; set; }

        public string Click { get; set; }

        private string Click_DefaultValue { get; set; }

        public string Drilldown { get; set; }

        private string Drilldown_DefaultValue { get; set; }

        public string Drillup { get; set; }

        private string Drillup_DefaultValue { get; set; }

        public string Drillupall { get; set; }

        private string Drillupall_DefaultValue { get; set; }

        public string Load { get; set; }

        private string Load_DefaultValue { get; set; }

        public string Redraw { get; set; }

        private string Redraw_DefaultValue { get; set; }

        public string Render { get; set; }

        private string Render_DefaultValue { get; set; }

        public string Selection { get; set; }

        private string Selection_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.AddSeries != this.AddSeries_DefaultValue)
            {
                hashtable.Add((object) "addSeries", (object) this.AddSeries);
                Highcharts.AddFunction("ChartEventsAddSeries.addSeries", this.AddSeries);
            }
            if (this.AfterPrint != this.AfterPrint_DefaultValue)
            {
                hashtable.Add((object) "afterPrint", (object) this.AfterPrint);
                Highcharts.AddFunction("ChartEventsAfterPrint.afterPrint", this.AfterPrint);
            }
            if (this.BeforePrint != this.BeforePrint_DefaultValue)
            {
                hashtable.Add((object) "beforePrint", (object) this.BeforePrint);
                Highcharts.AddFunction("ChartEventsBeforePrint.beforePrint", this.BeforePrint);
            }
            if (this.Click != this.Click_DefaultValue)
            {
                hashtable.Add((object) "click", (object) this.Click);
                Highcharts.AddFunction("ChartEventsClick.click", this.Click);
            }
            if (this.Drilldown != this.Drilldown_DefaultValue)
            {
                hashtable.Add((object) "drilldown", (object) this.Drilldown);
                Highcharts.AddFunction("ChartEventsDrilldown.drilldown", this.Drilldown);
            }
            if (this.Drillup != this.Drillup_DefaultValue)
            {
                hashtable.Add((object) "drillup", (object) this.Drillup);
                Highcharts.AddFunction("ChartEventsDrillup.drillup", this.Drillup);
            }
            if (this.Drillupall != this.Drillupall_DefaultValue)
            {
                hashtable.Add((object) "drillupall", (object) this.Drillupall);
                Highcharts.AddFunction("ChartEventsDrillupall.drillupall", this.Drillupall);
            }
            if (this.Load != this.Load_DefaultValue)
            {
                hashtable.Add((object) "load", (object) this.Load);
                Highcharts.AddFunction("ChartEventsLoad.load", this.Load);
            }
            if (this.Redraw != this.Redraw_DefaultValue)
            {
                hashtable.Add((object) "redraw", (object) this.Redraw);
                Highcharts.AddFunction("ChartEventsRedraw.redraw", this.Redraw);
            }
            if (this.Render != this.Render_DefaultValue)
            {
                hashtable.Add((object) "render", (object) this.Render);
                Highcharts.AddFunction("ChartEventsRender.render", this.Render);
            }
            if (this.Selection != this.Selection_DefaultValue)
            {
                hashtable.Add((object) "selection", (object) this.Selection);
                Highcharts.AddFunction("ChartEventsSelection.selection", this.Selection);
            }
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