// Type: Highsoft.Web.Mvc.Stocks.YAxisEvents


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class YAxisEvents : BaseObject
    {
        public YAxisEvents()
        {
            this.AfterSetExtremes = this.AfterSetExtremes_DefaultValue = "";
            this.PointInBreak = this.PointInBreak_DefaultValue = "";
            this.SetExtremes = this.SetExtremes_DefaultValue = "";
        }

        public string AfterSetExtremes { get; set; }

        private string AfterSetExtremes_DefaultValue { get; set; }

        public string PointInBreak { get; set; }

        private string PointInBreak_DefaultValue { get; set; }

        public string SetExtremes { get; set; }

        private string SetExtremes_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.AfterSetExtremes != this.AfterSetExtremes_DefaultValue)
            {
                hashtable.Add((object) "afterSetExtremes", (object) this.AfterSetExtremes);
                Highstock.AddFunction("YAxisEventsAfterSetExtremes.afterSetExtremes", this.AfterSetExtremes);
            }
            if (this.PointInBreak != this.PointInBreak_DefaultValue)
            {
                hashtable.Add((object) "pointInBreak", (object) this.PointInBreak);
                Highstock.AddFunction("YAxisEventsPointInBreak.pointInBreak", this.PointInBreak);
            }
            if (this.SetExtremes != this.SetExtremes_DefaultValue)
            {
                hashtable.Add((object) "setExtremes", (object) this.SetExtremes);
                Highstock.AddFunction("YAxisEventsSetExtremes.setExtremes", this.SetExtremes);
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