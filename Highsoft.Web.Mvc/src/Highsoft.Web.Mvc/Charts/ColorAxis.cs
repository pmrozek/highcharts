// Type: Highsoft.Web.Mvc.Charts.ColorAxis


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class ColorAxis : BaseObject
    {
        public ColorAxis()
        {
            this.Stops = this.Stops_DefaultValue = new List<Stop>();
            double? nullable1 = new double?();
            this.Min_DefaultValue = nullable1;
            this.Min = nullable1;
            double? nullable2 = new double?();
            this.Max_DefaultValue = nullable2;
            this.Max = nullable2;
            bool? nullable3 = new bool?(false);
            this.StartOnTick_DefaultValue = nullable3;
            this.StartOnTick = nullable3;
            nullable3 = new bool?(false);
            this.EndOnTick_DefaultValue = nullable3;
            this.EndOnTick = nullable3;
            this.MinColor = this.MinColor_DefaultValue = (string) null;
            this.MaxColor = this.MaxColor_DefaultValue = (string) null;
        }

        public List<Stop> Stops { get; set; }

        private List<Stop> Stops_DefaultValue { get; set; }

        public double? Min { get; set; }

        private double? Min_DefaultValue { get; set; }

        public double? Max { get; set; }

        private double? Max_DefaultValue { get; set; }

        public bool? StartOnTick { get; set; }

        private bool? StartOnTick_DefaultValue { get; set; }

        public bool? EndOnTick { get; set; }

        private bool? EndOnTick_DefaultValue { get; set; }

        public string MinColor { get; set; }

        private string MinColor_DefaultValue { get; set; }

        public string MaxColor { get; set; }

        private string MaxColor_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Stops.Any<Stop>())
                hashtable.Add((object) "stops", (object) this.GetLists((IEnumerable) this.Stops));
            double? nullable1 = this.Min;
            double? nullable2 = this.Min_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "min", (object) this.Min);
            nullable2 = this.Max;
            nullable1 = this.Max_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "max", (object) this.Max);
            bool? nullable3 = this.StartOnTick;
            bool? nullable4 = this.StartOnTick_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "startOnTick", (object) this.StartOnTick);
            nullable4 = this.EndOnTick;
            nullable3 = this.EndOnTick_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "endOnTick", (object) this.EndOnTick);
            if (this.MinColor != this.MinColor_DefaultValue)
                hashtable.Add((object) "minColor", (object) this.MinColor);
            if (this.MaxColor != this.MaxColor_DefaultValue)
                hashtable.Add((object) "maxColor", (object) this.MaxColor);
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