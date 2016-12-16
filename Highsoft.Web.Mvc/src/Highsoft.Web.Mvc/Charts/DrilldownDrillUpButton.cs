// Type: Highsoft.Web.Mvc.Charts.DrilldownDrillUpButton


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class DrilldownDrillUpButton : BaseObject
    {
        public Hashtable Position { get; set; }

        private Hashtable Position_DefaultValue { get; set; }

        public string RelativeTo { get; set; }

        private string RelativeTo_DefaultValue { get; set; }

        public object Theme { get; set; }

        private object Theme_DefaultValue { get; set; }

        public DrilldownDrillUpButton()
        {
            this.Position = this.Position_DefaultValue = new Hashtable();
            this.RelativeTo = this.RelativeTo_DefaultValue = "plotBox";
            this.Theme = this.Theme_DefaultValue = (object) null;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Position != this.Position_DefaultValue)
                hashtable.Add((object) "position", (object) this.Position);
            if (this.RelativeTo != this.RelativeTo_DefaultValue)
                hashtable.Add((object) "relativeTo", (object) this.RelativeTo);
            if (this.Theme != this.Theme_DefaultValue)
                hashtable.Add((object) "theme", this.Theme);
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