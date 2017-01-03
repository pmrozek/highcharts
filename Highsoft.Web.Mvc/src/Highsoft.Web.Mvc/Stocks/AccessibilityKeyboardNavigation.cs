// Type: Highsoft.Web.Mvc.Stocks.AccessibilityKeyboardNavigation


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class AccessibilityKeyboardNavigation : BaseObject
    {
        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public bool? SkipNullPoints { get; set; }

        private bool? SkipNullPoints_DefaultValue { get; set; }

        public AccessibilityKeyboardNavigation()
        {
            bool? nullable = new bool?(true);
            this.Enabled_DefaultValue = nullable;
            this.Enabled = nullable;
            nullable = new bool?(false);
            this.SkipNullPoints_DefaultValue = nullable;
            this.SkipNullPoints = nullable;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault()
                    ? (enabled.HasValue != enabledDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            bool? skipNullPoints = this.SkipNullPoints;
            bool? pointsDefaultValue = this.SkipNullPoints_DefaultValue;
            if ((skipNullPoints.GetValueOrDefault() == pointsDefaultValue.GetValueOrDefault()
                    ? (skipNullPoints.HasValue != pointsDefaultValue.HasValue ? 1 : 0)
                    : 1) != 0)
                hashtable.Add((object) "skipNullPoints", (object) this.SkipNullPoints);
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