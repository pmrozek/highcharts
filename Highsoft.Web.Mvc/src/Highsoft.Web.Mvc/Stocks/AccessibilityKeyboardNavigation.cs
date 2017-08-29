// Type: Highsoft.Web.Mvc.Stocks.AccessibilityKeyboardNavigation


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class AccessibilityKeyboardNavigation : BaseObject
    {
        public AccessibilityKeyboardNavigation()
        {
            bool? nullable = new bool?(true);
            this.Enabled_DefaultValue = nullable;
            this.Enabled = nullable;
            nullable = new bool?(false);
            this.SkipNullPoints_DefaultValue = nullable;
            this.SkipNullPoints = nullable;
        }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? SkipNullPoints { get; set; }

        private bool? SkipNullPoints_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.Enabled;
            bool? nullable2 = this.Enabled_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            nullable2 = this.SkipNullPoints;
            nullable1 = this.SkipNullPoints_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "skipNullPoints", (object) this.SkipNullPoints);
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