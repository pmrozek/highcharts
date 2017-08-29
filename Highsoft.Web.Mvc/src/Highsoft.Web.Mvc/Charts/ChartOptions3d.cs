// Type: Highsoft.Web.Mvc.Charts.ChartOptions3d


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ChartOptions3d : BaseObject
    {
        public ChartOptions3d()
        {
            double? nullable1 = new double?(0.0);
            this.Alpha_DefaultValue = nullable1;
            this.Alpha = nullable1;
            nullable1 = new double?(0.0);
            this.Beta_DefaultValue = nullable1;
            this.Beta = nullable1;
            nullable1 = new double?(100.0);
            this.Depth_DefaultValue = nullable1;
            this.Depth = nullable1;
            bool? nullable2 = new bool?(false);
            this.Enabled_DefaultValue = nullable2;
            this.Enabled = nullable2;
            nullable2 = new bool?(true);
            this.FitToPlot_DefaultValue = nullable2;
            this.FitToPlot = nullable2;
            this.Frame = this.Frame_DefaultValue = new ChartOptions3dFrame();
            nullable1 = new double?(100.0);
            this.ViewDistance_DefaultValue = nullable1;
            this.ViewDistance = nullable1;
        }

        public double? Alpha { get; set; }

        private double? Alpha_DefaultValue { get; set; }

        public double? Beta { get; set; }

        private double? Beta_DefaultValue { get; set; }

        public double? Depth { get; set; }

        private double? Depth_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? FitToPlot { get; set; }

        private bool? FitToPlot_DefaultValue { get; set; }

        public ChartOptions3dFrame Frame { get; set; }

        private ChartOptions3dFrame Frame_DefaultValue { get; set; }

        public double? ViewDistance { get; set; }

        private double? ViewDistance_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            double? nullable1 = this.Alpha;
            double? nullable2 = this.Alpha_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "alpha", (object) this.Alpha);
            nullable2 = this.Beta;
            nullable1 = this.Beta_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "beta", (object) this.Beta);
            nullable1 = this.Depth;
            nullable2 = this.Depth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "depth", (object) this.Depth);
            bool? nullable3 = this.Enabled;
            bool? nullable4 = this.Enabled_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable4 = this.FitToPlot;
            nullable3 = this.FitToPlot_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "fitToPlot", (object) this.FitToPlot);
            if (this.Frame.IsDirty())
                hashtable.Add((object) "frame", (object) this.Frame.ToHashtable());
            nullable2 = this.ViewDistance;
            nullable1 = this.ViewDistance_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "viewDistance", (object) this.ViewDistance);
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