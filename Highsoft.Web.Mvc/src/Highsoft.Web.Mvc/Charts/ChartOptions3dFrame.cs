// Type: Highsoft.Web.Mvc.Charts.ChartOptions3dFrame


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ChartOptions3dFrame : BaseObject
    {
        public ChartOptions3dFrame()
        {
            this.Back = this.Back_DefaultValue = new ChartOptions3dFrameBack();
            this.Bottom = this.Bottom_DefaultValue = new ChartOptions3dFrameBottom();
            this.Side = this.Side_DefaultValue = new ChartOptions3dFrameSide();
        }

        public ChartOptions3dFrameBack Back { get; set; }

        private ChartOptions3dFrameBack Back_DefaultValue { get; set; }

        public ChartOptions3dFrameBottom Bottom { get; set; }

        private ChartOptions3dFrameBottom Bottom_DefaultValue { get; set; }

        public ChartOptions3dFrameSide Side { get; set; }

        private ChartOptions3dFrameSide Side_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Back.IsDirty())
                hashtable.Add((object) "back", (object) this.Back.ToHashtable());
            if (this.Bottom.IsDirty())
                hashtable.Add((object) "bottom", (object) this.Bottom.ToHashtable());
            if (this.Side.IsDirty())
                hashtable.Add((object) "side", (object) this.Side.ToHashtable());
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